using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace officeManager
{
    public partial class MemberRegForm : DevExpress.XtraEditors.XtraForm
    {
        officeMainForm parentform;

        string query = null;
        
        public MemberRegForm(officeMainForm _parentform)
        {
            InitializeComponent();
            parentform = _parentform;
            //officeMainForm.barMsg.Caption = "";

            CB_GENDER.SelectedIndex = 0;                           // 성별 (1:남자, 2:여자)
                        
            // 콤포박스 데이터 가져오기
            CB_Qurey();

            CB_MBR_FG_CD.SelectedIndex = 0;                        // 회원구분코드 (01:신규회원, 02:재계약회원)
            TE_MBR_FG_CD.Text = CB_MBR_FG_CD.Value.ToString();     // 회원구분코드 (01)

            CB_MBR_STS_CD.SelectedIndex = 2;                       // 회원상태코드 (01:구독회원, 02:휴간회원, 03:예비회원, 04:만기회원, 05:해약회원)
            TE_MBR_STS_CD.Text = CB_MBR_STS_CD.Value.ToString();   // 회원상태코드 (03)

            CB_CNTR_FG_CD.SelectedIndex = 0;                       // 계약구분코드 (01:년납, 02:분납)
            TE_CNTR_FG_CD.Text = CB_CNTR_FG_CD.Value.ToString();   // 계약구분코드 (01)

            CB_PYMT_FG_CD.SelectedIndex = 0;                       // 결제구분코드 (01:현금, 02:카드, 03:마트, 04:CMS, 05:계좌입금)
            TE_PYMT_FG_CD.Text = CB_PYMT_FG_CD.Value.ToString();   // 결제구분코드 (01)

            //CB_WRK_STS_CD.SelectedIndex = 0;                       // 근무상태코드 (01:재직, 02:휴직, 09:퇴사)

            CB_SUBJ_CD.SelectedIndex = 0;                          // 과목 종류 코드 (11:일일공부, 21:베베톡톡, 22:키즈톡톡, 23:누리톡톡, 24:퍼니버스, 31:꾸러기서당, 41:키즈팟영어, 51:노벨상아이)
            TE_SUBJ_CD.Text = CB_SUBJ_CD.Value.ToString();         // 과목 종류 코드 (11)

            // 과목 > 레벨 정보 가져오기
            CB_SUBJ_LVL_CD_Qurey();
            CB_LVL_CD.SelectedIndex = 0;                           // 과목 종류 코드 (01:레벨1, 02:레벨2, 03:레벨3, 04:레벨4, 05:레벨5)
            TE_LVL_CD.Text = CB_LVL_CD.Value.ToString();           // 과목 종류 코드 (01)

            // 과목 > 레벨 > 구독료 정보 가져오기
            TE_SUBS_AMT_Qurey();

            // 로그인 지점 영업자 정보 가져오기 - (영업자, 지사명, 부서명, 전화번호, 재직상태)
            CB_SALES_PSN_INFO_Qurey();
            CB_SALES_PSN_INFO.Value = officeMainForm.main_SalesPsnNo;

            TE_MBR_FG_CD.Focus();

            //officeMainForm ofm = (officeMainForm)this.ParentForm;
            //parentform.barMsgText("aaa");

        }

        private void CB_Qurey()
        {
            MySqlConnection conn = new MySqlConnection(officeMainForm.mySQL_ConnString);

            MySqlDataReader R_Login = null;

            try
            {

                /////////////////////////////////////////////
                //  CB_MBR_FG_CD[회원구분] 데이터 가져오기
                /////////////////////////////////////////////
                query = "SELECT COMM_CD, COMM_CD_NM FROM COM_CODE WHERE GRP_CD = 'MBR_FG' ORDER BY ORD_SEQ ";

                conn.Open();   // Connection Open

                //MySqlDataReader 는 Record 단위로 접근하며, 하나의 Reader 가 열려 있으면 또다른 Reader 를 열 수 없다.
                // Login 정보 가져오기
                R_Login = new MySqlCommand(query, conn).ExecuteReader();

                // Main Logic
                while (R_Login.Read())  // 칼럼은 배열처럼 사용하며, R[0]은 첫번째 컬럼, R[1]은 두번째 컬럼...
                {
                    CB_MBR_FG_CD.Properties.Items.Add(R_Login["COMM_CD_NM"].ToString(), R_Login["COMM_CD"].ToString(), -1);
                }

                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close    


                /////////////////////////////////////////////
                //  CB_MBR_STS_CD[회원상태] 데이터 가져오기
                /////////////////////////////////////////////
                query = "SELECT COMM_CD, COMM_CD_NM FROM COM_CODE WHERE GRP_CD = 'MBR_ST' ORDER BY ORD_SEQ ";

                conn.Open();   // Connection Open
                R_Login = new MySqlCommand(query, conn).ExecuteReader();

                while (R_Login.Read())
                {
                    CB_MBR_STS_CD.Properties.Items.Add(R_Login["COMM_CD_NM"].ToString(), R_Login["COMM_CD"].ToString(), -1);
                }

                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close    


                /////////////////////////////////////////////
                //  CB_CNTR_FG_CD[계약구분] 데이터 가져오기 - 년납/분납
                /////////////////////////////////////////////
                query = "SELECT COMM_CD, COMM_CD_NM FROM COM_CODE WHERE GRP_CD = 'CNTR_FG' ORDER BY ORD_SEQ ";

                conn.Open();   // Connection Open
                R_Login = new MySqlCommand(query, conn).ExecuteReader();

                while (R_Login.Read())
                {
                    CB_CNTR_FG_CD.Properties.Items.Add(R_Login["COMM_CD_NM"].ToString(), R_Login["COMM_CD"].ToString(), -1);
                }

                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close    


                /////////////////////////////////////////////
                //  CB_PYMT_FG_CD[결제구분] 데이터 가져오기 - 입금수단
                /////////////////////////////////////////////
                query = "SELECT COMM_CD, COMM_CD_NM FROM COM_CODE WHERE GRP_CD = 'PYMT_FG' ORDER BY ORD_SEQ ";

                conn.Open();   // Connection Open
                R_Login = new MySqlCommand(query, conn).ExecuteReader();

                while (R_Login.Read())
                {
                    CB_PYMT_FG_CD.Properties.Items.Add(R_Login["COMM_CD_NM"].ToString(), R_Login["COMM_CD"].ToString(), -1);
                }

                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close    


                /////////////////////////////////////////////
                //  CB_WRK_STS_CD[근무상태] 데이터 가져오기 - 재직상태
                /////////////////////////////////////////////
                query = "SELECT COMM_CD, COMM_CD_NM FROM COM_CODE WHERE GRP_CD = 'WRK_STS' ORDER BY ORD_SEQ ";

                conn.Open();   // Connection Open
                R_Login = new MySqlCommand(query, conn).ExecuteReader();

                while (R_Login.Read())
                {
                    CB_WRK_STS_CD.Properties.Items.Add(R_Login["COMM_CD_NM"].ToString(), R_Login["COMM_CD"].ToString(), -1);
                }

                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close    


                /////////////////////////////////////////////
                //  CB_SUBJ_CD[과목코드] 데이터 가져오기
                /////////////////////////////////////////////
                query = "SELECT SUBJ_CD, SUBJ_NM FROM SUBJ_INFO WHERE BRCH_CD = '" + officeMainForm.main_BrchCd + "' ORDER BY SUBJ_CD ";

                conn.Open();   // Connection Open
                R_Login = new MySqlCommand(query, conn).ExecuteReader();

                while (R_Login.Read())  // 칼럼은 배열처럼 사용하며, R[0]은 첫번째 컬럼, R[1]은 두번째 컬럼...
                {
                    CB_SUBJ_CD.Properties.Items.Add(R_Login["SUBJ_NM"].ToString(), R_Login["SUBJ_CD"].ToString(), -1);
                }

                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }
        }

        // 과목 > 레벨 정보 가져오기
        private void CB_SUBJ_LVL_CD_Qurey()
        {
            MySqlConnection conn = new MySqlConnection(officeMainForm.mySQL_ConnString);

            MySqlDataReader R_Login = null;

            CB_LVL_CD.Properties.Items.Clear();

            try
            {
                //CB_LVL_CD[레벨코드] 데이터 가져오기
                query = "SELECT LVL_CD, LVL_NM FROM SUBJ_LVL WHERE BRCH_CD = '" + officeMainForm.main_BrchCd + "' AND SUBJ_CD = '" + TE_SUBJ_CD.Text.ToString() + "' ORDER BY LVL_CD ";

                conn.Open();   // Connection Open
                R_Login = new MySqlCommand(query, conn).ExecuteReader();

                while (R_Login.Read())  // 칼럼은 배열처럼 사용하며, R[0]은 첫번째 컬럼, R[1]은 두번째 컬럼...
                {
                    CB_LVL_CD.Properties.Items.Add(R_Login["LVL_NM"].ToString(), R_Login["LVL_CD"].ToString(), -1);
                }

                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }
        }

        // 과목 > 레벨 > 구독료 정보 가져오기
        private void TE_SUBS_AMT_Qurey()
        {
            MySqlConnection conn = new MySqlConnection(officeMainForm.mySQL_ConnString);

            MySqlDataReader R_Login = null;

            try
            {
                //CB_LVL_CD[레벨코드] 데이터 가져오기
                query = "SELECT SUBS_AMT FROM SUBJ_INFO WHERE BRCH_CD = '" + officeMainForm.main_BrchCd + "' AND SUBJ_CD = '" + TE_SUBJ_CD.Text.ToString() + "' ";

                conn.Open();   // Connection Open
                R_Login = new MySqlCommand(query, conn).ExecuteReader();

                while (R_Login.Read())  // 칼럼은 배열처럼 사용하며, R[0]은 첫번째 컬럼, R[1]은 두번째 컬럼...
                {
                    TE_SUBS_AMT.Text = R_Login["SUBS_AMT"].ToString();
                    //TE_SUBS_AMT.Text = String.Format("{0:0,0}", R_Login["SUBS_AMT"]);
                }

                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }
        }

        // 로그인 지점 영업자 정보 가져오기
        private void CB_SALES_PSN_INFO_Qurey()
        {
            MySqlConnection conn = new MySqlConnection(officeMainForm.mySQL_ConnString);

            MySqlDataReader R_Login = null;

            CB_SALES_PSN_INFO.Properties.Items.Clear();

            try
            {
                //CB_LVL_CD[레벨코드] 데이터 가져오기
                query = "SELECT SALES_PSN_NO, SALES_PSN_NM FROM SALES_PSN_INFO WHERE BRCH_CD = '" + officeMainForm.main_BrchCd + "'";

                conn.Open();   // Connection Open
                R_Login = new MySqlCommand(query, conn).ExecuteReader();

                while (R_Login.Read())  // 칼럼은 배열처럼 사용하며, R[0]은 첫번째 컬럼, R[1]은 두번째 컬럼...
                {
                    CB_SALES_PSN_INFO.Properties.Items.Add(R_Login["SALES_PSN_NM"].ToString(), R_Login["SALES_PSN_NO"].ToString(), -1);
                }

                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }
        }

        // 영업자 정보 가져오기 - 영업자, 지사명, 부서명, 전화번호, 재직상태
        private void TB_SALES_PSN_INFO_Qurey()
        {
            MySqlConnection conn = new MySqlConnection(officeMainForm.mySQL_ConnString);

            MySqlDataReader R_Login = null;

            try
            {
                //CB_LVL_CD[레벨코드] 데이터 가져오기
                query = "SELECT SALES_PSN_NO, SALES_PSN_NM, BRCH_CD, SALES_DEPT_NM, CELL_PHON_NO, WRK_STS_CD FROM SALES_PSN_INFO WHERE BRCH_CD = '" + officeMainForm.main_BrchCd + "' AND SALES_PSN_NO = '" + CB_SALES_PSN_INFO.Value.ToString() + "' ";

                conn.Open();   // Connection Open
                R_Login = new MySqlCommand(query, conn).ExecuteReader();

                while (R_Login.Read())  // 칼럼은 배열처럼 사용하며, R[0]은 첫번째 컬럼, R[1]은 두번째 컬럼...
                {
                    TE_BRCH_NM.Text = R_Login["BRCH_CD"].ToString();
                    TE_SALES_DEPT_NM.Text = R_Login["SALES_DEPT_NM"].ToString();
                    TE_CELL_PHON_NO.Text = R_Login["CELL_PHON_NO"].ToString();
                    CB_WRK_STS_CD.Value = R_Login["WRK_STS_CD"].ToString();
                }

                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }
        }

        // 회원구분 필드
        private void TE_MBR_FG_CD_TextChanged(object sender, EventArgs e)
        {
            CB_MBR_FG_CD.Value = TE_MBR_FG_CD.Text.ToString();
            if (TE_MBR_FG_CD.Text.Length == 2) TE_MBR_NM.Focus();
        }
        private void CB_MBR_FG_CD_SelectedIndexChanged(object sender, EventArgs e)
        {
            TE_MBR_FG_CD.Text = CB_MBR_FG_CD.Value.ToString();
        }

        // 성별 필드
        private void TE_GENDER_TextChanged(object sender, EventArgs e)
        {
            CB_GENDER.Value = TE_GENDER.Text.ToString();
            if (TE_GENDER.Text.Length == 1) DT_BIRTH_DT.Focus();
        }
        private void CB_GENDER_SelectedIndexChanged(object sender, EventArgs e)
        {
            TE_GENDER.Text = CB_GENDER.Value.ToString();
        }

        // 생년월일 필드
        private void DT_BIRTH_DT_Leave(object sender, EventArgs e)
        {
            // 나이 계산 로직
            if(DT_BIRTH_DT.Text.ToString() != "")
            {
                int y_now = Convert.ToInt32(System.DateTime.Now.ToShortDateString().Substring(0, 4));
                int y_age = Convert.ToInt32(DT_BIRTH_DT.Text.Substring(0, 4));
                int r_age = y_now - y_age + 1;
                TE_Age.Text = r_age.ToString();
            }
        }

        // 회원상태코드 필드
        private void TE_MBR_STS_CD_TextChanged(object sender, EventArgs e)
        {
            CB_MBR_STS_CD.Value = TE_MBR_STS_CD.Text.ToString();
            if (TE_MBR_STS_CD.Text.Length == 2) TE_SUBJ_CD.Focus();
        }
        private void CB_MBR_STS_CD_SelectedIndexChanged(object sender, EventArgs e)
        {
            TE_MBR_STS_CD.Text = CB_MBR_STS_CD.Value.ToString();
        }

        // 년납/분납 필드
        private void TE_CNTR_FG_CD_TextChanged(object sender, EventArgs e)
        {
            CB_CNTR_FG_CD.Value = TE_CNTR_FG_CD.Text.ToString();
            if (TE_CNTR_FG_CD.Text.Length == 2) TE_PYMT_FG_CD.Focus();
        }
        private void CB_CNTR_FG_CD_SelectedIndexChanged(object sender, EventArgs e)
        {
            TE_CNTR_FG_CD.Text = CB_CNTR_FG_CD.Value.ToString();
        }

        // 입금수단 필드
        private void TE_PYMT_FG_CD_TextChanged(object sender, EventArgs e)
        {
            CB_PYMT_FG_CD.Value = TE_PYMT_FG_CD.Text.ToString();
            if (TE_PYMT_FG_CD.Text.Length == 2) TE_ALLOT_MM_CNT.Focus();
        }
        private void CB_PYMT_FG_CD_SelectedIndexChanged(object sender, EventArgs e)
        {
            TE_PYMT_FG_CD.Text = CB_PYMT_FG_CD.Value.ToString();
        }

        // 과목 필드
        private void TE_SUBJ_CD_TextChanged(object sender, EventArgs e)
        {
            CB_SUBJ_CD.Value = TE_SUBJ_CD.Text.ToString();
            if (TE_SUBJ_CD.Text.Length == 2)
            {
                TE_LVL_CD.Focus();

                // 과목 레벨 정보 가져오기
                CB_SUBJ_LVL_CD_Qurey();
                CB_LVL_CD.SelectedIndex = 0;
                TE_LVL_CD.Text = CB_LVL_CD.Value.ToString();

                // 과목 > 레벨 > 구독료 정보 가져오기
                TE_SUBS_AMT_Qurey();

                // 총 구독료 계산
                int i_TE_SUBS_AMT = Convert.ToInt32(TE_SUBS_AMT.Text.ToString());
                int i_TE_SUBS_MM_CNT = Convert.ToInt32(TE_SUBS_MM_CNT.Text.ToString());
                int i_TE_CNTR_AMT = i_TE_SUBS_AMT * i_TE_SUBS_MM_CNT;
                TE_CNTR_AMT.Text = i_TE_CNTR_AMT.ToString();
            }
        }
        private void CB_SUBJ_CD_SelectedIndexChanged(object sender, EventArgs e)
        {
            TE_SUBJ_CD.Text = CB_SUBJ_CD.Value.ToString();
        }

        // 레벨 필드
        private void TE_LVL_CD_TextChanged(object sender, EventArgs e)
        {
            CB_LVL_CD.Value = TE_LVL_CD.Text.ToString();
            if (TE_LVL_CD.Text.Length == 2) TE_SUBS_MM_CNT.Focus();
        }
        private void CB_LVL_CD_SelectedIndexChanged(object sender, EventArgs e)
        {
            TE_LVL_CD.Text = CB_LVL_CD.Value.ToString();
        }

        // 계약기간 필드
        private void TE_SUBS_MM_CNT_TextChanged(object sender, EventArgs e)
        {
            if (TE_SUBS_MM_CNT.Text.Length == 2)
            {
                TE_ZIP_NO.Focus();

                // 총 구독료 계산
                int i_TE_SUBS_AMT = Convert.ToInt32(TE_SUBS_AMT.Text.ToString());
                int i_TE_SUBS_MM_CNT = Convert.ToInt32(TE_SUBS_MM_CNT.Text.ToString());
                int i_TE_CNTR_AMT = i_TE_SUBS_AMT * i_TE_SUBS_MM_CNT;
                TE_CNTR_AMT.Text = i_TE_CNTR_AMT.ToString();
                //TE_CNTR_AMT.Text = String.Format("{0:0,0}", i_TE_CNTR_AMT);
            }
        }

        // 주소 조회 이미지
        private void PIC_Search_Click(object sender, EventArgs e)
        {
            String zipCd = "";
            String roadAddr1 = "";
            String dongAddr1 = "";

            postPopupForm postPopup = new postPopupForm();
            //DialogResult loginDlgResult = postPopup.ShowDialog(this);

            postPopup.ShowDialog(this);

            zipCd = officeMainForm.main_ZipCd;
            roadAddr1 = officeMainForm.main_RoadAddr1;
            dongAddr1 = officeMainForm.main_DongAddr1;

            TE_ZIP_NO.Text = zipCd;
            TE_ADDR1.Text = roadAddr1;

            TE_ADDR2.Focus();
        }

        // 영업자 정보 필드
        private void CB_SALES_PSN_INFO_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 영업자 정보 가져오기 - 영업자, 지사명, 부서명, 전화번호, 재직상태
            TB_SALES_PSN_INFO_Qurey();
        }

        // 조회 버튼 클릭
        private void simpleButtonQuery_Click(object sender, EventArgs e)
        {
            memSearchPopupForm memPopup = new memSearchPopupForm(textEditMember.Text, this);
            //DialogResult loginDlgResult = postPopup.ShowDialog(this);

            memPopup.ShowDialog(this);
        }
        // 조회 버튼 클릭
        public void getMember(string memid,string seq)
        {
            MySqlConnection conn = new MySqlConnection(officeMainForm.mySQL_ConnString);

            MySqlDataReader R_Login = null;

            try
            {
                //CB_LVL_CD[레벨코드] 데이터 가져오기
                int iseq = Convert.ToInt32(seq);
                mySQL_MBR_SUBJ_APPLY_Select(memid, iseq);

                conn.Open();   // Connection Open
                R_Login = new MySqlCommand(query, conn).ExecuteReader();

                while (R_Login.Read())  // 칼럼은 배열처럼 사용하며, R[0]은 첫번째 컬럼, R[1]은 두번째 컬럼...
                {
                    TE_MBR_NO.Text    = R_Login["MBR_NO"].ToString();
                    TE_APPLY_SEQ.Text = R_Login["APPLY_SEQ"].ToString();
                    TE_MBR_NM.Text    = R_Login["MBR_NM"].ToString();
                }

                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }

            parentform.barMsgText("조회 버튼 클릭");

        }

        // MBR_SUBJ_APPLY Select
        private void mySQL_MBR_SUBJ_APPLY_Select(string iMBR_NO, int iAPPLY_SEQ)
        {
            query =
                "SELECT MBR_NO            " +    // 회원번호
                "     , APPLY_SEQ         " +    // 회원번호 일련번호
                "     , MBR_NM            " +    // 회원명
                "     , BIRTH_DT          " +    // 생년월일
                "     , GENDER            " +    // 성별
                "     , SUBJ_CD           " +    // 과목코드
                "     , LVL_CD            " +    // 레벨코드
                "     , CNTR_FG_CD        " +    // 년납/분납 코드
                "     , SUBS_AMT          " +    // 구독료
                "     , SUBS_MM_CNT       " +    // 계약기간
                "     , MBR_FG_CD         " +    // 회원구분
                "     , CTRTR_NM          " +    // 계약자명
                "     , MBR_REL_NM        " +    // 회원과의 관계
                "     , PHON_NO           " +    // 대표 연락처
                "     , PHON_NO2          " +    // 보조 연락처
                "     , ZIP_NO            " +    // 주소-우편번호
                "     , ADDR1             " +    // 주소-시구동
                "     , ADDR2             " +    // 주소-상세주소
                "     , CNTR_AMT          " +    // 총 구독료
                "     , SALES_PSN_NO      " +    // 영업자번호
                "     , CNTR_PLC          " +    // 계약 장소
                "     , CNTR_MEMO         " +    // 계약 메모  ---- 화면에서 입력받는 부분 없음
                "     , APPLY_DT          " +    // 신청일자
                "     , STD_STR_DT        " +    // 학습시작일자
                "     , STD_END_DT        " +    // 학습종료일자
                "     , STD_STR_HO        " +    // 시작호
                "     , CNCL_DT           " +    // 구독만료일자
                "     , CNCL_AMT_PAY_DT   " +    // 해약금 지급일자
                "     , CNCL_PLN_AMT      " +    // 해약금 지급예정액
                "     , REMNT_10P_AMT     " +    // 구독 위약금
                "     , CNCL_AMT          " +    // 해약금액
                "     , MNGT_FEE          " +    // 관리비
                "     , PYMT_FG_CD        " +    // 입금수단코드
                "     , MBR_STS_CD        " +    // 회원상태코드
                "     , LAST_DELV_HO      " +    // 최종 발송호
                "     , BRCH_CD           " +    // 지사코드  ---- 테이블 데이터 Insert 할때 회원번호 채번과 동시에, 해당 지접을 파악에서 값을 넣어줘야 될 것 같음.
                "     , FILE_NM           " +    // 계약서 파일명
                "     , REG_ID            " +    // 등록자ID
                "     , REG_DTTM          " +    // 등록일시
                "     , UPDT_ID           " +    // 수정자ID
                "     , UPDT_DTTM         " +    // 수정일시
                "     , ALLOT_MM_CNT      " +    // 분납개월수
                "     , PYMT_DY           " +    // 결제일   ---- 결제일이 화면에서 입력받는 부분이 없음.... ㅡ.ㅡ...
                "     , STD_STR_YM        " +    // 학습시작년월  -- 학습시작일자 Insert 시 학습시작년월 넣어주면 좋을 듯
                "     , STD_END_YM        " +    // 학습종료년월  -- 학습종료일자 Insert 시 학습종료년월 넣어주면 좋을 듯
                "     , REMNT_AMT         " +    // 잔여구독료
                "     , PROD_LOSS_RT      " +    // 지급상품손율
                "     , PRODCOST_LOSS_AMT " +    // 상품비 손율금액
                "     , REMNT_MM_CNT      " +    // 잔여개월수
                "     , PAY_DT            " +    // 지급일자
                "     , PROD_LOSSRT_STD   " +    // 상품 손율 기준
                "     , CNCL_TOT_AMT      " +    // 해약총금액
                "  FROM MBR_SUBJ_APPLY    " +
                " WHERE MBR_NO         = '" + iMBR_NO + "'" +
                "   AND APPLY_SEQ      = '" + iAPPLY_SEQ + "'";
        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "신규")
            {
                TE_MBR_NO.Text = " ";
                TE_APPLY_SEQ.Text = " ";
                TE_MBR_NM.Text = " ";

                parentform.barMsgText("신규 버튼 클릭");
            }
            
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEditMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                // Enter key pressed

                simpleButtonQuery_Click(null, null);
            }
         

        }

    }
}