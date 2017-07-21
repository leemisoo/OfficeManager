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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraBars.Docking2010;

namespace officeManager
{
    public partial class MemberSalesForm : DevExpress.XtraEditors.XtraForm
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

        public MemberSalesForm()
        {
            InitializeComponent();

            labelControl1.Text = "[" + officeMainForm.main_BrchCd + "] " + officeMainForm.main_BrchNm;

            MemberSalesForm_Qury();
        }

        public void MemberSalesForm_Qury()
        {
            conn_DB_MYSQL_CONNECT_open();

            try
            {
                DataTable table = new DataTable();

                for (int i = 0; i < gridView1.Columns.Count; i++)
                {
                    DevExpress.XtraGrid.Columns.GridColumn column = gridView1.Columns[i];
                    if (column.FieldName == "_")
                    {
                        table.Columns.Add(column.FieldName, typeof(decimal));
                    }
                    else
                    {
                        table.Columns.Add(column.FieldName, typeof(string));
                    }
                }

                // Select Query
                mySQL_SALES_PSN_INFO_Select();

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

                gridControl1.DataSource = table;
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
            MemberSalesForm_Qury();
        }

        private void groupControl1_CustomButtonClick(object sender, BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "행추가")
            {
                gridView1.AddNewRow();
            }

            if (e.Button.Properties.Caption == "행삭제")
            {
                if (MessageBox.Show("삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn_DB_MYSQL_CONNECT_open();
                    try
                    {
                        // Delete Query
                        string iSALES_PSN_NO = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SALES_PSN_NO").ToString();
                        mySQL_SALES_PSN_INFO_Delete(iSALES_PSN_NO);

                        MySqlCommand command = new MySqlCommand(query, _DB_MYSQL_CONNECT);
                        command.ExecuteReader();

                        conn_DB_MYSQL_CONNECT_close();  // Connection Close     
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    gridView1.DeleteSelectedRows();
                }
            }

            if (e.Button.Properties.Caption == "저장")
            {
                string iSALES_PSN_NO = null;
                string iSALES_PSN_NM = null;
                string iSALES_DEPT_NM = null;
                string iENTCMPY_DT = null;
                string iCELL_PHON_NO = null;
                string iWRK_STS_CD = null;
                string iRR_NO = null;
                string iZIP_NO = null;
                string iADDR1 = null;
                string iADDR2 = null;

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, "CRUD").ToString() == "I")
                    {
                        iSALES_PSN_NO = gridView1.GetRowCellValue(i, "SALES_PSN_NO").ToString();
                        iSALES_PSN_NM = gridView1.GetRowCellValue(i, "SALES_PSN_NM").ToString();
                        iSALES_DEPT_NM = gridView1.GetRowCellValue(i, "SALES_DEPT_NM").ToString();
                        iENTCMPY_DT = gridView1.GetRowCellValue(i, "ENTCMPY_DT").ToString();
                        iCELL_PHON_NO = gridView1.GetRowCellValue(i, "CELL_PHON_NO").ToString();
                        iWRK_STS_CD = gridView1.GetRowCellValue(i, "WRK_STS_CD").ToString();
                        iRR_NO = gridView1.GetRowCellValue(i, "RR_NO").ToString();
                        iZIP_NO = gridView1.GetRowCellValue(i, "ZIP_NO").ToString();
                        iADDR1 = gridView1.GetRowCellValue(i, "ADDR1").ToString();
                        iADDR2 = gridView1.GetRowCellValue(i, "ADDR2").ToString();

                        conn_DB_MYSQL_CONNECT_open();
                        try
                        {
                            // Insert Query
                            mySQL_SALES_PSN_INFO_Insert(iSALES_PSN_NO, iSALES_PSN_NM, iSALES_DEPT_NM, iENTCMPY_DT, iCELL_PHON_NO, iWRK_STS_CD, iRR_NO, iZIP_NO, iADDR1, iADDR2);

                            MySqlCommand command = new MySqlCommand(query, _DB_MYSQL_CONNECT);
                            command.ExecuteReader();

                            conn_DB_MYSQL_CONNECT_close();  // Connection Close     
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                    if (gridView1.GetRowCellValue(i, "CRUD").ToString() == "U")
                    {
                        iSALES_PSN_NO = gridView1.GetRowCellValue(i, "SALES_PSN_NO").ToString();
                        iSALES_PSN_NM = gridView1.GetRowCellValue(i, "SALES_PSN_NM").ToString();
                        iSALES_DEPT_NM = gridView1.GetRowCellValue(i, "SALES_DEPT_NM").ToString();
                        iENTCMPY_DT = gridView1.GetRowCellValue(i, "ENTCMPY_DT").ToString();
                        iCELL_PHON_NO = gridView1.GetRowCellValue(i, "CELL_PHON_NO").ToString();
                        iWRK_STS_CD = gridView1.GetRowCellValue(i, "WRK_STS_CD").ToString();
                        iRR_NO = gridView1.GetRowCellValue(i, "RR_NO").ToString();
                        iZIP_NO = gridView1.GetRowCellValue(i, "ZIP_NO").ToString();
                        iADDR1 = gridView1.GetRowCellValue(i, "ADDR1").ToString();
                        iADDR2 = gridView1.GetRowCellValue(i, "ADDR2").ToString();

                        conn_DB_MYSQL_CONNECT_open();
                        try
                        {
                            // Update Query
                            mySQL_SALES_PSN_INFO_Update(iSALES_PSN_NO, iSALES_PSN_NM, iSALES_DEPT_NM, iENTCMPY_DT, iCELL_PHON_NO, iWRK_STS_CD, iRR_NO, iZIP_NO, iADDR1, iADDR2);

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
                simpleButtonQuery_ClickQuery();
            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(e.RowHandle);
            row["CRUD"] = "I";
            row["WRK_STS_CD"] = "01";
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CRUD").ToString().Trim() != "I")
                {
                    DataRow row = gridView1.GetDataRow(e.RowHandle);
                    row["CRUD"] = "U";
                }
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn varSALES_PSN_NO = view.Columns["SALES_PSN_NO"];
            GridColumn varSALES_PSN_NM = view.Columns["SALES_PSN_NM"];
            GridColumn varSALES_DEPT_NM = view.Columns["SALES_DEPT_NM"];
            GridColumn varENTCMPY_DT = view.Columns["ENTCMPY_DT"];
            GridColumn varCELL_PHON_NO = view.Columns["CELL_PHON_NO"];
            GridColumn varWRK_STS_CD = view.Columns["WRK_STS_CD"];
            GridColumn varRR_NO = view.Columns["RR_NO"];
            GridColumn varZIP_NO = view.Columns["ZIP_NO"];
            GridColumn varADDR1 = view.Columns["ADDR1"];
            GridColumn varADDR2 = view.Columns["ADDR2"];

            string iSALES_PSN_NO = gridView1.GetRowCellValue(e.RowHandle, "SALES_PSN_NO").ToString();
            string iSALES_PSN_NM = gridView1.GetRowCellValue(e.RowHandle, "SALES_PSN_NM").ToString();
            string iSALES_DEPT_NM = gridView1.GetRowCellValue(e.RowHandle, "SALES_DEPT_NM").ToString();
            string iENTCMPY_DT = gridView1.GetRowCellValue(e.RowHandle, "ENTCMPY_DT").ToString();
            string iCELL_PHON_NO = gridView1.GetRowCellValue(e.RowHandle, "CELL_PHON_NO").ToString();
            string iWRK_STS_CD = gridView1.GetRowCellValue(e.RowHandle, "WRK_STS_CD").ToString();
            string iRR_NO = gridView1.GetRowCellValue(e.RowHandle, "RR_NO").ToString();
            string iZIP_NO = gridView1.GetRowCellValue(e.RowHandle, "ZIP_NO").ToString();
            string iADDR1 = gridView1.GetRowCellValue(e.RowHandle, "ADDR1").ToString();
            string iADDR2 = gridView1.GetRowCellValue(e.RowHandle, "ADDR2").ToString();

            if (iSALES_PSN_NM.ToString().Trim() == "" || iSALES_PSN_NM.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varSALES_PSN_NM, "[영업자명]는 필수 입력 값 입니다.");
            }
            if (iSALES_DEPT_NM.ToString().Trim() == "" || iSALES_DEPT_NM.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varSALES_DEPT_NM, "[영업부서명]는 필수 입력 값 입니다.");
            }
            if (iENTCMPY_DT.ToString().Trim() == "" || iENTCMPY_DT.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varENTCMPY_DT, "[입사일자]는 필수 입력 값 입니다.");
            }
            if (iCELL_PHON_NO.ToString().Trim() == "" || iCELL_PHON_NO.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varCELL_PHON_NO, "[핸드폰번호]는 필수 입력 값 입니다.");
            }
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.FocusedColumn.FieldName == "SALES_PSN_NM")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[영업자명]는 필수 입력 값 입니다.";
                }
            }
            if (view.FocusedColumn.FieldName == "SALES_DEPT_NM")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[영업부서명]는 필수 입력 값 입니다.";
                }
            }
            if (view.FocusedColumn.FieldName == "ENTCMPY_DT")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[입자일자]는 필수 입력 값 입니다.";
                }
            }
            if (view.FocusedColumn.FieldName == "CELL_PHON_NO")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[핸드폰번호]는 필수 입력 값 입니다.";
                }
            }
        }

        // SALES_PSN_INFO Select
        private void mySQL_SALES_PSN_INFO_Select()
        {
            query =
                "SELECT BRCH_CD        " +
                "     , SALES_PSN_NO   " +
                "     , SALES_PSN_NM   " +
                "     , SALES_DEPT_NM  " +
                "     , date_format(ENTCMPY_DT, '%Y-%m-%d') AS ENTCMPY_DT " +
                "     , CELL_PHON_NO   " +
                "     , WRK_STS_CD     " +
                "     , CAST(AES_DECRYPT(UNHEX(RR_NO), 'DLXOTN') AS CHAR) AS RR_NO " +
                "     , ZIP_NO         " +
                "     , CONCAT('[',ZIP_NO,'] ', ADDR1) AS ADDR1" +
                "     , ADDR2          " +
                "  FROM SALES_PSN_INFO " +
                " WHERE BRCH_CD     = '" + officeMainForm.main_BrchCd + "'" +
                " ORDER BY SALES_PSN_NO ";

             // SET RR_NO = HEX(AES_ENCRYPT(:ls_rr_no, 'DLXOTN'))
        }

        // SALES_PSN_INFO Insert
        private void mySQL_SALES_PSN_INFO_Insert(string iSALES_PSN_NO, string iSALES_PSN_NM, string iSALES_DEPT_NM, string iENTCMPY_DT, string iCELL_PHON_NO, string iWRK_STS_CD, string iRR_NO, string iZIP_NO, string iADDR1, string iADDR2)
        {
            query = "INSERT INTO SALES_PSN_INFO (BRCH_CD, SALES_PSN_NO, SALES_PSN_NM, SALES_DEPT_NM, ENTCMPY_DT, CELL_PHON_NO, WRK_STS_CD, RR_NO, ZIP_NO, ADDR1, ADDR2, REG_ID, REG_DTTM, UPDT_ID, UPDT_DTTM) " +
                    "       VALUES ( " +
                    "               '" + officeMainForm.main_BrchCd + "', " +
                    "               (SELECT LPAD(MAX(A.SALES_PSN_NO)+1,7,'0') FROM SALES_PSN_INFO A WHERE A.SALES_PSN_NO LIKE '0%'), " +
                    "               '" + iSALES_PSN_NM + "', " +
                    "               '" + iSALES_DEPT_NM + "', " +
                    "               '" + iENTCMPY_DT + "', " +
                    "               '" + iCELL_PHON_NO + "', " +
                    "               '" + iWRK_STS_CD + "', " +
                    "               HEX(AES_ENCRYPT('" + iRR_NO + "', 'DLXOTN')), " +
                    "               '" + iZIP_NO + "', " +
                    "               substr('" + iADDR1 + "', 9), " +
                    "               '" + iADDR2 + "', " +
                    "               '" + officeMainForm.main_LoginId + "', " +
                    "                    NOW(), " +
                    "               '" + officeMainForm.main_LoginId + "', " +
                    "                    NOW() " +
                    "       )";
        }

        // SALES_PSN_INFO Update
        private void mySQL_SALES_PSN_INFO_Update(string iSALES_PSN_NO, string iSALES_PSN_NM, string iSALES_DEPT_NM, string iENTCMPY_DT, string iCELL_PHON_NO, string iWRK_STS_CD, string iRR_NO, string iZIP_NO, string iADDR1, string iADDR2)
        {
            query = "UPDATE SALES_PSN_INFO " +
                    "   SET SALES_PSN_NM   = '" + iSALES_PSN_NM + "' " +
                    "     , SALES_DEPT_NM  = '" + iSALES_DEPT_NM + "' " +
                    "     , ENTCMPY_DT     = '" + iENTCMPY_DT + "' " +
                    "     , CELL_PHON_NO   = '" + iCELL_PHON_NO + "' " +
                    "     , WRK_STS_CD     = '" + iWRK_STS_CD + "' " +
                    "     , RR_NO          = HEX(AES_ENCRYPT('" + iRR_NO + "', 'DLXOTN')) " +
                    "     , ZIP_NO         = '" + iZIP_NO + "' " +
                    "     , ADDR1          = substr('" + iADDR1 + "', 9) " +
                    "     , ADDR2          = '" + iADDR2 + "' " +
                    "     , UPDT_ID        = '" + officeMainForm.main_LoginId + "' " +
                    "     , UPDT_DTTM      = NOW() " +
                    " WHERE BRCH_CD        = '" + officeMainForm.main_BrchCd + "' " +
                    "   AND SALES_PSN_NO   = '" + iSALES_PSN_NO + "' " +
                    "       ";
        }

        // SALES_PSN_INFO Delete
        private void mySQL_SALES_PSN_INFO_Delete(string iSALES_PSN_NO)
        {
            query = "DELETE FROM SALES_PSN_INFO " +
                    " WHERE BRCH_CD      = '" + officeMainForm.main_BrchCd + "'" +
                    "   AND SALES_PSN_NO = '" + iSALES_PSN_NO + "' " +
                    "       ";
        }

        private void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            String zipCd = "";
            String roadAddr1 = "";
            String dongAddr1 = "";

            postPopupForm postPopup = new postPopupForm();

            postPopup.ShowDialog(this);

            zipCd = officeMainForm.main_ZipCd;
            roadAddr1 = officeMainForm.main_RoadAddr1;
            dongAddr1 = officeMainForm.main_DongAddr1;

            ButtonEdit editor = (ButtonEdit)sender;
            editor.EditValue = "[" + zipCd + "] " + roadAddr1;

            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ZIP_NO", zipCd);
        }
    }
}