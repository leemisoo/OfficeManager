using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;


namespace officeManager
{
    public partial class officeMainForm : RibbonForm
    {
        // MySQL Connection 정보
        public static string mySQL_Server = "db.edupool.xyz";
        public static string mySQL_Port = "3306";
        public static string mySQL_Database = "dbedupool";
        public static string mySQL_UserName = "edupool";
        public static string mySQL_UserPassword = "edupooladmin11";

        public static string mySQL_ConnString = string.Format("SERVER={0};PORT={1};DATABASE={2};USER ID={3};PASSWORD={4};POOLING=TRUE",
                             mySQL_Server, mySQL_Port, mySQL_Database, mySQL_UserName, mySQL_UserPassword);
        
        // 사용자 로그인 정보
        public static string main_LoginId = "";        // 로그인ID
        public static string main_UseExpDt = "";       // 사용만료일자
        public static string main_AllBrchRoleYn = "";  // 모든지사권한여부

        // 영업자 정보
        public static string main_SalesPsnNo = "";     // 영업자번호
        public static string main_SalesPsnNm = "";     // 영업자명
        public static string main_SalesDeptNm = "";    // 영업부서명
        public static string main_EntcmpyDt = "";      // 입사일자
        public static string main_CellPhonNo = "";     // 핸드폰번호
        public static string main_WrkStsCd = "";       // 근무상태코드

        // 지사 정보
        public static string main_BrchCd = "";         // 지사코드
        public static string main_BrchNm = "";         // 지사명
        public static string main_BrchFgCd = "";       // 지사구분코드
        public static string main_AreaCd = "";         // 지역코드

        // 주소 정보
        public static string main_ZipCd = "";          // 우편번호
        public static string main_RoadAddr1 = "";      // 도로명주소
        public static string main_DongAddr1 = "";      // 동주소(구주소)

        public officeMainForm()
        {
            InitializeComponent();
            //InitSkinGallery();
            //InitGrid();

        }
        public void barMsgText(string msg)
        {
            barMsg.Caption = msg;
        }
        /*
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        BindingList<Person> gridDataList = new BindingList<Person>();
        void InitGrid()
        {
            gridDataList.Add(new Person("John", "Smith"));
            gridDataList.Add(new Person("Gabriel", "Smith"));
            gridDataList.Add(new Person("Ashley", "Smith", "some comment"));
            gridDataList.Add(new Person("Adrian", "Smith", "some comment"));
            gridDataList.Add(new Person("Gabriella", "Smith", "some comment"));
            //gridControl.DataSource = gridDataList;
        }
        */

        private void officeMainForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            
            officeLoginForm Login = new officeLoginForm();
            DialogResult loginDlgResult = Login.ShowDialog(this);

            if (loginDlgResult == DialogResult.Cancel)
            {
                // 어플리케이션 종료.
                Dispose();
            }
            else
            {
                barUserID.Caption = main_SalesPsnNo;
                barUserNm.Caption = main_SalesPsnNm;
                barBrch.Caption = main_BrchNm;
            }
            
        }

        // 회원관리 메뉴에서 [종료] 이벤트
        private void barBtnMemberExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        // 관리자 메뉴에서 [종료] 이벤트
        private void barBtnAdminExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        // 관리자 메뉴에서 [공통코드 등록] 버튼 클릭 이벤트
        private void barBtnAdminCommCdReg_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.Panel2.Controls.Clear();

            adminCommCdRegForm CommCdReg = new adminCommCdRegForm();
            CommCdReg.TopLevel = false;
            CommCdReg.Dock = System.Windows.Forms.DockStyle.Fill;

            splitContainerControl.Panel2.Controls.Add(CommCdReg);

