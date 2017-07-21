namespace officeManager
{
    partial class MemberQueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberQueryForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEditMember = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMBR_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPLY_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMBR_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIRTH_DT = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colPHON_NO2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZIP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDR1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDR2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNTR_AMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALES_PSN_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNTR_PLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPLY_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD_STR_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD_END_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD_STR_HO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNCL_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNCL_AMT_PAY_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNCL_PLN_AMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMNT_10P_AMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNCL_AMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMNGT_FEE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPYMT_FG_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMBR_STS_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAST_DELV_HO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRCH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFILE_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALLOT_MM_CNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPYMT_DY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD_STR_YM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTD_END_YM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMNT_AMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_LOSS_RT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREG_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREG_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDT_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textEditMember);
            this.panelControl1.Controls.Add(this.simpleButtonQuery);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1163, 37);
            this.panelControl1.TabIndex = 1;
            // 
            // textEditMember
            // 
            this.textEditMember.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.textEditMember.Location = new System.Drawing.Point(66, 8);
            this.textEditMember.Name = "textEditMember";
            this.textEditMember.Size = new System.Drawing.Size(100, 20);
            this.textEditMember.TabIndex = 4;
            // 
            // simpleButtonQuery
            // 
            this.simpleButtonQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonQuery.Location = new System.Drawing.Point(1096, 2);
            this.simpleButtonQuery.Name = "simpleButtonQuery";
            this.simpleButtonQuery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.simpleButtonQuery.Size = new System.Drawing.Size(65, 33);
            this.simpleButtonQuery.TabIndex = 3;
            this.simpleButtonQuery.Text = "조회";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Location = new System.Drawing.Point(173, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(238, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "(입력 가능 항목 : 회원명, 전화번호, 지역명)";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "회원정보";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1163, 540);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMBR_NO,
            this.colAPPLY_SEQ,
            this.colMBR_NM,
            this.colBIRTH_DT,
            this.colGENDER,
            this.colSUBJ_CD,
            this.colLVL_CD,
            this.colCNTR_FG_CD,
            this.colSUBS_AMT,
            this.colSUBS_MM_CNT,
            this.colMBR_FG_CD,
            this.colCTRTR_NM,
            this.colMBR_REL_NM,
            this.colPHON_NO,
            this.colPHON_NO2,
            this.colZIP_NO,
            this.colADDR1,
            this.colADDR2,
            this.colCNTR_AMT,
            this.colSALES_PSN_NO,
            this.colCNTR_PLC,
            this.colAPPLY_DT,
            this.colSTD_STR_DT,
            this.colSTD_END_DT,
            this.colSTD_STR_HO,
            this.colCNCL_DT,
            this.colCNCL_AMT_PAY_DT,
            this.colCNCL_PLN_AMT,
            this.colREMNT_10P_AMT,
            this.colCNCL_AMT,
            this.colMNGT_FEE,
            this.colPYMT_FG_CD,
            this.colMBR_STS_CD,
            this.colLAST_DELV_HO,
            this.colBRCH_CD,
            this.colFILE_NM,
            this.colALLOT_MM_CNT,
            this.colPYMT_DY,
            this.colSTD_STR_YM,
            this.colSTD_END_YM,
            this.colREMNT_AMT,
            this.colPROD_LOSS_RT,
            this.colREG_ID,
            this.colREG_DTTM,
            this.colUPDT_ID,
            this.colUPDT_DTTM});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // colBIRTH_DT
            // 
            this.colBIRTH_DT.Caption = "생년월일";
            this.colBIRTH_DT.FieldName = "BIRTH_DT";
            this.colBIRTH_DT.Name = "colBIRTH_DT";
            this.colBIRTH_DT.OptionsColumn.AllowEdit = false;
            this.colBIRTH_DT.OptionsColumn.AllowFocus = false;
            this.colBIRTH_DT.OptionsColumn.ReadOnly = true;
            this.colBIRTH_DT.Visible = true;
            this.colBIRTH_DT.VisibleIndex = 3;
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
            this.colGENDER.VisibleIndex = 4;
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
            this.colSUBJ_CD.VisibleIndex = 5;
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
            this.colLVL_CD.VisibleIndex = 6;
            // 
            // colCNTR_FG_CD
            // 
            this.colCNTR_FG_CD.Caption = "계약구분코드";
            this.colCNTR_FG_CD.FieldName = "CNTR_FG_CD";
            this.colCNTR_FG_CD.Name = "colCNTR_FG_CD";
            this.colCNTR_FG_CD.OptionsColumn.AllowEdit = false;
            this.colCNTR_FG_CD.OptionsColumn.AllowFocus = false;
            this.colCNTR_FG_CD.OptionsColumn.ReadOnly = true;
            this.colCNTR_FG_CD.Visible = true;
            this.colCNTR_FG_CD.VisibleIndex = 7;
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
            this.colSUBS_AMT.VisibleIndex = 8;
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
            this.colSUBS_MM_CNT.VisibleIndex = 9;
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
            this.colMBR_FG_CD.VisibleIndex = 10;
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
            this.colCTRTR_NM.VisibleIndex = 11;
            // 
            // colMBR_REL_NM
            // 
            this.colMBR_REL_NM.Caption = "회원과의관계명";
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
            this.colPHON_NO.Caption = "대표전화번호";
            this.colPHON_NO.FieldName = "PHON_NO";
            this.colPHON_NO.Name = "colPHON_NO";
            this.colPHON_NO.OptionsColumn.AllowEdit = false;
            this.colPHON_NO.OptionsColumn.AllowFocus = false;
            this.colPHON_NO.OptionsColumn.ReadOnly = true;
            this.colPHON_NO.Visible = true;
            this.colPHON_NO.VisibleIndex = 13;
            // 
            // colPHON_NO2
            // 
            this.colPHON_NO2.Caption = "추가전화번호";
            this.colPHON_NO2.FieldName = "PHON_NO2";
            this.colPHON_NO2.Name = "colPHON_NO2";
            this.colPHON_NO2.OptionsColumn.AllowEdit = false;
            this.colPHON_NO2.OptionsColumn.AllowFocus = false;
            this.colPHON_NO2.OptionsColumn.ReadOnly = true;
            this.colPHON_NO2.Visible = true;
            this.colPHON_NO2.VisibleIndex = 14;
            // 
            // colZIP_NO
            // 
            this.colZIP_NO.Caption = "우편번호";
            this.colZIP_NO.FieldName = "ZIP_NO";
            this.colZIP_NO.Name = "colZIP_NO";
            this.colZIP_NO.OptionsColumn.AllowEdit = false;
            this.colZIP_NO.OptionsColumn.AllowFocus = false;
            this.colZIP_NO.OptionsColumn.ReadOnly = true;
            this.colZIP_NO.Visible = true;
            this.colZIP_NO.VisibleIndex = 15;
            // 
            // colADDR1
            // 
            this.colADDR1.Caption = "기본주소";
            this.colADDR1.FieldName = "ADDR1";
            this.colADDR1.Name = "colADDR1";
            this.colADDR1.OptionsColumn.AllowEdit = false;
            this.colADDR1.OptionsColumn.AllowFocus = false;
            this.colADDR1.OptionsColumn.ReadOnly = true;
            this.colADDR1.Visible = true;
            this.colADDR1.VisibleIndex = 16;
            // 
            // colADDR2
            // 
            this.colADDR2.Caption = "상세주소";
            this.colADDR2.FieldName = "ADDR2";
            this.colADDR2.Name = "colADDR2";
            this.colADDR2.OptionsColumn.AllowEdit = false;
            this.colADDR2.OptionsColumn.AllowFocus = false;
            this.colADDR2.OptionsColumn.ReadOnly = true;
            this.colADDR2.Visible = true;
            this.colADDR2.VisibleIndex = 17;
            // 
            // colCNTR_AMT
            // 
            this.colCNTR_AMT.Caption = "계약금";
            this.colCNTR_AMT.FieldName = "CNTR_AMT";
            this.colCNTR_AMT.Name = "colCNTR_AMT";
            this.colCNTR_AMT.OptionsColumn.AllowEdit = false;
            this.colCNTR_AMT.OptionsColumn.AllowFocus = false;
            this.colCNTR_AMT.OptionsColumn.ReadOnly = true;
            this.colCNTR_AMT.Visible = true;
            this.colCNTR_AMT.VisibleIndex = 18;
            // 
            // colSALES_PSN_NO
            // 
            this.colSALES_PSN_NO.Caption = "상담자번호";
            this.colSALES_PSN_NO.FieldName = "SALES_PSN_NO";
            this.colSALES_PSN_NO.Name = "colSALES_PSN_NO";
            this.colSALES_PSN_NO.OptionsColumn.AllowEdit = false;
            this.colSALES_PSN_NO.OptionsColumn.AllowFocus = false;
            this.colSALES_PSN_NO.OptionsColumn.ReadOnly = true;
            this.colSALES_PSN_NO.Visible = true;
            this.colSALES_PSN_NO.VisibleIndex = 19;
            // 
            // colCNTR_PLC
            // 
            this.colCNTR_PLC.Caption = "계약장소";
            this.colCNTR_PLC.FieldName = "CNTR_PLC";
            this.colCNTR_PLC.Name = "colCNTR_PLC";
            this.colCNTR_PLC.OptionsColumn.AllowEdit = false;
            this.colCNTR_PLC.OptionsColumn.AllowFocus = false;
            this.colCNTR_PLC.OptionsColumn.ReadOnly = true;
            this.colCNTR_PLC.Visible = true;
            this.colCNTR_PLC.VisibleIndex = 20;
            // 
            // colAPPLY_DT
            // 
            this.colAPPLY_DT.Caption = "신청일자";
            this.colAPPLY_DT.FieldName = "APPLY_DT";
            this.colAPPLY_DT.Name = "colAPPLY_DT";
            this.colAPPLY_DT.OptionsColumn.AllowEdit = false;
            this.colAPPLY_DT.OptionsColumn.AllowFocus = false;
            this.colAPPLY_DT.OptionsColumn.ReadOnly = true;
            this.colAPPLY_DT.Visible = true;
            this.colAPPLY_DT.VisibleIndex = 21;
            // 
            // colSTD_STR_DT
            // 
            this.colSTD_STR_DT.Caption = "학습시작일자";
            this.colSTD_STR_DT.FieldName = "STD_STR_DT";
            this.colSTD_STR_DT.Name = "colSTD_STR_DT";
            this.colSTD_STR_DT.OptionsColumn.AllowEdit = false;
            this.colSTD_STR_DT.OptionsColumn.AllowFocus = false;
            this.colSTD_STR_DT.OptionsColumn.ReadOnly = true;
            this.colSTD_STR_DT.Visible = true;
            this.colSTD_STR_DT.VisibleIndex = 22;
            // 
            // colSTD_END_DT
            // 
            this.colSTD_END_DT.Caption = "학습종료일자";
            this.colSTD_END_DT.FieldName = "STD_END_DT";
            this.colSTD_END_DT.Name = "colSTD_END_DT";
            this.colSTD_END_DT.OptionsColumn.AllowEdit = false;
            this.colSTD_END_DT.OptionsColumn.AllowFocus = false;
            this.colSTD_END_DT.OptionsColumn.ReadOnly = true;
            this.colSTD_END_DT.Visible = true;
            this.colSTD_END_DT.VisibleIndex = 23;
            // 
            // colSTD_STR_HO
            // 
            this.colSTD_STR_HO.Caption = "학습시작호";
            this.colSTD_STR_HO.FieldName = "STD_STR_HO";
            this.colSTD_STR_HO.Name = "colSTD_STR_HO";
            this.colSTD_STR_HO.OptionsColumn.AllowEdit = false;
            this.colSTD_STR_HO.OptionsColumn.AllowFocus = false;
            this.colSTD_STR_HO.OptionsColumn.ReadOnly = true;
            this.colSTD_STR_HO.Visible = true;
            this.colSTD_STR_HO.VisibleIndex = 24;
            // 
            // colCNCL_DT
            // 
            this.colCNCL_DT.Caption = "해약일자";
            this.colCNCL_DT.FieldName = "CNCL_DT";
            this.colCNCL_DT.Name = "colCNCL_DT";
            this.colCNCL_DT.OptionsColumn.AllowEdit = false;
            this.colCNCL_DT.OptionsColumn.AllowFocus = false;
            this.colCNCL_DT.OptionsColumn.ReadOnly = true;
            this.colCNCL_DT.Visible = true;
            this.colCNCL_DT.VisibleIndex = 25;
            // 
            // colCNCL_AMT_PAY_DT
            // 
            this.colCNCL_AMT_PAY_DT.Caption = "해약금지급일자";
            this.colCNCL_AMT_PAY_DT.FieldName = "CNCL_AMT_PAY_DT";
            this.colCNCL_AMT_PAY_DT.Name = "colCNCL_AMT_PAY_DT";
            this.colCNCL_AMT_PAY_DT.OptionsColumn.AllowEdit = false;
            this.colCNCL_AMT_PAY_DT.OptionsColumn.AllowFocus = false;
            this.colCNCL_AMT_PAY_DT.OptionsColumn.ReadOnly = true;
            this.colCNCL_AMT_PAY_DT.Visible = true;
            this.colCNCL_AMT_PAY_DT.VisibleIndex = 26;
            // 
            // colCNCL_PLN_AMT
            // 
            this.colCNCL_PLN_AMT.Caption = "해약지급예정금액";
            this.colCNCL_PLN_AMT.FieldName = "CNCL_PLN_AMT";
            this.colCNCL_PLN_AMT.Name = "colCNCL_PLN_AMT";
            this.colCNCL_PLN_AMT.OptionsColumn.AllowEdit = false;
            this.colCNCL_PLN_AMT.OptionsColumn.AllowFocus = false;
            this.colCNCL_PLN_AMT.OptionsColumn.ReadOnly = true;
            this.colCNCL_PLN_AMT.Visible = true;
            this.colCNCL_PLN_AMT.VisibleIndex = 27;
            // 
            // colREMNT_10P_AMT
            // 
            this.colREMNT_10P_AMT.Caption = "잔여기간10%금액";
            this.colREMNT_10P_AMT.FieldName = "REMNT_10P_AMT";
            this.colREMNT_10P_AMT.Name = "colREMNT_10P_AMT";
            this.colREMNT_10P_AMT.OptionsColumn.AllowEdit = false;
            this.colREMNT_10P_AMT.OptionsColumn.AllowFocus = false;
            this.colREMNT_10P_AMT.OptionsColumn.ReadOnly = true;
            this.colREMNT_10P_AMT.Visible = true;
            this.colREMNT_10P_AMT.VisibleIndex = 28;
            // 
            // colCNCL_AMT
            // 
            this.colCNCL_AMT.Caption = "해약금액";
            this.colCNCL_AMT.FieldName = "CNCL_AMT";
            this.colCNCL_AMT.Name = "colCNCL_AMT";
            this.colCNCL_AMT.OptionsColumn.AllowEdit = false;
            this.colCNCL_AMT.OptionsColumn.AllowFocus = false;
            this.colCNCL_AMT.OptionsColumn.ReadOnly = true;
            this.colCNCL_AMT.Visible = true;
            this.colCNCL_AMT.VisibleIndex = 29;
            // 
            // colMNGT_FEE
            // 
            this.colMNGT_FEE.Caption = "관리비";
            this.colMNGT_FEE.FieldName = "MNGT_FEE";
            this.colMNGT_FEE.Name = "colMNGT_FEE";
            this.colMNGT_FEE.OptionsColumn.AllowEdit = false;
            this.colMNGT_FEE.OptionsColumn.AllowFocus = false;
            this.colMNGT_FEE.OptionsColumn.ReadOnly = true;
            this.colMNGT_FEE.Visible = true;
            this.colMNGT_FEE.VisibleIndex = 30;
            // 
            // colPYMT_FG_CD
            // 
            this.colPYMT_FG_CD.Caption = "결제구분코드";
            this.colPYMT_FG_CD.FieldName = "PYMT_FG_CD";
            this.colPYMT_FG_CD.Name = "colPYMT_FG_CD";
            this.colPYMT_FG_CD.OptionsColumn.AllowEdit = false;
            this.colPYMT_FG_CD.OptionsColumn.AllowFocus = false;
            this.colPYMT_FG_CD.OptionsColumn.ReadOnly = true;
            this.colPYMT_FG_CD.Visible = true;
            this.colPYMT_FG_CD.VisibleIndex = 31;
            // 
            // colMBR_STS_CD
            // 
            this.colMBR_STS_CD.Caption = "회원상태코드";
            this.colMBR_STS_CD.FieldName = "MBR_STS_CD";
            this.colMBR_STS_CD.Name = "colMBR_STS_CD";
            this.colMBR_STS_CD.OptionsColumn.AllowEdit = false;
            this.colMBR_STS_CD.OptionsColumn.AllowFocus = false;
            this.colMBR_STS_CD.OptionsColumn.ReadOnly = true;
            this.colMBR_STS_CD.Visible = true;
            this.colMBR_STS_CD.VisibleIndex = 32;
            // 
            // colLAST_DELV_HO
            // 
            this.colLAST_DELV_HO.Caption = "최종발송호";
            this.colLAST_DELV_HO.FieldName = "LAST_DELV_HO";
            this.colLAST_DELV_HO.Name = "colLAST_DELV_HO";
            this.colLAST_DELV_HO.OptionsColumn.AllowEdit = false;
            this.colLAST_DELV_HO.OptionsColumn.AllowFocus = false;
            this.colLAST_DELV_HO.OptionsColumn.ReadOnly = true;
            this.colLAST_DELV_HO.Visible = true;
            this.colLAST_DELV_HO.VisibleIndex = 33;
            // 
            // colBRCH_CD
            // 
            this.colBRCH_CD.Caption = "지사코드";
            this.colBRCH_CD.FieldName = "BRCH_CD";
            this.colBRCH_CD.Name = "colBRCH_CD";
            this.colBRCH_CD.OptionsColumn.AllowEdit = false;
            this.colBRCH_CD.OptionsColumn.AllowFocus = false;
            this.colBRCH_CD.OptionsColumn.ReadOnly = true;
            this.colBRCH_CD.Visible = true;
            this.colBRCH_CD.VisibleIndex = 34;
            // 
            // colFILE_NM
            // 
            this.colFILE_NM.Caption = "계약서파일명";
            this.colFILE_NM.FieldName = "FILE_NM";
            this.colFILE_NM.Name = "colFILE_NM";
            this.colFILE_NM.OptionsColumn.AllowEdit = false;
            this.colFILE_NM.OptionsColumn.AllowFocus = false;
            this.colFILE_NM.OptionsColumn.ReadOnly = true;
            this.colFILE_NM.Visible = true;
            this.colFILE_NM.VisibleIndex = 35;
            // 
            // colALLOT_MM_CNT
            // 
            this.colALLOT_MM_CNT.Caption = "할부개월수";
            this.colALLOT_MM_CNT.FieldName = "ALLOT_MM_CNT";
            this.colALLOT_MM_CNT.Name = "colALLOT_MM_CNT";
            this.colALLOT_MM_CNT.OptionsColumn.AllowEdit = false;
            this.colALLOT_MM_CNT.OptionsColumn.AllowFocus = false;
            this.colALLOT_MM_CNT.OptionsColumn.ReadOnly = true;
            this.colALLOT_MM_CNT.Visible = true;
            this.colALLOT_MM_CNT.VisibleIndex = 40;
            // 
            // colPYMT_DY
            // 
            this.colPYMT_DY.Caption = "결재일";
            this.colPYMT_DY.FieldName = "PYMT_DY";
            this.colPYMT_DY.Name = "colPYMT_DY";
            this.colPYMT_DY.OptionsColumn.AllowEdit = false;
            this.colPYMT_DY.OptionsColumn.AllowFocus = false;
            this.colPYMT_DY.OptionsColumn.ReadOnly = true;
            this.colPYMT_DY.Visible = true;
            this.colPYMT_DY.VisibleIndex = 41;
            // 
            // colSTD_STR_YM
            // 
            this.colSTD_STR_YM.FieldName = "STD_STR_YM";
            this.colSTD_STR_YM.Name = "colSTD_STR_YM";
            this.colSTD_STR_YM.OptionsColumn.AllowEdit = false;
            this.colSTD_STR_YM.OptionsColumn.AllowFocus = false;
            this.colSTD_STR_YM.OptionsColumn.ReadOnly = true;
            this.colSTD_STR_YM.Visible = true;
            this.colSTD_STR_YM.VisibleIndex = 42;
            // 
            // colSTD_END_YM
            // 
            this.colSTD_END_YM.FieldName = "STD_END_YM";
            this.colSTD_END_YM.Name = "colSTD_END_YM";
            this.colSTD_END_YM.OptionsColumn.AllowEdit = false;
            this.colSTD_END_YM.OptionsColumn.AllowFocus = false;
            this.colSTD_END_YM.OptionsColumn.ReadOnly = true;
            this.colSTD_END_YM.Visible = true;
            this.colSTD_END_YM.VisibleIndex = 43;
            // 
            // colREMNT_AMT
            // 
            this.colREMNT_AMT.Caption = "잔여금액";
            this.colREMNT_AMT.FieldName = "REMNT_AMT";
            this.colREMNT_AMT.Name = "colREMNT_AMT";
            this.colREMNT_AMT.OptionsColumn.AllowEdit = false;
            this.colREMNT_AMT.OptionsColumn.AllowFocus = false;
            this.colREMNT_AMT.OptionsColumn.ReadOnly = true;
            this.colREMNT_AMT.Visible = true;
            this.colREMNT_AMT.VisibleIndex = 44;
            // 
            // colPROD_LOSS_RT
            // 
            this.colPROD_LOSS_RT.Caption = "지급상품손율";
            this.colPROD_LOSS_RT.FieldName = "PROD_LOSS_RT";
            this.colPROD_LOSS_RT.Name = "colPROD_LOSS_RT";
            this.colPROD_LOSS_RT.OptionsColumn.AllowEdit = false;
            this.colPROD_LOSS_RT.OptionsColumn.AllowFocus = false;
            this.colPROD_LOSS_RT.OptionsColumn.ReadOnly = true;
            this.colPROD_LOSS_RT.Visible = true;
            this.colPROD_LOSS_RT.VisibleIndex = 45;
            // 
            // colREG_ID
            // 
            this.colREG_ID.Caption = "등록자ID";
            this.colREG_ID.FieldName = "REG_ID";
            this.colREG_ID.Name = "colREG_ID";
            this.colREG_ID.OptionsColumn.AllowEdit = false;
            this.colREG_ID.OptionsColumn.AllowFocus = false;
            this.colREG_ID.OptionsColumn.ReadOnly = true;
            this.colREG_ID.Visible = true;
            this.colREG_ID.VisibleIndex = 36;
            // 
            // colREG_DTTM
            // 
            this.colREG_DTTM.Caption = "등록일시";
            this.colREG_DTTM.FieldName = "REG_DTTM";
            this.colREG_DTTM.Name = "colREG_DTTM";
            this.colREG_DTTM.OptionsColumn.AllowEdit = false;
            this.colREG_DTTM.OptionsColumn.AllowFocus = false;
            this.colREG_DTTM.OptionsColumn.ReadOnly = true;
            this.colREG_DTTM.Visible = true;
            this.colREG_DTTM.VisibleIndex = 37;
            // 
            // colUPDT_ID
            // 
            this.colUPDT_ID.Caption = "수정자ID";
            this.colUPDT_ID.FieldName = "UPDT_ID";
            this.colUPDT_ID.Name = "colUPDT_ID";
            this.colUPDT_ID.OptionsColumn.AllowEdit = false;
            this.colUPDT_ID.OptionsColumn.AllowFocus = false;
            this.colUPDT_ID.OptionsColumn.ReadOnly = true;
            this.colUPDT_ID.Visible = true;
            this.colUPDT_ID.VisibleIndex = 38;
            // 
            // colUPDT_DTTM
            // 
            this.colUPDT_DTTM.Caption = "수정일시";
            this.colUPDT_DTTM.FieldName = "UPDT_DTTM";
            this.colUPDT_DTTM.Name = "colUPDT_DTTM";
            this.colUPDT_DTTM.OptionsColumn.AllowEdit = false;
            this.colUPDT_DTTM.OptionsColumn.AllowFocus = false;
            this.colUPDT_DTTM.OptionsColumn.ReadOnly = true;
            this.colUPDT_DTTM.Visible = true;
            this.colUPDT_DTTM.VisibleIndex = 39;
            // 
            // MemberQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 577);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "MemberQueryForm";
            this.Text = "회원 데이터";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonQuery;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditMember;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMBR_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPLY_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colMBR_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colBIRTH_DT;
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
        private DevExpress.XtraGrid.Columns.GridColumn colPHON_NO2;
        private DevExpress.XtraGrid.Columns.GridColumn colZIP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colADDR1;
        private DevExpress.XtraGrid.Columns.GridColumn colADDR2;
        private DevExpress.XtraGrid.Columns.GridColumn colCNTR_AMT;
        private DevExpress.XtraGrid.Columns.GridColumn colSALES_PSN_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCNTR_PLC;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPLY_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_STR_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_END_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_STR_HO;
        private DevExpress.XtraGrid.Columns.GridColumn colCNCL_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCNCL_AMT_PAY_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCNCL_PLN_AMT;
        private DevExpress.XtraGrid.Columns.GridColumn colREMNT_10P_AMT;
        private DevExpress.XtraGrid.Columns.GridColumn colCNCL_AMT;
        private DevExpress.XtraGrid.Columns.GridColumn colMNGT_FEE;
        private DevExpress.XtraGrid.Columns.GridColumn colPYMT_FG_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colMBR_STS_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colLAST_DELV_HO;
        private DevExpress.XtraGrid.Columns.GridColumn colBRCH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colFILE_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colREG_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colREG_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDT_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colALLOT_MM_CNT;
        private DevExpress.XtraGrid.Columns.GridColumn colPYMT_DY;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_STR_YM;
        private DevExpress.XtraGrid.Columns.GridColumn colSTD_END_YM;
        private DevExpress.XtraGrid.Columns.GridColumn colREMNT_AMT;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_LOSS_RT;
    }
}