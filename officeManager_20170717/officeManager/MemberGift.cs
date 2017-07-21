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
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace officeManager
{
    public partial class MemberGiftForm : DevExpress.XtraEditors.XtraForm
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

        public MemberGiftForm()
        {
            InitializeComponent();

            // 콤포박스 데이터 가져오기
            CB_Qurey();

            String GIFT_FG_from = null;
            String GIFT_FG_to = null;

            // 선물구분코드
            ComboBoxGIFT_FG.Value = "A";

            GIFT_FG_from = "00";
            GIFT_FG_to = "99";

            adminBrchRegForm_GIFT_INFO_Qury(GIFT_FG_from, GIFT_FG_to);
        }

        // GIFT_INFO Data Query
        public void adminBrchRegForm_GIFT_INFO_Qury(string GIFT_FG_from, string GIFT_FG_to)
        {
            conn_DB_MYSQL_CONNECT_open();

            try
            {
                DataTable table = new DataTable();

                for (int i = 0; i < gridView1.Columns.Count; i++)
                {
                    DevExpress.XtraGrid.Columns.GridColumn column = gridView1.Columns[i];
                    if (column.FieldName == "GIFT_PRC" || column.FieldName == "STOCK_AMT")
                    {
                        table.Columns.Add(column.FieldName, typeof(decimal));
                    }
                    else
                    {
                        table.Columns.Add(column.FieldName, typeof(string));
                    }
                }

                // Select Query
                mySQL_GIFT_INFO_Select(GIFT_FG_from, GIFT_FG_to);

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
            String GIFT_FG_from = null;
            String GIFT_FG_to = null;

            if (ComboBoxGIFT_FG.Value == "A")
            {
                GIFT_FG_from = "00";
                GIFT_FG_to = "99";
            }
            else
            {
                GIFT_FG_from = ComboBoxGIFT_FG.Value.ToString();
                GIFT_FG_to = ComboBoxGIFT_FG.Value.ToString();
            }

            adminBrchRegForm_GIFT_INFO_Qury(GIFT_FG_from, GIFT_FG_to);
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
                        string iGIFT_CD = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIFT_CD").ToString();
                        mySQL_GIFT_INFO_Delete(iGIFT_CD);

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
                string iGIFT_CD = null;
                string iGIFT_NM = null;
                string iGIFT_PRC = null;
                string iSTOCK_AMT = null;
                string iGIFT_FG = null;
                string iUSE_STR_DT = null;
                string iUSE_END_DT = null;

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, "CRUD").ToString() == "I")
                    {
                        iGIFT_CD = gridView1.GetRowCellValue(i, "GIFT_CD").ToString();
                        iGIFT_NM = gridView1.GetRowCellValue(i, "GIFT_NM").ToString();
                        iGIFT_PRC = gridView1.GetRowCellValue(i, "GIFT_PRC").ToString();
                        iSTOCK_AMT = gridView1.GetRowCellValue(i, "STOCK_AMT").ToString();
                        iGIFT_FG = gridView1.GetRowCellValue(i, "GIFT_FG").ToString();
                        iUSE_STR_DT = gridView1.GetRowCellValue(i, "USE_STR_DT").ToString();
                        iUSE_END_DT = gridView1.GetRowCellValue(i, "USE_END_DT").ToString();

                        conn_DB_MYSQL_CONNECT_open();
                        try
                        {
                            // Insert Query
                            mySQL_GIFT_INFO_Insert(iGIFT_CD, iGIFT_NM, iGIFT_PRC, iSTOCK_AMT, iGIFT_FG, iUSE_STR_DT, iUSE_END_DT);

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
                        iGIFT_CD = gridView1.GetRowCellValue(i, "GIFT_CD").ToString();
                        iGIFT_NM = gridView1.GetRowCellValue(i, "GIFT_NM").ToString();
                        iGIFT_PRC = gridView1.GetRowCellValue(i, "GIFT_PRC").ToString();
                        iSTOCK_AMT = gridView1.GetRowCellValue(i, "STOCK_AMT").ToString();
                        iGIFT_FG = gridView1.GetRowCellValue(i, "GIFT_FG").ToString();
                        iUSE_STR_DT = gridView1.GetRowCellValue(i, "USE_STR_DT").ToString();
                        iUSE_END_DT = gridView1.GetRowCellValue(i, "USE_END_DT").ToString();

                        conn_DB_MYSQL_CONNECT_open();
                        try
                        {
                            // Update Query
                            mySQL_GIFT_INFO_Update(iGIFT_CD, iGIFT_NM, iGIFT_PRC, iSTOCK_AMT, iGIFT_FG, iUSE_STR_DT, iUSE_END_DT);

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
            row["GIFT_PRC"] = 0;
            row["STOCK_AMT"] = 0;
            row["USE_STR_DT"] = "0001-01-01";
            row["USE_END_DT"] = "9999-12-31";
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
            GridColumn varGIFT_CD = view.Columns["GIFT_CD"];
            GridColumn varGIFT_NM = view.Columns["GIFT_NM"];
            GridColumn varGIFT_PRC = view.Columns["GIFT_PRC"];
            GridColumn varSTOCK_AMT = view.Columns["STOCK_AMT"];
            GridColumn varGIFT_FG = view.Columns["GIFT_FG"];
            GridColumn varUSE_STR_DT = view.Columns["USE_STR_DT"];
            GridColumn varUSE_END_DT = view.Columns["USE_END_DT"];

            string iGIFT_CD = gridView1.GetRowCellValue(e.RowHandle, "GIFT_CD").ToString();
            string iGIFT_NM = gridView1.GetRowCellValue(e.RowHandle, "GIFT_NM").ToString();
            string iGIFT_PRC = gridView1.GetRowCellValue(e.RowHandle, "GIFT_PRC").ToString();
            string iSTOCK_AMT = gridView1.GetRowCellValue(e.RowHandle, "STOCK_AMT").ToString();
            string iGIFT_FG = gridView1.GetRowCellValue(e.RowHandle, "GIFT_FG").ToString();
            string iUSE_STR_DT = gridView1.GetRowCellValue(e.RowHandle, "USE_STR_DT").ToString();
            string iUSE_END_DT = gridView1.GetRowCellValue(e.RowHandle, "USE_END_DT").ToString();
            
            if (iGIFT_NM.ToString().Trim() == "" || iGIFT_NM.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varGIFT_NM, "[사은품명]는 필수 입력 값 입니다.");
            }
            if (iGIFT_PRC.ToString().Trim() == "" || iGIFT_PRC.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varGIFT_PRC, "[사은품가격]는 필수 입력 값 입니다.");
            }
            if (iSTOCK_AMT.ToString().Trim() == "" || iSTOCK_AMT.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varSTOCK_AMT, "[입고가격]는 필수 입력 값 입니다.");
            }
            if (iGIFT_FG.ToString().Trim() == "" || iGIFT_FG.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varGIFT_FG, "[사은품구분]는 필수 입력 값 입니다.");
            }
            if (iUSE_STR_DT.ToString().Trim() == "" || iUSE_STR_DT.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varUSE_STR_DT, "[사용시작일자]는 필수 입력 값 입니다.");
            }
            if (iUSE_END_DT.ToString().Trim() == "" || iUSE_END_DT.ToString().Trim() == null)
            {
                e.Valid = false;
                view.SetColumnError(varUSE_END_DT, "[사용종료일자]는 필수 입력 값 입니다.");
            }
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.FocusedColumn.FieldName == "GIFT_NM")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[사은품명]는 필수 입력 값 입니다.";
                }
            }
            if (view.FocusedColumn.FieldName == "GIFT_PRC")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[사은품가격]는 필수 입력 값 입니다.";
                }
            }
            if (view.FocusedColumn.FieldName == "STOCK_AMT")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[입고가격]는 필수 입력 값 입니다.";
                }
            }
            if (view.FocusedColumn.FieldName == "GIFT_FG")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[사은품구분]는 필수 입력 값 입니다.";
                }
            }
            if (view.FocusedColumn.FieldName == "USE_STR_DT")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[사용시작일자]는 필수 입력 값 입니다.";
                }
            }
            if (view.FocusedColumn.FieldName == "USE_END_DT")
            {
                if (e.Value.ToString().Trim() == "" || e.Value.ToString().Trim() == null)
                {
                    e.Valid = false;
                    e.ErrorText = "[사용종료일자]는 필수 입력 값 입니다.";
                }
            }
        }

        // GIFT_INFO Select
        private void mySQL_GIFT_INFO_Select(string GIFT_FG_from, string GIFT_FG_to)
        {
            query =
                "SELECT BRCH_CD    " +
                "     , GIFT_CD    " +
                "     , GIFT_NM    " +
                "     , GIFT_PRC   " +
                "     , STOCK_AMT  " +
                "     , GIFT_FG    " +
                "     , date_format(USE_STR_DT, '%Y-%m-%d') AS USE_STR_DT " +
                "     , date_format(USE_END_DT, '%Y-%m-%d') AS USE_END_DT " +
                "  FROM GIFT_INFO  " +
                " WHERE BRCH_CD = '" + officeMainForm.main_BrchCd + "'" +
                "   AND GIFT_FG BETWEEN '" + GIFT_FG_from + "' AND '" + GIFT_FG_to + "'" +
                " ORDER BY GIFT_CD ";
        }

        // GIFT_INFO Insert
        private void mySQL_GIFT_INFO_Insert(string iGIFT_CD, string iGIFT_NM, string iGIFT_PRC, string iSTOCK_AMT, string iGIFT_FG, string iUSE_STR_DT, string iUSE_END_DT)
        {
            query = "INSERT INTO GIFT_INFO (BRCH_CD, GIFT_CD, GIFT_NM, GIFT_PRC, STOCK_AMT, GIFT_FG, USE_STR_DT, USE_END_DT, REG_ID, REG_DTTM, UPDT_ID, UPDT_DTTM) " +
                    "       VALUES ( " +
                    "               '" + officeMainForm.main_BrchCd + "', " +
                    "               (SELECT LPAD(MAX(A.GIFT_CD)+1,2,'0') FROM GIFT_INFO A WHERE A.BRCH_CD = '" + officeMainForm.main_BrchCd + "'), " +
                    "               '" + iGIFT_NM + "', " +
                    "               '" + iGIFT_PRC + "', " +
                    "               '" + iSTOCK_AMT + "', " +
                    "               '" + iGIFT_FG + "', " +
                    "               '" + iUSE_STR_DT + "', " +
                    "               '" + iUSE_END_DT + "', " +
                    "               '" + officeMainForm.main_LoginId + "', " +
                    "                    NOW(), " +
                    "               '" + officeMainForm.main_LoginId + "', " +
                    "                    NOW() " +
                    "       )";
        }

        // GIFT_INFO Update
        private void mySQL_GIFT_INFO_Update(string iGIFT_CD, string iGIFT_NM, string iGIFT_PRC, string iSTOCK_AMT, string iGIFT_FG, string iUSE_STR_DT, string iUSE_END_DT)
        {
            query = "UPDATE GIFT_INFO " +
                    "   SET GIFT_NM    = '" + iGIFT_NM + "' " +
                    "     , GIFT_PRC   = '" + iGIFT_PRC + "' " +
                    "     , STOCK_AMT  = '" + iSTOCK_AMT + "' " +
                    "     , GIFT_FG    = '" + iGIFT_FG + "' " +
                    "     , USE_STR_DT = '" + iUSE_STR_DT + "' " +
                    "     , USE_END_DT = '" + iUSE_END_DT + "' " +
                    "     , UPDT_ID    = '" + officeMainForm.main_LoginId + "' " +
                    "     , UPDT_DTTM  = NOW() " +
                    " WHERE BRCH_CD    = '" + officeMainForm.main_BrchCd + "' " +
                    "   AND GIFT_CD = '" + iGIFT_CD + "' " +
                    "       ";
        }

        // GIFT_INFO Delete
        private void mySQL_GIFT_INFO_Delete(string iGIFT_CD)
        {
            query = "DELETE FROM GIFT_INFO " +
                    " WHERE BRCH_CD = '" + officeMainForm.main_BrchCd + "'" +
                    "   AND GIFT_CD = '" + iGIFT_CD + "' " +
                    "       ";
        }

        private void CB_Qurey()
        {
            MySqlConnection conn = new MySqlConnection(officeMainForm.mySQL_ConnString);

            string sql = null;
            MySqlDataReader R_Login = null;

            //ComboBoxGIFT_FG 데이터 가져오기
            ComboBoxGIFT_FG.Properties.Items.Add("전체", "A", -1);
            try
            {
                sql = "SELECT COMM_CD, COMM_CD_NM FROM COM_CODE WHERE GRP_CD = 'GIFT_FG' ORDER BY ORD_SEQ ";

                conn.Open();   // Connection Open

                //MySqlDataReader 는 Record 단위로 접근하며, 하나의 Reader 가 열려 있으면 또다른 Reader 를 열 수 없다.
                // Login 정보 가져오기
                R_Login = new MySqlCommand(sql, conn).ExecuteReader();

                // Main Logic
                while (R_Login.Read())  // 칼럼은 배열처럼 사용하며, R[0]은 첫번째 컬럼, R[1]은 두번째 컬럼...
                {
                    ComboBoxGIFT_FG.Properties.Items.Add(R_Login["COMM_CD_NM"].ToString(), R_Login["COMM_CD"].ToString(), -1);
                }
                R_Login.Close();   // 쿼리문 결과 닫기, Reader 로 열었으면 반드시 닫아야 한다.
                conn.Close();  // Connection Close    
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }
        }
    }
}