            CommCdReg.Show();
        }

        // 관리자 메뉴에서 [지점 등록] 버튼 클릭 이벤트
        private void barBtnAdminBrchReg_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.Panel2.Controls.Clear();

            adminBrchRegForm BrchReg = new adminBrchRegForm();
            BrchReg.TopLevel = false;
            BrchReg.Dock = System.Windows.Forms.DockStyle.Fill;

            splitContainerControl.Panel2.Controls.Add(BrchReg);

            BrchReg.Show();
        }

        // 관리자 메뉴에서 [사용자 등록] 버튼 클릭 이벤트
        private void barBtnAdminUserReg_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.Panel2.Controls.Clear();

            adminUserRegForm UserReg = new adminUserRegForm();
            UserReg.TopLevel = false;
            UserReg.Dock = System.Windows.Forms.DockStyle.Fill;

            splitContainerControl.Panel2.Controls.Add(UserReg);

            UserReg.Show();
        }

        // 관리자 메뉴에서 [권한 관리] 버튼 클릭 이벤트
        private void barBtnAdminAuthReg_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.Panel2.Controls.Clear();

            adminAuthMngForm AuthMng = new adminAuthMngForm();
            AuthMng.TopLevel = false;
            AuthMng.Dock = System.Windows.Forms.DockStyle.Fill;

            splitContainerControl.Panel2.Controls.Add(AuthMng);

            AuthMng.Show();
        }

        // 회원관리 메뉴에서 [회원 등록] 버튼 클릭 이벤트
        private void barBtnMemberReg_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.Panel2.Controls.Clear();

            MemberRegForm MemberReg = new MemberRegForm(this);
            MemberReg.TopLevel = false;
            MemberReg.Dock = System.Windows.Forms.DockStyle.Fill;

            splitContainerControl.Panel2.Controls.Add(MemberReg);

            MemberReg.Show();
        }

        // 회원관리 메뉴에서 [회원 조회] 버튼 클릭 이벤트
        private void barBtnMemberQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.Panel2.Controls.Clear();

            MemberQueryForm MemberQuery = new MemberQueryForm();
            //postPopupForm MemberQuery = new postPopupForm();
            MemberQuery.TopLevel = false;
            MemberQuery.Dock = System.Windows.Forms.DockStyle.Fill;

            splitContainerControl.Panel2.Controls.Add(MemberQuery);

            MemberQuery.Show();
        }

        // 회원관리 메뉴에서 [운영 관리] 버튼 클릭 이벤트
        private void barBtnMemberMng_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.Panel2.Controls.Clear();

            MemberMngForm MemberMng = new MemberMngForm();
            MemberMng.TopLevel = false;
            MemberMng.Dock = System.Windows.Forms.DockStyle.Fill;

            splitContainerControl.Panel2.Controls.Add(MemberMng);

            MemberMng.Show();
        }

        // 회원관리 메뉴에서 [업무자 등록] 버튼 클릭 이벤트
        private void barBtnMemberSales_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.Panel2.Controls.Clear();

            MemberSalesForm MemberSales = new MemberSalesForm();
            MemberSales.TopLevel = false;
            MemberSales.Dock = System.Windows.Forms.DockStyle.Fill;

            splitContainerControl.Panel2.Controls.Add(MemberSales);

            MemberSales.Show();
        }

        // 회원관리 메뉴에서 [제품 등록] 버튼 클릭 이벤트
        private void barBtnMemberProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.Panel2.Controls.Clear();

            MemberProductForm MemberProduct = new MemberProductForm();
            MemberProduct.TopLevel = false;
            MemberProduct.Dock = System.Windows.Forms.DockStyle.Fill;

            splitContainerControl.Panel2.Controls.Add(MemberProduct);

            MemberProduct.Show();
        }

        // 회원관리 메뉴에서 [판촉물 등록] 버튼 클릭 이벤트
        private void barBtnMemberGift_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.Panel2.Controls.Clear();

            MemberGiftForm MemberGift = new MemberGiftForm();
            MemberGift.TopLevel = false;
            MemberGift.Dock = System.Windows.Forms.DockStyle.Fill;

            splitContainerControl.Panel2.Controls.Add(MemberGift);

            MemberGift.Show();
        }

        private void iAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.itempooledu.co.kr/");
            //System.Diagnostics.ProcessStartInfo pro = new System.Diagnostics.ProcessStartInfo("iexplore.exe", "http://www.itempooledu.co.kr/");
            //System.Diagnostics.Process.Start(pro);
        }
    }
}
