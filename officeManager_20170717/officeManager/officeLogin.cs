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
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Security.Cryptography;

namespace officeManager
{
    public partial class officeLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public officeLoginForm()
        {
            InitializeComponent();

            //     textBoxLogin.Text = "Admin";
            //     textBoxPassword.Text = "manage";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                // 로고 이미지 다운
                //pictureEdit1.Image = getImageDl(Config._DABOSIO_LOGO);
                
                // 유저 파일 로드
                string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "/USER.dat";
                if (File.Exists(configPath))
                {
                    byte[] encodeByte = File.ReadAllBytes(configPath);
                    string logInfo = GetString(SerializeHelper.Decode(encodeByte, "", ""));
                    string[] logInfoLines = logInfo.Split(new char[] { (char)0x09 });   // \t

                    if (logInfoLines.Length == 2)
                    {
                        if (logInfoLines[0].Equals("*") == false)
                        {
                            textBoxLogin.Text = logInfoLines[0];
                            chkIDSave.Checked = true;
                        }

                        if (logInfoLines[1].Equals("*") == false)
                        {
                            textBoxPassword.Text = logInfoLines[1];
                            chkPassSave.Checked = true;
                        }
                    }
                    else if (logInfoLines.Length == 3)  // 
                    {
                        //        MainForm._DB_COMMON._LAST_MAP_MODE = logInfoLines[3].ToString();
                        //          MainForm._DB_COMMON._LAST_MAP_SCALE = logInfoLines[4].ToString();

                        if (logInfoLines[0].Equals("*") == false)
                        {
                            textBoxLogin.Text = logInfoLines[0];
                            chkIDSave.Checked = true;
                        }

                        if (logInfoLines[1].Equals("*") == false)
                        {
                            textBoxPassword.Text = logInfoLines[1];
                            chkPassSave.Checked = true;
                          //  login();
                        }

                        if (logInfoLines[2].Equals("N") == false)
                        {
                            chkAutoLogin.Checked = true;

                            // 자동 로그인
                            if (textBoxLogin.Text.Equals("") == false && textBoxPassword.Text.Equals("") == false)
                            {
                                textBoxLogin.Enabled = false;
                                textBoxPassword.Enabled = false;
                                chkIDSave.Enabled = false;
                                chkPassSave.Enabled = false;

                                //loginTimer.Interval = 2000; // 2초
                                //loginTimer.Start();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //String strConn = "Server=db.edupool.xyz;Database=dbedupool;Uid=edupool;Pwd=edupooladmin11;";
            login();
        }

        private void login()
        {
            MySqlConnection conn = new MySqlConnection(officeMainForm.mySQL_ConnString);

            try
            {
                //MySqlDataAdapter 클래스를 이용하여 비연결 모드로 데이타 가져오기
                string sqlLogin =
                    "SELECT COUNT(*) AS CNT " +
                    "     , a.LOGIN_ID" +           // 로그인ID        : loginId
                    "     , a.USE_EXP_DT" +         // 사용만료일자     : useExpDt
                    "     , a.ALL_BRCH_ROLE_YN" +   // 모든지사권한여부 : allBrchRoleYn
                    "     , b.SALES_PSN_NO" +       // 영업자번호       : salesPsnNo
                    "     , b.SALES_PSN_NM" +       // 영업자명         : salesPsnNm
                    "     , b.SALES_DEPT_NM" +      // 영업부서명       : salesDeptNm
                    "     , b.ENTCMPY_DT" +         // 입사일자         : entcmpyDt
                    "     , b.CELL_PHON_NO" +       // 핸드폰번호       : cellPhonNo
                    "     , b.WRK_STS_CD" +         // 근무상태코드     : wrkStsCd
                    "     , b.BRCH_CD" +            // 지사코드        : brchCd
                    "     , c.BRCH_NM" +            // 지사명          : brchNm
                    "     , c.BRCH_FG_CD" +         // 지사구분코드     : brchFgCd
                    "     , c.AREA_CD" +            // 지역코드         : areaCd
                    "  FROM USER_LOGIN a" +         // UserID 관리 테이블
                    "     , SALES_PSN_INFO b" +     // 영업자 정보 테이블
                    "     , BRCH_INFO c" +          // 지사 정보 테이블
                    " WHERE a.LOGIN_ID  = b.SALES_PSN_NO" +
                    "   AND b.BRCH_CD   = c.BRCH_CD" +
                    "   AND a.LOGIN_ID  = '" + textBoxLogin.Text + "'" +
                    "   AND a.PASS_WORD = md5('" + textBoxPassword.Text + "')";

                conn.Open();   // Connection Open

                //MySqlDataReader 는 Record 단위로 접근하며, 하나의 Reader 가 열려 있으면 또다른 Reader 를 열 수 없다.
                // Login 정보 가져오기
                MySqlDataReader R_Login = new MySqlCommand(sqlLogin, conn).ExecuteReader();

                // Main Logic
                while (R_Login.Read())  // 칼럼은 배열처럼 사용하며, R[0]은 첫번째 컬럼, R[1]은 두번째 컬럼...
                {
                    // R 은 한번에 하나의 레코드에만 접근 가능
                    // R['uid'], R['name'] 으로 컬럼을 직접 명기할 수 있다.
                    //MessageBox.Show(R_Login["CNT"].ToString());
                    if (R_Login["CNT"].ToString() == "1")
                    {
                        // Login 정보 가져오기

                        officeMainForm.main_LoginId = R_Login["LOGIN_ID"].ToString();          // 로그인ID
                        officeMainForm.main_UseExpDt = R_Login["USE_EXP_DT"].ToString();        // 사용만료일자
                        officeMainForm.main_AllBrchRoleYn = R_Login["ALL_BRCH_ROLE_YN"].ToString();  // 모든지사권한여부
                        officeMainForm.main_SalesPsnNo = R_Login["SALES_PSN_NO"].ToString();      // 영업자번호
                        officeMainForm.main_SalesPsnNm = R_Login["SALES_PSN_NM"].ToString();      // 영업자명
                        officeMainForm.main_SalesDeptNm = R_Login["SALES_DEPT_NM"].ToString();     // 영업부서명
                        officeMainForm.main_EntcmpyDt = R_Login["ENTCMPY_DT"].ToString();        // 입사일자
                        officeMainForm.main_CellPhonNo = R_Login["CELL_PHON_NO"].ToString();      // 핸드폰번호
                        officeMainForm.main_WrkStsCd = R_Login["WRK_STS_CD"].ToString();        // 근무상태코드
                        officeMainForm.main_BrchCd = R_Login["BRCH_CD"].ToString();           // 지사코드
                        officeMainForm.main_BrchNm = R_Login["BRCH_NM"].ToString();           // 지사명
                        officeMainForm.main_BrchFgCd = R_Login["BRCH_FG_CD"].ToString();        // 지사구분코드
                        officeMainForm.main_AreaCd = R_Login["AREA_CD"].ToString();           // 지역코드

                        string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "/USER.dat";

                        if (chkIDSave.CheckState == CheckState.Checked || chkPassSave.CheckState == CheckState.Checked)
                        {
                            //MessageBox.Show(chkIDSave.CheckState.ToString());
                            //MessageBox.Show(chkPassSave.CheckState.ToString());

                            // 파일로 저장
                            string chkIDSaveYn = chkIDSave.CheckState == CheckState.Checked ? "Y" : "N";
                            string chkPassSaveYn = chkPassSave.CheckState == CheckState.Checked ? "Y" : "N";
                            string chkAutoLoginYn = chkAutoLogin.CheckState == CheckState.Checked ? "Y" : "N";
                            string logInfo = null;

                            if (chkAutoLoginYn == "Y")
                            {
                                logInfo = textBoxLogin.Text + (char)0x09 + textBoxPassword.Text + (char)0x09 + chkAutoLoginYn;
                            }
                            else if (chkIDSaveYn == "Y" && chkPassSaveYn == "Y")
                            {
                                logInfo = textBoxLogin.Text + (char)0x09 + textBoxPassword.Text + (char)0x09 + chkAutoLoginYn;
                            }
                            else if (chkIDSaveYn == "Y")
                            {
                                logInfo = textBoxLogin.Text + (char)0x09 + "*" + (char)0x09 + chkAutoLoginYn;
                            }
                            else if (chkPassSaveYn == "Y")
                            {
                                logInfo = "*" + (char)0x09 + textBoxPassword.Text + (char)0x09 + chkAutoLoginYn;
                            }

                            byte[] encodeByte = SerializeHelper.Encode(GetBytes(logInfo), "", "");

                            File.WriteAllBytes(configPath, encodeByte);
                        }
                        else
                        {
                            // 기존 사용자 파일이 남아있다면 제거.
                            if (File.Exists(configPath))
                            {
                                File.Delete(configPath);
                            }
                        }

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Login-ID 또는 패스워드를 잘못 입력하셨습니다.");
                        return;
                    }
                }
                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close    
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }
            finally
            {
                textBoxLogin.Enabled = true;
                textBoxPassword.Enabled = true;
                chkAutoLogin.Enabled = true;
                chkIDSave.Enabled = true;
                chkPassSave.Enabled = true;
                //    Close();
            }

        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnLogin_Click(sender, e);
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnLogin_Click(sender, e);
            }
        }

        private void chkIDSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIDSave.CheckState == CheckState.Unchecked)
            {
                if (chkAutoLogin.CheckState == CheckState.Checked)
                {
                    chkAutoLogin.Checked = false;
                }
            }
        }

