using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DataAccess.Sql;
using MySql.Data.MySqlClient;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraGrid.EditForm.Helpers.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace officeManager
{
    public partial class adminBrchRegForm : DevExpress.XtraEditors.XtraForm
    {

        private MySqlConnection _DB_MYSQL_CONNECT = null;

        string query = null;

        public void conn_DB_MYSQL_CONNECT_open()
        {
            try
            {
                if (_DB_MYSQL_CONNECT != null)
                    _DB_MYSQL_CONNECT.Close();

                _DB_MYSQL_CONNECT = new MySqlConnection(officeMainForm.mySQL_ConnString);
                _DB_MYSQL_CONNECT.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DB Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void conn_DB_MYSQL_CONNECT_close()
        {
            _DB_MYSQL_CONNECT.Close();
        }
        
        public adminBrchRegForm()
        {
            InitializeComponent();

            // 콤포박스 데이터 가져오기
            CB_Qurey();

            String BRCH_FG_from = null;
            String BRCH_FG_to = null;
            String AREA_CD_from = null;
            String AREA_CD_to = null;

            ComboBoxBRCH_FG.Value = "A";
            ComboBoxAREA_CD.Value = "A";

            BRCH_FG_from = "0";
            BRCH_FG_to = "9";

            AREA_CD_from = "0";
            AREA_CD_to = "9";

            adminBrchRegForm_BRCH_INFO_Qury(BRCH_FG_from, BRCH_FG_to, AREA_CD_from, AREA_CD_to);
        }

        // BRCH_INFO Data Query
        public void adminBrchRegForm_BRCH_INFO_Qury(string BRCH_FG_from, string BRCH_FG_to, string AREA_CD_from, string AREA_CD_to)
        {

            conn_DB_MYSQL_CONNECT_open();

            try
            {
                DataTable table = new DataTable();

                for (int i = 0; i < gridViewBrchInfo.Columns.Count; i++)
                {
                    DevExpress.XtraGrid.Columns.GridColumn column = gridViewBrchInfo.Columns[i];
                    if (column.FieldName == "ORD_SEQ")
                    {
                        table.Columns.Add(column.FieldName, typeof(decimal));
                    }
                    else
                    {
                        table.Columns.Add(column.FieldName, typeof(string));
                    }
                }

                // Select Query
                mySQL_BRCH_INFO_Select(BRCH_FG_from, BRCH_FG_to, AREA_CD_from, AREA_CD_to);

                MySqlCommand command = new MySqlCommand(query, _DB_MYSQL_CONNECT);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader.GetValue(i);
                        //row[i] = i;
                    }

                    table.Rows.Add(row);
                }

                reader.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn_DB_MYSQL_CONNECT_close();  // Connection Close     

                gridConBrchInfo.DataSource = table;
                //gridViewCommCdMaster.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonQuery_Click(object sender, EventArgs e)
        {
            simpleButtonQuery_ClickQuery();
        }

        private void simpleButtonQuery_ClickQuery()
        {
            String BRCH_FG_from, BRCH_FG_to;
            String AREA_CD_from, AREA_CD_to;

            if (ComboBoxBRCH_FG.Value == "A")
            {
                BRCH_FG_from = "0";
                BRCH_FG_to = "9";
            }
            else
            {
                BRCH_FG_from = ComboBoxBRCH_FG.Value.ToString();
                BRCH_FG_to = ComboBoxBRCH_FG.Value.ToString();
            }

            if (ComboBoxAREA_CD.Value == "A")
            {
                AREA_CD_from = "0";
                AREA_CD_to = "9";
            }
            else
            {
                AREA_CD_from = ComboBoxAREA_CD.Value.ToString();
                AREA_CD_to = ComboBoxAREA_CD.Value.ToString();
            }

            adminBrchRegForm_BRCH_INFO_Qury(BRCH_FG_from, BRCH_FG_to, AREA_CD_from, AREA_CD_to);
        }

        private void grpConBrchInfo_CustomButtonClick(object sender, BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "행추가")
            {
                gridViewBrchInfo.AddNewRow();
            }

            if (e.Button.Properties.Caption == "행삭제")
            {
                if (MessageBox.Show("삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn_DB_MYSQL_CONNECT_open();
                    try
                    {
                        // Delete Query
                        string iBRCH_CD = gridViewBrchInfo.GetRowCellValue(gridViewBrchInfo.FocusedRowHandle, "BRCH_CD").ToString();
                        mySQL_BRCH_INFO_Delete(iBRCH_CD);

                        MySqlCommand command = new MySqlCommand(query, _DB_MYSQL_CONNECT);
                        command.ExecuteReader();

                        conn_DB_MYSQL_CONNECT_close();  // Connection Close     
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    gridViewBrchInfo.DeleteSelectedRows();
                }
            }

            if (e.Button.Properties.Caption == "저장")
            {
                string iBRCH_CD = null;
                string iBRCH_NM = null; 
                string iBRCH_FG_CD = null;
                string iAREA_CD = null;
                string iZIP_NO = null;
                string iADDR1 = null;
                string iADDR2 = null;
                string iPHON_NO = null;
                string iFAX_NO = null;
                string iBIZ_REG_NO = null;
                string iREPR_NM = null;

                for (int i = 0; i < gridViewBrchInfo.RowCount; i++)
                {
                    if (gridViewBrchInfo.GetRowCellValue(i, "BRCH_CD").ToString().Trim() != "")
                    {
                        if (gridViewBrchInfo.GetRowCellValue(i, "CRUD").ToString() == "I")
                        {
                            iBRCH_CD = gridViewBrchInfo.GetRowCellValue(i, "BRCH_CD").ToString();
                            iBRCH_NM = gridViewBrchInfo.GetRowCellValue(i, "BRCH_NM").ToString();
                            iBRCH_FG_CD = gridViewBrchInfo.GetRowCellValue(i, "BRCH_FG_CD").ToString();
                            iAREA_CD = gridViewBrchInfo.GetRowCellValue(i, "AREA_CD").ToString();
                            iZIP_NO = gridViewBrchInfo.GetRowCellValue(i, "ZIP_NO").ToString();
                            iADDR1 = gridViewBrchInfo.GetRowCellValue(i, "ADDR1").ToString();
                            iADDR2 = gridViewBrchInfo.GetRowCellValue(i, "ADDR2").ToString();
                            iPHON_NO = gridViewBrchInfo.GetRowCellValue(i, "PHON_NO").ToString();
                            iFAX_NO = gridViewBrchInfo.GetRowCellValue(i, "FAX_NO").ToString();
                            iBIZ_REG_NO = gridViewBrchInfo.GetRowCellValue(i, "BIZ_REG_NO").ToString();
                            iREPR_NM = gridViewBrchInfo.GetRowCellValue(i, "REPR_NM").ToString();

                            conn_DB_MYSQL_CONNECT_open();
                            try
                            {
                                // Insert Query
                                mySQL_BRCH_INFO_Insert(iBRCH_CD, iBRCH_NM, iBRCH_FG_CD, iAREA_CD, iZIP_NO, iADDR1, iADDR2, iPHON_NO, iFAX_NO, iBIZ_REG_NO, iREPR_NM);
                                //MessageBox.Show(query);
                                MySqlCommand command = new MySqlCommand(query, _DB_MYSQL_CONNECT);
                                command.ExecuteReader();

                                conn_DB_MYSQL_CONNECT_close();  // Connection Close     
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                        if (gridViewBrchInfo.GetRowCellValue(i, "CRUD").ToString() == "U")
                        {
                            iBRCH_CD = gridViewBrchInfo.GetRowCellValue(i, "BRCH_CD").ToString();
                            iBRCH_NM = gridViewBrchInfo.GetRowCellValue(i, "BRCH_NM").ToString();
                            iBRCH_FG_CD = gridViewBrchInfo.GetRowCellValue(i, "BRCH_FG_CD").ToString();
                            iAREA_CD = gridViewBrchInfo.GetRowCellValue(i, "AREA_CD").ToString();
                            iZIP_NO = gridViewBrchInfo.GetRowCellValue(i, "ZIP_NO").ToString();
                            iADDR1 = gridViewBrchInfo.GetRowCellValue(i, "ADDR1").ToString();
                            iADDR2 = gridViewBrchInfo.GetRowCellValue(i, "ADDR2").ToString();
                            iPHON_NO = gridViewBrchInfo.GetRowCellValue(i, "PHON_NO").ToString();
                            iFAX_NO = gridViewBrchInfo.GetRowCellValue(i, "FAX_NO").ToString();
                            iBIZ_REG_NO = gridViewBrchInfo.GetRowCellValue(i, "BIZ_REG_NO").ToString();
                            iREPR_NM = gridViewBrchInfo.GetRowCellValue(i, "REPR_NM").ToString();

                            //MessageBox.Show(gridViewCommCdDetail.GetRowCellValue(i, "COMM_CD").ToString() + " : " + gridViewCommCdDetail.GetRowCellValue(i, "CRUD").ToString());

                            conn_DB_MYSQL_CONNECT_open();
                            try
                            {
                                // Update Query
                                if(iADDR1 == "") iZIP_NO = "";
                                mySQL_BRCH_INFO_Update(iBRCH_CD, iBRCH_NM, iBRCH_FG_CD, iAREA_CD, iZIP_NO, iADDR1, iADDR2, iPHON_NO, iFAX_NO, iBIZ_REG_NO, iREPR_NM);

                                MySqlCommand command = new MySqlCommand(query, _DB_MYSQL_CONNECT);
                                command.ExecuteReader();

                                conn_DB_MYSQL_CONNECT_close();  // Connection Close     
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
                simpleButtonQuery_ClickQuery();

            }
        }

        private void gridViewBrchInfo_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gridViewBrchInfo.GetDataRow(e.RowHandle);
            row["CRUD"] = "I";
        }

        private void gridViewBrchInfo_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (gridViewBrchInfo.GetRowCellValue(gridViewBrchInfo.FocusedRowHandle, "CRUD").ToString().Trim() != "I")
                {
                    DataRow row = gridViewBrchInfo.GetDataRow(e.RowHandle);
                    row["CRUD"] = "U";
                }
            }
        }

        private void gridViewBrchInfo_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn varBRCH_CD = view.Columns["BRCH_CD"];
            GridColumn varBRCH_NM = view.Columns["BRCH_NM"];
            GridColumn varBRCH_FG_CD = view.Columns["BRCH_FG_CD"];
            GridColumn varAREA_CD = view.Columns["AREA_CD"];

            string iBRCH_CD = gridViewBrchInfo.GetRowCellValue(e.RowHandle, "BRCH_CD").ToString();
            string iBRCH_NM = gridViewBrchInfo.GetRowCellValue(e.RowHandle, "BRCH_NM").ToString();
            string iBRCH_FG_CD = gridViewBrchInfo.GetRowCellValue(e.RowHandle, "BRCH_FG_CD").ToString();
            string iAREA_CD = gridViewBrchInfo.GetRowCellValue(e.RowHandle, "AREA_CD").ToString();
            //MessageBox.Show(varCOMM_CD.View.FocusedValue.ToString());

            if (iBRCH_CD.ToString().Trim() == "" || iBRCH_CD.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varBRCH_CD, "[지사코드]는 필수 입력 값 입니다.");
            }
            if (iBRCH_NM.ToString().Trim() == "" || iBRCH_NM.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varBRCH_NM, "[지사명]는 필수 입력 값 입니다.");
            }
            if (iBRCH_FG_CD.ToString().Trim() == "" || iBRCH_FG_CD.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varBRCH_FG_CD, "[지사구분코드정보]는 필수 입력 값 입니다.");
            }
            if (iAREA_CD.ToString().Trim() == "" || iAREA_CD.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varAREA_CD, "[지역코드정보]는 필수 입력 값 입니다.");
            }
        }

        private void gridViewBrchInfo_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.FocusedColumn.FieldName == "BRCH_CD")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[지사코드]는 필수 입력 값 입니다.";
                }
            }
            if (view.FocusedColumn.FieldName == "BRCH_NM")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[지사명]은 필수 입력 값 입니다.";
                }
            }
            if (view.FocusedColumn.FieldName == "BRCH_FG_CD")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[지사구분코드정보]는 필수 입력 값 입니다.";
                }
            }
            if (view.FocusedColumn.FieldName == "AREA_CD")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[지역코드정보]는 필수 입력 값 입니다.";
                }
            }
        }

        // BRCH_INFO Select
        private void mySQL_BRCH_INFO_Select(string BRCH_FG_from, string BRCH_FG_to, string AREA_CD_from, string AREA_CD_to)
        {
            query =
                "SELECT BRCH_CD    " +
                "     , BRCH_NM    " +
                "     , BRCH_FG_CD " +
                "     , AREA_CD    " +
                "     , ZIP_NO     " +
                "     , CONCAT('[',ZIP_NO,'] ', ADDR1) AS ADDR1" +
                "     , ADDR2      " +
                "     , PHON_NO    " +
                "     , FAX_NO     " +
                "     , BIZ_REG_NO " +
                "     , REPR_NM    " +
                "     , REG_ID     " +
                "     , REG_DTTM   " +
                "     , UPDT_ID    " +
                "     , UPDT_DTTM  " +
                "  FROM BRCH_INFO  " +
                " WHERE BRCH_FG_CD BETWEEN '" + BRCH_FG_from + "' AND '" + BRCH_FG_to + "'" +
                "   AND AREA_CD    BETWEEN '" + AREA_CD_from + "' AND '" + AREA_CD_to + "'" +
                " ORDER BY BRCH_CD ";
        }

        // BRCH_INFO Insert
        private void mySQL_BRCH_INFO_Insert(string iBRCH_CD, string iBRCH_NM, string iBRCH_FG_CD, string iAREA_CD, string iZIP_NO, string iADDR1, string iADDR2, string iPHON_NO, string iFAX_NO, string iBIZ_REG_NO, string iREPR_NM)
        {
            query = "INSERT INTO BRCH_INFO (BRCH_CD, BRCH_NM, BRCH_FG_CD, AREA_CD, ZIP_NO, ADDR1, ADDR2, PHON_NO, FAX_NO, BIZ_REG_NO, REPR_NM, REG_ID, REG_DTTM, UPDT_ID, UPDT_DTTM) " +
                    "       VALUES ( " +
                    "               '" + iBRCH_CD + "', " +
                    "               '" + iBRCH_NM + "', " +
                    "               '" + iBRCH_FG_CD + "', " +
                    "               '" + iAREA_CD + "', " +
                    "               '" + iZIP_NO + "', " +
                    "               substr('" + iADDR1 + "', 8), " +
                    "               '" + iADDR2 + "', " +
                    "               '" + iPHON_NO + "', " +
                    "               '" + iFAX_NO + "', " +
                    "               '" + iBIZ_REG_NO + "', " +
                    "               '" + iREPR_NM + "', " +
                    "               '" + officeMainForm.main_LoginId + "', " +
                    "                    NOW(), " +
                    "               '" + officeMainForm.main_LoginId + "', " +
                    "                    NOW() " +
                    "       )";
        }

        // BRCH_INFO Update
        private void mySQL_BRCH_INFO_Update(string iBRCH_CD, string iBRCH_NM, string iBRCH_FG_CD, string iAREA_CD, string iZIP_NO, string iADDR1, string iADDR2, string iPHON_NO, string iFAX_NO, string iBIZ_REG_NO, string iREPR_NM)
        {
            query = "UPDATE BRCH_INFO " +
                    "   SET BRCH_NM = '" + iBRCH_NM + "' " +
                    "     , BRCH_FG_CD = '" + iBRCH_FG_CD + "' " +
                    "     , AREA_CD = '" + iAREA_CD + "' " +
                    "     , ZIP_NO = '" + iZIP_NO + "' " +
                    "     , ADDR1 = substr('" + iADDR1 + "', 8) " +
                    "     , ADDR2 = '" + iADDR2 + "' " +
                    "     , PHON_NO = '" + iPHON_NO + "' " +
                    "     , FAX_NO = '" + iFAX_NO + "' " +
                    "     , BIZ_REG_NO = '" + iBIZ_REG_NO + "' " +
                    "     , REPR_NM = '" + iREPR_NM + "' " +
                    "     , UPDT_ID    = '" + officeMainForm.main_LoginId + "' " +
                    "     , UPDT_DTTM  = NOW() " +
                    " WHERE BRCH_CD    = '" + iBRCH_CD + "' " +
                    "       ";
        }

        // BRCH_INFO Delete
        private void mySQL_BRCH_INFO_Delete(string iBRCH_CD)
        {
            query = "DELETE FROM BRCH_INFO " +
                    " WHERE BRCH_CD = '" + iBRCH_CD + "' " +
                    "       ";
        }

        private void CB_Qurey()
        {
            MySqlConnection conn = new MySqlConnection(officeMainForm.mySQL_ConnString);

            string sql = null;
            MySqlDataReader R_Login = null;

            //ComboBoxBRCH_FG 데이터 가져오기
            ComboBoxBRCH_FG.Properties.Items.Add("전체", "A", -1);
            try
            {
                sql = "SELECT COMM_CD, COMM_CD_NM FROM COM_CODE WHERE GRP_CD = 'BRCH_FG' ORDER BY ORD_SEQ ";

                conn.Open();   // Connection Open

                //MySqlDataReader 는 Record 단위로 접근하며, 하나의 Reader 가 열려 있으면 또다른 Reader 를 열 수 없다.
                // Login 정보 가져오기
                R_Login = new MySqlCommand(sql, conn).ExecuteReader();

                // Main Logic
                while (R_Login.Read())  // 칼럼은 배열처럼 사용하며, R[0]은 첫번째 컬럼, R[1]은 두번째 컬럼...
                {
                    ComboBoxBRCH_FG.Properties.Items.Add(R_Login["COMM_CD_NM"].ToString(), R_Login["COMM_CD"].ToString(), -1);
                }
                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close    
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }

            //ComboBoxAREA_CD 데이터 가져오기
            ComboBoxAREA_CD.Properties.Items.Add("전체", "A", -1);
            try
            {
                sql = "SELECT COMM_CD, COMM_CD_NM FROM COM_CODE WHERE GRP_CD = 'AREA_CD' ORDER BY ORD_SEQ ";

                conn.Open();   // Connection Open

                //MySqlDataReader 는 Record 단위로 접근하며, 하나의 Reader 가 열려 있으면 또다른 Reader 를 열 수 없다.
                // Login 정보 가져오기
                R_Login = new MySqlCommand(sql, conn).ExecuteReader();

                // Main Logic
                while (R_Login.Read())  // 칼럼은 배열처럼 사용하며, R[0]은 첫번째 컬럼, R[1]은 두번째 컬럼...
                {
                    ComboBoxAREA_CD.Properties.Items.Add(R_Login["COMM_CD_NM"].ToString(), R_Login["COMM_CD"].ToString(), -1);
                }
                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close    
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }
        }

        private void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

            ButtonEdit editor = (ButtonEdit)sender;
            editor.EditValue = "[" + zipCd + "] " + roadAddr1;

            //EditFormContainer EFC = new EditFormContainer(DevExpress.XtraGrid.EditForm.Helpers.Controls.EditFormContainer DevExpress.XtraEditors.re);
            
            //PanelControl PC = editor.Parent as PanelControl;


            //PanelControl PC = editor.Properties.OwnerEdit.Controls as PanelControl;
            //MessageBox.Show("BrchInfo ===== " + zipCd + " : " + roadAddr1 + " : " + dongAddr1);

            gridViewBrchInfo.SetRowCellValue(gridViewBrchInfo.FocusedRowHandle, "ZIP_NO", zipCd);
            //gridViewBrchInfo.SetRowCellValue(gridViewBrchInfo.FocusedRowHandle, "ADDR1", "[" + zipCd + "]" + roadAddr1);
        }

    }
}
