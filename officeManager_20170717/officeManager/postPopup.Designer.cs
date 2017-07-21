namespace officeManager
{
    partial class postPopupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(postPopupForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEditAddr = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlAddrSearch = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewAddrSearch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colZIP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIGUNGU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROAD_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBUILD_BON_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBUILD_BU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIGUNGU_BUILD_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHANG_DONG_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONG_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJIBUN_BONBUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJIBUN_BUBUN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAddrSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAddrSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textEditAddr);
            this.panelControl1.Controls.Add(this.simpleButtonQuery);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(984, 37);
            this.panelControl1.TabIndex = 20;
            // 
            // textEditAddr
            // 
            this.textEditAddr.Location = new System.Drawing.Point(87, 9);
            this.textEditAddr.Name = "textEditAddr";
            this.textEditAddr.Size = new System.Drawing.Size(210, 20);
            this.textEditAddr.TabIndex = 1;
            this.textEditAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditAddr_KeyPress);
            // 
            // simpleButtonQuery
            // 
            this.simpleButtonQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonQuery.Location = new System.Drawing.Point(917, 2);
            this.simpleButtonQuery.Name = "simpleButtonQuery";
            this.simpleButtonQuery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.simpleButtonQuery.Size = new System.Drawing.Size(65, 33);
            this.simpleButtonQuery.TabIndex = 2;
            this.simpleButtonQuery.Text = "조회";
            this.simpleButtonQuery.Click += new System.EventHandler(this.simpleButtonQuery_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 14);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "주소 검색어";
            // 
            // gridControlAddrSearch
            // 
            this.gridControlAddrSearch.DataMember = "Query";
            this.gridControlAddrSearch.DataSource = this.sqlDataSource1;
            this.gridControlAddrSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAddrSearch.Location = new System.Drawing.Point(0, 37);
            this.gridControlAddrSearch.MainView = this.gridViewAddrSearch;
            this.gridControlAddrSearch.Name = "gridControlAddrSearch";
            this.gridControlAddrSearch.Size = new System.Drawing.Size(984, 525);
            this.gridControlAddrSearch.TabIndex = 3;
            this.gridControlAddrSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAddrSearch});
            this.gridControlAddrSearch.DoubleClick += new System.EventHandler(this.gridControlAddrSearch_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "db.edupool.xyz_dbedupool_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridViewAddrSearch
            // 
            this.gridViewAddrSearch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colZIP_CD,
            this.colSIDO,
            this.colSIGUNGU,
            this.colROAD_NAME,
            this.colBUILD_BON_NO,
            this.colBUILD_BU_NO,
            this.colSIGUNGU_BUILD_NAME,
            this.colHANG_DONG_NAME,
            this.colDONG_NAME,
            this.colRI_NAME,
            this.colJIBUN_BONBUN,
            this.colJIBUN_BUBUN});
            this.gridViewAddrSearch.GridControl = this.gridControlAddrSearch;
            this.gridViewAddrSearch.Name = "gridViewAddrSearch";
            this.gridViewAddrSearch.OptionsView.ShowGroupPanel = false;
            // 
            // colZIP_CD
            // 
            this.colZIP_CD.Caption = "우편번호";
            this.colZIP_CD.FieldName = "ZIP_CD";
            this.colZIP_CD.Name = "colZIP_CD";
            this.colZIP_CD.OptionsColumn.AllowEdit = false;
            this.colZIP_CD.OptionsColumn.AllowFocus = false;
            this.colZIP_CD.OptionsColumn.ReadOnly = true;
            this.colZIP_CD.Visible = true;
            this.colZIP_CD.VisibleIndex = 0;
            // 
            // colSIDO
            // 
            this.colSIDO.Caption = "시도";
            this.colSIDO.FieldName = "SIDO";
            this.colSIDO.Name = "colSIDO";
            this.colSIDO.OptionsColumn.AllowEdit = false;
            this.colSIDO.OptionsColumn.AllowFocus = false;
            this.colSIDO.OptionsColumn.ReadOnly = true;
            this.colSIDO.Visible = true;
            this.colSIDO.VisibleIndex = 1;
            // 
            // colSIGUNGU
            // 
            this.colSIGUNGU.Caption = "시군구";
            this.colSIGUNGU.FieldName = "SIGUNGU";
            this.colSIGUNGU.Name = "colSIGUNGU";
            this.colSIGUNGU.OptionsColumn.AllowEdit = false;
            this.colSIGUNGU.OptionsColumn.AllowFocus = false;
            this.colSIGUNGU.OptionsColumn.ReadOnly = true;
            this.colSIGUNGU.Visible = true;
            this.colSIGUNGU.VisibleIndex = 2;
            // 
            // colROAD_NAME
            // 
            this.colROAD_NAME.Caption = "도로명";
            this.colROAD_NAME.FieldName = "ROAD_NAME";
            this.colROAD_NAME.Name = "colROAD_NAME";
            this.colROAD_NAME.OptionsColumn.AllowEdit = false;
            this.colROAD_NAME.OptionsColumn.AllowFocus = false;
            this.colROAD_NAME.OptionsColumn.ReadOnly = true;
            this.colROAD_NAME.Visible = true;
            this.colROAD_NAME.VisibleIndex = 3;
            // 
            // colBUILD_BON_NO
            // 
            this.colBUILD_BON_NO.Caption = "건물본번호";
            this.colBUILD_BON_NO.FieldName = "BUILD_BON_NO";
            this.colBUILD_BON_NO.Name = "colBUILD_BON_NO";
            this.colBUILD_BON_NO.OptionsColumn.AllowEdit = false;
            this.colBUILD_BON_NO.OptionsColumn.AllowFocus = false;
            this.colBUILD_BON_NO.OptionsColumn.ReadOnly = true;
            this.colBUILD_BON_NO.Visible = true;
            this.colBUILD_BON_NO.VisibleIndex = 4;
            // 
            // colBUILD_BU_NO
            // 
            this.colBUILD_BU_NO.Caption = "건물부번호";
            this.colBUILD_BU_NO.FieldName = "BUILD_BU_NO";
            this.colBUILD_BU_NO.Name = "colBUILD_BU_NO";
            this.colBUILD_BU_NO.OptionsColumn.AllowEdit = false;
            this.colBUILD_BU_NO.OptionsColumn.AllowFocus = false;
            this.colBUILD_BU_NO.OptionsColumn.ReadOnly = true;
            this.colBUILD_BU_NO.Visible = true;
            this.colBUILD_BU_NO.VisibleIndex = 5;
            // 
            // colSIGUNGU_BUILD_NAME
            // 
            this.colSIGUNGU_BUILD_NAME.Caption = "건물명";
            this.colSIGUNGU_BUILD_NAME.FieldName = "SIGUNGU_BUILD_NAME";
            this.colSIGUNGU_BUILD_NAME.Name = "colSIGUNGU_BUILD_NAME";
            this.colSIGUNGU_BUILD_NAME.OptionsColumn.AllowEdit = false;
            this.colSIGUNGU_BUILD_NAME.OptionsColumn.AllowFocus = false;
            this.colSIGUNGU_BUILD_NAME.OptionsColumn.ReadOnly = true;
            this.colSIGUNGU_BUILD_NAME.Visible = true;
            this.colSIGUNGU_BUILD_NAME.VisibleIndex = 6;
            // 
            // colHANG_DONG_NAME
            // 
            this.colHANG_DONG_NAME.Caption = "항동명";
            this.colHANG_DONG_NAME.FieldName = "HANG_DONG_NAME";
            this.colHANG_DONG_NAME.Name = "colHANG_DONG_NAME";
            this.colHANG_DONG_NAME.OptionsColumn.AllowEdit = false;
            this.colHANG_DONG_NAME.OptionsColumn.AllowFocus = false;
            this.colHANG_DONG_NAME.OptionsColumn.ReadOnly = true;
            this.colHANG_DONG_NAME.Visible = true;
            this.colHANG_DONG_NAME.VisibleIndex = 7;
            // 
            // colDONG_NAME
            // 
            this.colDONG_NAME.Caption = "동명";
            this.colDONG_NAME.FieldName = "DONG_NAME";
            this.colDONG_NAME.Name = "colDONG_NAME";
            this.colDONG_NAME.OptionsColumn.AllowEdit = false;
            this.colDONG_NAME.OptionsColumn.AllowFocus = false;
            this.colDONG_NAME.OptionsColumn.ReadOnly = true;
            this.colDONG_NAME.Visible = true;
            this.colDONG_NAME.VisibleIndex = 8;
            // 
            // colRI_NAME
            // 
            this.colRI_NAME.Caption = "리명";
            this.colRI_NAME.FieldName = "RI_NAME";
            this.colRI_NAME.Name = "colRI_NAME";
            this.colRI_NAME.OptionsColumn.AllowEdit = false;
            this.colRI_NAME.OptionsColumn.AllowFocus = false;
            this.colRI_NAME.OptionsColumn.ReadOnly = true;
            this.colRI_NAME.Visible = true;
            this.colRI_NAME.VisibleIndex = 9;
            // 
            // colJIBUN_BONBUN
            // 
            this.colJIBUN_BONBUN.Caption = "지번본번";
            this.colJIBUN_BONBUN.FieldName = "JIBUN_BONBUN";
            this.colJIBUN_BONBUN.Name = "colJIBUN_BONBUN";
            this.colJIBUN_BONBUN.OptionsColumn.AllowEdit = false;
            this.colJIBUN_BONBUN.OptionsColumn.AllowFocus = false;
            this.colJIBUN_BONBUN.OptionsColumn.ReadOnly = true;
            this.colJIBUN_BONBUN.Visible = true;
            this.colJIBUN_BONBUN.VisibleIndex = 11;
            // 
            // colJIBUN_BUBUN
            // 
            this.colJIBUN_BUBUN.Caption = "지번부번";
            this.colJIBUN_BUBUN.FieldName = "JIBUN_BUBUN";
            this.colJIBUN_BUBUN.Name = "colJIBUN_BUBUN";
            this.colJIBUN_BUBUN.OptionsColumn.AllowEdit = false;
            this.colJIBUN_BUBUN.OptionsColumn.AllowFocus = false;
            this.colJIBUN_BUBUN.OptionsColumn.ReadOnly = true;
            this.colJIBUN_BUBUN.Visible = true;
            this.colJIBUN_BUBUN.VisibleIndex = 10;
            // 
            // postPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.gridControlAddrSearch);
            this.Controls.Add(this.panelControl1);
            this.Name = "postPopupForm";
            this.Text = "우편번호 검색";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAddrSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAddrSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonQuery;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditAddr;
        private DevExpress.XtraGrid.GridControl gridControlAddrSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAddrSearch;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colZIP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colSIDO;
        private DevExpress.XtraGrid.Columns.GridColumn colSIGUNGU;
        private DevExpress.XtraGrid.Columns.GridColumn colROAD_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colBUILD_BON_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colBUILD_BU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colSIGUNGU_BUILD_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colHANG_DONG_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDONG_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colJIBUN_BONBUN;
        private DevExpress.XtraGrid.Columns.GridColumn colJIBUN_BUBUN;
    }
}