        private void chkPassSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassSave.CheckState == CheckState.Unchecked)
            {
                if (chkAutoLogin.CheckState == CheckState.Checked)
                {
                    chkAutoLogin.Checked = false;
                }
            }
        }

        private void chkAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoLogin.CheckState == CheckState.Checked)
            {
                chkIDSave.Checked = true;
                chkPassSave.Checked = true;

                textBoxLogin.Enabled = false;
                textBoxPassword.Enabled = false;
                chkIDSave.Enabled = false;
                chkPassSave.Enabled = false;
            }
            else
            {
                textBoxLogin.Enabled = true;
                textBoxPassword.Enabled = true;
                chkIDSave.Enabled = true;
                chkPassSave.Enabled = true;
                chkAutoLogin.Enabled = true;
            }
        }

        public static byte[] GetBytes(string data)
        {
            return Encoding.UTF8.GetBytes(data);
        }

        public static char[] GetChars(byte[] data)
        {
            return Encoding.UTF8.GetChars(data);
        }

        public static string GetString(byte[] data)
        {
            return Encoding.UTF8.GetString(data);
        }

        public static string GetString(char[] data)
        {
            return new string(data);
        }

        //private void loginTimer_Tick(object sender, EventArgs e)
        //{
        /*
        loginTimer.Stop();

        if (chkAutoLogin.CheckState == CheckState.Checked)
        {
            login();
        }
        else
        {
            textBoxLogin.Enabled = true;
            textBoxPassword.Enabled = true;
            chkIDSave.Enabled = true;
            chkPassSave.Enabled = true;
        }
         */
        //}
    }

    public static class SerializeHelper
    {
        public static string ToXml(object Obj, System.Type ObjType)
        {
            XmlSerializer serializer = new XmlSerializer(ObjType);
            MemoryStream memStream;
            memStream = new MemoryStream();
            XmlTextWriter xmlWriter;
            xmlWriter = new XmlTextWriter(memStream, Encoding.ASCII);

            serializer.Serialize(xmlWriter, Obj);

            string xml;
            xml = Encoding.ASCII.GetString(memStream.GetBuffer());

            return xml;
        }

        public static object FromXml(string Xml, System.Type ObjType)
        {
            XmlSerializer serializer = new XmlSerializer(ObjType);
            StringReader stringReader = new StringReader(Xml);
            XmlTextReader xmlReader = new XmlTextReader(stringReader);

            object obj = serializer.Deserialize(xmlReader);

            xmlReader.Close();
            stringReader.Close();

            return obj;
        }

        public static byte[] Encode(byte[] inputData, string serialNumber, string secondKey)
        {
            try
            {
                byte[] pwdBuf;
                byte[] saltBuf;

                if (string.IsNullOrEmpty(serialNumber))
                    pwdBuf = new byte[5] { 0x00, 0x01, 0x02, 0x03, 0x04 };
                else
                    pwdBuf = Encoding.ASCII.GetBytes(serialNumber);

                if (string.IsNullOrEmpty(secondKey))
                    saltBuf = new byte[5] { 0x10, 0x11, 0x12, 0x13, 0x14 };
                else
                    saltBuf = Encoding.ASCII.GetBytes(secondKey);

                PasswordDeriveBytes myPwdBytes = new PasswordDeriveBytes(pwdBuf, saltBuf);


                MemoryStream ms = new MemoryStream();
                Rijndael rij = Rijndael.Create();
                rij.Key = myPwdBytes.GetBytes(32);
                rij.IV = myPwdBytes.GetBytes(16);

                CryptoStream cs = new CryptoStream(ms,
                   rij.CreateEncryptor(), CryptoStreamMode.Write);

                cs.Write(inputData, 0, inputData.Length);

                cs.Close();

                byte[] codedBuf = ms.ToArray();
                return codedBuf;
            }
            catch
            {
                return null;
            }
        }

        public static byte[] Decode(byte[] codedData, string serialNumber, string secondKey)
        {
            try
            {
                byte[] pwdBuf;
                byte[] saltBuf;

                if (string.IsNullOrEmpty(serialNumber))
                    pwdBuf = new byte[5] { 0x00, 0x01, 0x02, 0x03, 0x04 };
                else
                    pwdBuf = Encoding.ASCII.GetBytes(serialNumber);

                if (string.IsNullOrEmpty(secondKey))
                    saltBuf = new byte[5] { 0x10, 0x11, 0x12, 0x13, 0x14 };
                else
                    saltBuf = Encoding.ASCII.GetBytes(secondKey);

                PasswordDeriveBytes myPwdBytes = new PasswordDeriveBytes(pwdBuf, saltBuf);

                MemoryStream ms = new MemoryStream();

                Rijndael rij = Rijndael.Create();
                rij.Key = myPwdBytes.GetBytes(32);
                rij.IV = myPwdBytes.GetBytes(16);

                CryptoStream cs = new CryptoStream(ms,
                    rij.CreateDecryptor(), CryptoStreamMode.Write);

                cs.Write(codedData, 0, codedData.Length);
                cs.Close();

                byte[] decodedBuf = ms.ToArray();

                return decodedBuf;
            }
            catch
            {
                return null;
            }
        }
    }
}
