﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using MySql.Data.MySqlClient;

namespace officeManager
{
    public partial class postPopupForm : DevExpress.XtraEditors.XtraForm
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

        public postPopupForm()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            //sqlDataSource1.Fill();
        }

        private void simpleButtonQuery_Click(object sender, EventArgs e)
        {
            if (textEditAddr.Text.Trim() == null || textEditAddr.Text.Trim() == "" || textEditAddr.Text.Trim() == " ")
            {
                MessageBox.Show("조회하고자 하는 지명 또는 건물을 입력하시기 바랍니다.");
                textEditAddr.Focus();
                return;
            }

            conn_DB_MYSQL_CONNECT_open();

            try
            {
                DataTable table = new DataTable();

                for (int i = 0; i < gridViewAddrSearch.Columns.Count; i++)
                {
                    DevExpress.XtraGrid.Columns.GridColumn column = gridViewAddrSearch.Columns[i];
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
                query =
                    "SELECT ZIP_CD             " +
                    "     , SIDO               " +
                    "     , SIGUNGU            " +
                    "     , ROAD_NAME          " +
                    "     , BUILD_BON_NO       " +
                    "     , BUILD_BU_NO        " +
                    "     , SIGUNGU_BUILD_NAME " +
                    "     , HANG_DONG_NAME     " +
                    "     , DONG_NAME          " +
                    "     , RI_NAME            " +
                    "     , JIBUN_BONBUN       " +
                    "     , JIBUN_BUBUN        " +
                    "  FROM ZIP_MST            " +
                    " WHERE ROAD_NAME          LIKE '" + textEditAddr.Text.Trim().ToString() + "%'" +
                    "    OR HANG_DONG_NAME     LIKE '" + textEditAddr.Text.Trim().ToString() + "%'" +
                    "    OR DONG_NAME          LIKE '" + textEditAddr.Text.Trim().ToString() + "%'" +
                    "    OR RI_NAME            LIKE '" + textEditAddr.Text.Trim().ToString() + "%'" +
                    "    OR SIGUNGU_BUILD_NAME LIKE '" + textEditAddr.Text.Trim().ToString() + "%'" +
                    " ORDER BY ROAD_NAME, BUILD_BON_NO, BUILD_BU_NO ";

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

                gridControlAddrSearch.DataSource = table;
                //gridViewCommCdMaster.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textEditAddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                simpleButtonQuery_Click(sender, e);
            }
        }

        private void gridControlAddrSearch_DoubleClick(object sender, EventArgs e)
        {
            String zipCd = "";
            String roadAddr1 = "";
            String dongAddr1 = "";

            MouseEventArgs ea = e as MouseEventArgs;
            if (ea == null) return;
            GridHitInfo hi = gridViewAddrSearch.CalcHitInfo(ea.Location);
            int datasourceRowIndex = gridViewAddrSearch.GetDataSourceRowIndex(hi.RowHandle);

            int rowHandle = gridViewAddrSearch.GetRowHandle(datasourceRowIndex);

            //gridViewCommCdMaster.AddNewRow();
            //MessageBox.Show(rowHandle.ToString());
            if (rowHandle >= 0)
            {
                zipCd = gridViewAddrSearch.GetRowCellValue(rowHandle, "ZIP_CD").ToString();
                roadAddr1 = gridViewAddrSearch.GetRowCellValue(rowHandle, "SIDO").ToString() + " " +
                            gridViewAddrSearch.GetRowCellValue(rowHandle, "SIGUNGU").ToString() + " " +
                            gridViewAddrSearch.GetRowCellValue(rowHandle, "ROAD_NAME").ToString() + " " +
                            gridViewAddrSearch.GetRowCellValue(rowHandle, "BUILD_BON_NO").ToString() + "-" +
                            gridViewAddrSearch.GetRowCellValue(rowHandle, "BUILD_BU_NO").ToString();
                dongAddr1 = gridViewAddrSearch.GetRowCellValue(rowHandle, "SIDO").ToString() + " " +
                            gridViewAddrSearch.GetRowCellValue(rowHandle, "SIGUNGU").ToString() + " " +
                            gridViewAddrSearch.GetRowCellValue(rowHandle, "DONG_NAME").ToString() + " " +
                            gridViewAddrSearch.GetRowCellValue(rowHandle, "JIBUN_BONBUN").ToString() + "-" +
                            gridViewAddrSearch.GetRowCellValue(rowHandle, "JIBUN_BUBUN").ToString();

                //MessageBox.Show("postPopup ===== " + zipCd + " : " + roadAddr1 + " : " + dongAddr1);

                officeMainForm.main_ZipCd = zipCd;
                officeMainForm.main_RoadAddr1 = roadAddr1;
                officeMainForm.main_DongAddr1 = dongAddr1;

                this.Close();

                //Dispose();
            }
        }
    }
}