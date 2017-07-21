namespace officeManager
{
    partial class memSearchPopupForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEditAddr = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlMemSearch = new DevExpress.XtraGrid.GridControl();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.gridViewAddrSearch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMBR_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPLY_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMBR_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGENDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBJ_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLVL_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNTR_FG_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBS_AMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBS_MM_CNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMBR_FG_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCTRTR_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMBR_REL_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHON_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMemSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "회원이름";
            // 
            // gridControlMemSearch
            // 
            this.gridControlMemSearch.DataSource = this.dataSet1;
            this.gridControlMemSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMemSearch.Location = new System.Drawing.Point(0, 37);
            this.gridControlMemSearch.MainView = this.gridViewAddrSearch;
            this.gridControlMemSearch.Name = "gridControlMemSearch";
            this.gridControlMemSearch.Size = new System.Drawing.Size(984, 525);
            this.gridControlMemSearch.TabIndex = 3;
            this.gridControlMemSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAddrSearch});
            this.gridControlMemSearch.DoubleClick += new System.EventHandler(this.gridControlAddrSearch_DoubleClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "MBR_NO";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "APPLY_SEQ";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "MBR_NM";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "GENDER";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "SUBJ_CD";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "LVL_CD";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "CNTR_FG_CD";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "SUBS_AMT";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "SUBS_MM_CNT";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "MBR_FG_CD";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "CTRTR_NM";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "PHON_NO";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "MBR_REL_NM";
            // 
            // gridViewAddrSearch
            // 
            this.gridViewAddrSearch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMBR_NO,
            this.colAPPLY_SEQ,
            this.colMBR_NM,
            this.colGENDER,
            this.colSUBJ_CD,
            this.colLVL_CD,
            this.colCNTR_FG_CD,
            this.colSUBS_AMT,
            this.colSUBS_MM_CNT,
            this.colMBR_FG_CD,
            this.colCTRTR_NM,
            this.colMBR_REL_NM,
            this.colPHON_NO});
            this.gridViewAddrSearch.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewAddrSearch.GridControl = this.gridControlMemSearch;
            this.gridViewAddrSearch.Name = "gridViewAddrSearch";
            this.gridViewAddrSearch.OptionsView.ShowGroupPanel = false;
            // 
            // colMBR_NO
            // 
            this.colMBR_NO.Caption = "회원번호";
            this.colMBR_NO.FieldName = "MBR_NO";
            this.colMBR_NO.Name = "colMBR_NO";
            this.colMBR_NO.OptionsColumn.AllowEdit = false;
            this.colMBR_NO.OptionsColumn.AllowFocus = false;
            this.colMBR_NO.OptionsColumn.ReadOnly = true;
            this.colMBR_NO.Visible = true;
            this.colMBR_NO.VisibleIndex = 0;
            // 
            // colAPPLY_SEQ
            // 
            this.colAPPLY_SEQ.Caption = "신청순번";
            this.colAPPLY_SEQ.FieldName = "APPLY_SEQ";
            this.colAPPLY_SEQ.Name = "colAPPLY_SEQ";
            this.colAPPLY_SEQ.OptionsColumn.AllowEdit = false;
            this.colAPPLY_SEQ.OptionsColumn.AllowFocus = false;
            this.colAPPLY_SEQ.OptionsColumn.ReadOnly = true;
            this.colAPPLY_SEQ.Visible = true;
            this.colAPPLY_SEQ.VisibleIndex = 1;
            // 
            // colMBR_NM
            // 
            this.colMBR_NM.Caption = "회원명";
            this.colMBR_NM.FieldName = "MBR_NM";
            this.colMBR_NM.Name = "colMBR_NM";
            this.colMBR_NM.OptionsColumn.AllowEdit = false;
            this.colMBR_NM.OptionsColumn.AllowFocus = false;
            this.colMBR_NM.OptionsColumn.ReadOnly = true;
            this.colMBR_NM.Visible = true;
            this.colMBR_NM.VisibleIndex = 2;
            // 
            // colGENDER
            // 
            this.colGENDER.Caption = "성별";
            this.colGENDER.FieldName = "GENDER";
            this.colGENDER.Name = "colGENDER";
            this.colGENDER.OptionsColumn.AllowEdit = false;
            this.colGENDER.OptionsColumn.AllowFocus = false;
            this.colGENDER.OptionsColumn.ReadOnly = true;
            this.colGENDER.Visible = true;
            this.colGENDER.VisibleIndex = 3;
            // 
            // colSUBJ_CD
            // 
            this.colSUBJ_CD.Caption = "과목코드";
            this.colSUBJ_CD.FieldName = "SUBJ_CD";
            this.colSUBJ_CD.Name = "colSUBJ_CD";
            this.colSUBJ_CD.OptionsColumn.AllowEdit = false;
            this.colSUBJ_CD.OptionsColumn.AllowFocus = false;
            this.colSUBJ_CD.OptionsColumn.ReadOnly = true;
            this.colSUBJ_CD.Visible = true;
            this.colSUBJ_CD.VisibleIndex = 4;
            // 
            // colLVL_CD
            // 
            this.colLVL_CD.Caption = "레벨코드";
            this.colLVL_CD.FieldName = "LVL_CD";
            this.colLVL_CD.Name = "colLVL_CD";
            this.colLVL_CD.OptionsColumn.AllowEdit = false;
            this.colLVL_CD.OptionsColumn.AllowFocus = false;
            this.colLVL_CD.OptionsColumn.ReadOnly = true;
            this.colLVL_CD.Visible = true;
            this.colLVL_CD.VisibleIndex = 5;
            // 
            // colCNTR_FG_CD
            // 
            this.colCNTR_FG_CD.Caption = "계약부분";
            this.colCNTR_FG_CD.FieldName = "CNTR_FG_CD";
            this.colCNTR_FG_CD.Name = "colCNTR_FG_CD";
            this.colCNTR_FG_CD.OptionsColumn.AllowEdit = false;
            this.colCNTR_FG_CD.OptionsColumn.AllowFocus = false;
            this.colCNTR_FG_CD.OptionsColumn.ReadOnly = true;
            this.colCNTR_FG_CD.Visible = true;
            this.colCNTR_FG_CD.VisibleIndex = 6;
            // 
            // colSUBS_AMT
            // 
            this.colSUBS_AMT.Caption = "구독료";
            this.colSUBS_AMT.FieldName = "SUBS_AMT";
            this.colSUBS_AMT.Name = "colSUBS_AMT";
            this.colSUBS_AMT.OptionsColumn.AllowEdit = false;
            this.colSUBS_AMT.OptionsColumn.AllowFocus = false;
            this.colSUBS_AMT.OptionsColumn.ReadOnly = true;
            this.colSUBS_AMT.Visible = true;
            this.colSUBS_AMT.VisibleIndex = 7;
            // 
            // colSUBS_MM_CNT
            // 
            this.colSUBS_MM_CNT.Caption = "구독개월수";
            this.colSUBS_MM_CNT.FieldName = "SUBS_MM_CNT";
            this.colSUBS_MM_CNT.Name = "colSUBS_MM_CNT";
            this.colSUBS_MM_CNT.OptionsColumn.AllowEdit = false;
            this.colSUBS_MM_CNT.OptionsColumn.AllowFocus = false;
            this.colSUBS_MM_CNT.OptionsColumn.ReadOnly = true;
            this.colSUBS_MM_CNT.Visible = true;
            this.colSUBS_MM_CNT.VisibleIndex = 8;
            // 
            // colMBR_FG_CD
            // 
            this.colMBR_FG_CD.Caption = "회원구분";
            this.colMBR_FG_CD.FieldName = "MBR_FG_CD";
            this.colMBR_FG_CD.Name = "colMBR_FG_CD";
            this.colMBR_FG_CD.OptionsColumn.AllowEdit = false;
            this.colMBR_FG_CD.OptionsColumn.AllowFocus = false;
            this.colMBR_FG_CD.OptionsColumn.ReadOnly = true;
            this.colMBR_FG_CD.Visible = true;
            this.colMBR_FG_CD.VisibleIndex = 9;
            // 
            // colCTRTR_NM
            // 
            this.colCTRTR_NM.Caption = "계약자명";
            this.colCTRTR_NM.FieldName = "CTRTR_NM";
            this.colCTRTR_NM.Name = "colCTRTR_NM";
            this.colCTRTR_NM.OptionsColumn.AllowEdit = false;
            this.colCTRTR_NM.OptionsColumn.AllowFocus = false;
            this.colCTRTR_NM.OptionsColumn.ReadOnly = true;
            this.colCTRTR_NM.Visible = true;
            this.colCTRTR_NM.VisibleIndex = 10;
            // 
            // colMBR_REL_NM
            // 
            this.colMBR_REL_NM.Caption = "회원과의관계";
            this.colMBR_REL_NM.FieldName = "MBR_REL_NM";
            this.colMBR_REL_NM.Name = "colMBR_REL_NM";
            this.colMBR_REL_NM.OptionsColumn.AllowEdit = false;
            this.colMBR_REL_NM.OptionsColumn.AllowFocus = false;
            this.colMBR_REL_NM.OptionsColumn.ReadOnly = true;
            this.colMBR_REL_NM.Visible = true;
            this.colMBR_REL_NM.VisibleIndex = 12;
            // 
            // colPHON_NO
            // 
            this.colPHON_NO.Caption = "대표전화";
            this.colPHON_NO.FieldName = "PHON_NO";
            this.colPHON_NO.Name = "colPHON_NO";
            this.colPHON_NO.OptionsColumn.AllowEdit = false;
            this.colPHON_NO.OptionsColumn.AllowFocus = false;
            this.colPHON_NO.OptionsColumn.ReadOnly = true;
            this.colPHON_NO.Visible = true;
            this.colPHON_NO.VisibleIndex = 11;
            // 
            // memSearchPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.gridControlMemSearch);
            this.Controls.Add(this.panelControl1);
            this.Name = "memSearchPopupForm";
            this.Text = "회원 검색";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMemSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAddrSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonQuery;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditAddr;
        private DevExpress.XtraGrid.GridControl gridControlMemSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAddrSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colMBR_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPLY_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colGENDER;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBJ_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colLVL_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCNTR_FG_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBS_AMT;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBS_MM_CNT;
        private DevExpress.XtraGrid.Columns.GridColumn colMBR_FG_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCTRTR_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colMBR_REL_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colPHON_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colMBR_NM;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
    }
}