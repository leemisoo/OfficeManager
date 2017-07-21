namespace officeManager
{
    partial class adminCommCdRegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminCommCdRegForm));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupConCommCdMaster = new DevExpress.XtraEditors.GroupControl();
            this.grdConCommCdMaster = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewCommCdMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGRP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORD_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMM_CD_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSE_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colCD_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREG_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREG_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDT_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRUD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupConCommCdDetail = new DevExpress.XtraEditors.GroupControl();
            this.grdConCommCdDetail = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewCommCdDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGRP_CD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORD_SEQ1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMM_CD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMM_CD_NM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSE_YN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_DESC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREG_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREG_DTTM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDT_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDT_DTTM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRUD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupConCommCdMaster)).BeginInit();
            this.groupConCommCdMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConCommCdMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommCdMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupConCommCdDetail)).BeginInit();
            this.groupConCommCdDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConCommCdDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommCdDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupConCommCdMaster);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupConCommCdDetail);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1163, 577);
            this.splitContainerControl1.SplitterPosition = 265;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupConCommCdMaster
            // 
            this.groupConCommCdMaster.Controls.Add(this.grdConCommCdMaster);
            this.groupConCommCdMaster.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("행추가", null),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("행삭제", null),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("저장", null),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("조회", null)});
            this.groupConCommCdMaster.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupConCommCdMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupConCommCdMaster.Location = new System.Drawing.Point(0, 0);
            this.groupConCommCdMaster.Name = "groupConCommCdMaster";
            this.groupConCommCdMaster.Size = new System.Drawing.Size(1163, 265);
            this.groupConCommCdMaster.TabIndex = 0;
            this.groupConCommCdMaster.Text = "공통코드 마스터";
            this.groupConCommCdMaster.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupConCommCdMaster_CustomButtonClick);
            this.groupConCommCdMaster.Paint += new System.Windows.Forms.PaintEventHandler(this.groupConCommCdMaster_Paint);
            // 
            // grdConCommCdMaster
            // 
            this.grdConCommCdMaster.DataMember = "Query";
            this.grdConCommCdMaster.DataSource = this.sqlDataSource1;
            this.grdConCommCdMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdConCommCdMaster.Location = new System.Drawing.Point(2, 27);
            this.grdConCommCdMaster.MainView = this.gridViewCommCdMaster;
            this.grdConCommCdMaster.Name = "grdConCommCdMaster";
            this.grdConCommCdMaster.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.grdConCommCdMaster.Size = new System.Drawing.Size(1159, 236);
            this.grdConCommCdMaster.TabIndex = 0;
            this.grdConCommCdMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCommCdMaster});
            this.grdConCommCdMaster.Click += new System.EventHandler(this.grdConCommCdMaster_Click);
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
            // gridViewCommCdMaster
            // 
            this.gridViewCommCdMaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGRP_CD,
            this.colORD_SEQ,
            this.colCOMM_CD,
            this.colCOMM_CD_NM,
            this.colUSE_YN,
            this.colCD_DESC,
            this.colREG_ID,
            this.colREG_DTTM,
            this.colUPDT_ID,
            this.colUPDT_DTTM,
            this.colCRUD});
            this.gridViewCommCdMaster.GridControl = this.grdConCommCdMaster;
            this.gridViewCommCdMaster.Name = "gridViewCommCdMaster";
            this.gridViewCommCdMaster.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridViewCommCdMaster.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewCommCdMaster.OptionsView.ShowGroupPanel = false;
            this.gridViewCommCdMaster.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewCommCdMaster_InitNewRow);
            this.gridViewCommCdMaster.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewCommCdMaster_ValidateRow);
            this.gridViewCommCdMaster.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewCommCdMaster_RowUpdated);
            this.gridViewCommCdMaster.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewCommCdMaster_ValidatingEditor);
            // 
            // colGRP_CD
            // 
            this.colGRP_CD.AppearanceCell.BackColor = System.Drawing.Color.LightYellow;
            this.colGRP_CD.AppearanceCell.Options.UseBackColor = true;
            this.colGRP_CD.Caption = "그룹코드";
            this.colGRP_CD.FieldName = "GRP_CD";
            this.colGRP_CD.Name = "colGRP_CD";
            this.colGRP_CD.OptionsColumn.AllowEdit = false;
            this.colGRP_CD.OptionsColumn.AllowFocus = false;
            this.colGRP_CD.OptionsColumn.FixedWidth = true;
            this.colGRP_CD.OptionsColumn.ReadOnly = true;
            this.colGRP_CD.Width = 20;
            // 
            // colORD_SEQ
            // 
            this.colORD_SEQ.Caption = "Seq";
            this.colORD_SEQ.FieldName = "ORD_SEQ";
            this.colORD_SEQ.Name = "colORD_SEQ";
            this.colORD_SEQ.OptionsColumn.AllowEdit = false;
            this.colORD_SEQ.OptionsColumn.AllowFocus = false;
            this.colORD_SEQ.OptionsColumn.FixedWidth = true;
            this.colORD_SEQ.OptionsColumn.ReadOnly = true;
            this.colORD_SEQ.Visible = true;
            this.colORD_SEQ.VisibleIndex = 0;
            this.colORD_SEQ.Width = 40;
            // 
            // colCOMM_CD
            // 
            this.colCOMM_CD.Caption = "공통코드";
            this.colCOMM_CD.FieldName = "COMM_CD";
            this.colCOMM_CD.Name = "colCOMM_CD";
            this.colCOMM_CD.OptionsColumn.FixedWidth = true;
            this.colCOMM_CD.Visible = true;
            this.colCOMM_CD.VisibleIndex = 1;
            this.colCOMM_CD.Width = 100;
            // 
            // colCOMM_CD_NM
            // 
            this.colCOMM_CD_NM.Caption = "공통코드명";
            this.colCOMM_CD_NM.FieldName = "COMM_CD_NM";
            this.colCOMM_CD_NM.Name = "colCOMM_CD_NM";
            this.colCOMM_CD_NM.OptionsColumn.FixedWidth = true;
            this.colCOMM_CD_NM.Visible = true;
            this.colCOMM_CD_NM.VisibleIndex = 2;
            this.colCOMM_CD_NM.Width = 150;
            // 
            // colUSE_YN
            // 
            this.colUSE_YN.Caption = "사용여부";
            this.colUSE_YN.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colUSE_YN.FieldName = "USE_YN";
            this.colUSE_YN.Name = "colUSE_YN";
            this.colUSE_YN.OptionsColumn.FixedWidth = true;
            this.colUSE_YN.Visible = true;
            this.colUSE_YN.VisibleIndex = 3;
            this.colUSE_YN.Width = 60;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Y", "Y", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("N", "N", -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colCD_DESC
            // 
            this.colCD_DESC.Caption = "코드설명";
            this.colCD_DESC.FieldName = "CD_DESC";
            this.colCD_DESC.Name = "colCD_DESC";
            this.colCD_DESC.Visible = true;
            this.colCD_DESC.VisibleIndex = 4;
            this.colCD_DESC.Width = 272;
            // 
            // colREG_ID
            // 
            this.colREG_ID.Caption = "등록자ID";
            this.colREG_ID.FieldName = "REG_ID";
            this.colREG_ID.Name = "colREG_ID";
            this.colREG_ID.OptionsColumn.AllowEdit = false;
            this.colREG_ID.OptionsColumn.AllowFocus = false;
            this.colREG_ID.OptionsColumn.FixedWidth = true;
            this.colREG_ID.OptionsColumn.ReadOnly = true;
            this.colREG_ID.Visible = true;
            this.colREG_ID.VisibleIndex = 5;
            this.colREG_ID.Width = 70;
            // 
            // colREG_DTTM
            // 
            this.colREG_DTTM.Caption = "등록일시";
            this.colREG_DTTM.FieldName = "REG_DTTM";
            this.colREG_DTTM.Name = "colREG_DTTM";
            this.colREG_DTTM.OptionsColumn.AllowEdit = false;
            this.colREG_DTTM.OptionsColumn.AllowFocus = false;
            this.colREG_DTTM.OptionsColumn.FixedWidth = true;
            this.colREG_DTTM.OptionsColumn.ReadOnly = true;
            this.colREG_DTTM.Visible = true;
            this.colREG_DTTM.VisibleIndex = 6;
            this.colREG_DTTM.Width = 90;
            // 
            // colUPDT_ID
            // 
            this.colUPDT_ID.Caption = "수정자ID";
            this.colUPDT_ID.FieldName = "UPDT_ID";
            this.colUPDT_ID.Name = "colUPDT_ID";
            this.colUPDT_ID.OptionsColumn.AllowEdit = false;
            this.colUPDT_ID.OptionsColumn.AllowFocus = false;
            this.colUPDT_ID.OptionsColumn.FixedWidth = true;
            this.colUPDT_ID.OptionsColumn.ReadOnly = true;
            this.colUPDT_ID.Visible = true;
            this.colUPDT_ID.VisibleIndex = 7;
            this.colUPDT_ID.Width = 70;
            // 
            // colUPDT_DTTM
            // 
            this.colUPDT_DTTM.Caption = "수정일시";
            this.colUPDT_DTTM.FieldName = "UPDT_DTTM";
            this.colUPDT_DTTM.Name = "colUPDT_DTTM";
            this.colUPDT_DTTM.OptionsColumn.AllowEdit = false;
            this.colUPDT_DTTM.OptionsColumn.AllowFocus = false;
            this.colUPDT_DTTM.OptionsColumn.FixedWidth = true;
            this.colUPDT_DTTM.OptionsColumn.ReadOnly = true;
            this.colUPDT_DTTM.Visible = true;
            this.colUPDT_DTTM.VisibleIndex = 8;
            this.colUPDT_DTTM.Width = 90;
            // 
            // colCRUD
            // 
            this.colCRUD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colCRUD.AppearanceCell.Options.UseBackColor = true;
            this.colCRUD.Caption = "#";
            this.colCRUD.FieldName = "CRUD";
            this.colCRUD.Name = "colCRUD";
            this.colCRUD.OptionsColumn.AllowEdit = false;
            this.colCRUD.OptionsColumn.AllowFocus = false;
            this.colCRUD.OptionsColumn.FixedWidth = true;
            this.colCRUD.OptionsColumn.ReadOnly = true;
            this.colCRUD.Visible = true;
            this.colCRUD.VisibleIndex = 9;
            this.colCRUD.Width = 30;
            // 
            // groupConCommCdDetail
            // 
            this.groupConCommCdDetail.Controls.Add(this.grdConCommCdDetail);
            this.groupConCommCdDetail.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("행추가", null),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("행삭제", null),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("저장", null),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("조회", null)});
            this.groupConCommCdDetail.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupConCommCdDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupConCommCdDetail.Location = new System.Drawing.Point(0, 0);
            this.groupConCommCdDetail.Name = "groupConCommCdDetail";
            this.groupConCommCdDetail.Size = new System.Drawing.Size(1163, 307);
            this.groupConCommCdDetail.TabIndex = 0;
            this.groupConCommCdDetail.Text = "공통코드 상세";
            this.groupConCommCdDetail.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupConCommCdDetail_CustomButtonClick);
            // 
            // grdConCommCdDetail
            // 
            this.grdConCommCdDetail.DataMember = "Query";
            this.grdConCommCdDetail.DataSource = this.sqlDataSource2;
            this.grdConCommCdDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdConCommCdDetail.Location = new System.Drawing.Point(2, 27);
            this.grdConCommCdDetail.MainView = this.gridViewCommCdDetail;
            this.grdConCommCdDetail.Name = "grdConCommCdDetail";
            this.grdConCommCdDetail.Size = new System.Drawing.Size(1159, 278);
            this.grdConCommCdDetail.TabIndex = 0;
            this.grdConCommCdDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCommCdDetail});
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "db.edupool.xyz_dbedupool_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gridViewCommCdDetail
            // 
            this.gridViewCommCdDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGRP_CD1,
            this.colORD_SEQ1,
            this.colCOMM_CD1,
            this.colCOMM_CD_NM1,
            this.colUSE_YN1,
            this.colCD_DESC1,
            this.colREG_ID1,
            this.colREG_DTTM1,
            this.colUPDT_ID1,
            this.colUPDT_DTTM1,
            this.colCRUD1});
            this.gridViewCommCdDetail.GridControl = this.grdConCommCdDetail;
            this.gridViewCommCdDetail.Name = "gridViewCommCdDetail";
            this.gridViewCommCdDetail.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridViewCommCdDetail.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewCommCdDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewCommCdDetail.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewCommCdDetail_InitNewRow);
            this.gridViewCommCdDetail.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewCommCdDetail_ValidateRow);
            this.gridViewCommCdDetail.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewCommCdDetail_RowUpdated);
            this.gridViewCommCdDetail.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewCommCdDetail_ValidatingEditor);
            // 
            // colGRP_CD1
            // 
            this.colGRP_CD1.AppearanceCell.BackColor = System.Drawing.Color.LightYellow;
            this.colGRP_CD1.AppearanceCell.Options.UseBackColor = true;
            this.colGRP_CD1.Caption = "그룹코드";
            this.colGRP_CD1.FieldName = "GRP_CD";
            this.colGRP_CD1.Name = "colGRP_CD1";
            this.colGRP_CD1.OptionsColumn.AllowEdit = false;
            this.colGRP_CD1.OptionsColumn.AllowFocus = false;
            this.colGRP_CD1.OptionsColumn.FixedWidth = true;
            this.colGRP_CD1.OptionsColumn.ReadOnly = true;
            this.colGRP_CD1.Width = 20;
            // 
            // colORD_SEQ1
            // 
            this.colORD_SEQ1.Caption = "Seq";
            this.colORD_SEQ1.FieldName = "ORD_SEQ";
            this.colORD_SEQ1.Name = "colORD_SEQ1";
            this.colORD_SEQ1.OptionsColumn.AllowEdit = false;
            this.colORD_SEQ1.OptionsColumn.AllowFocus = false;
            this.colORD_SEQ1.OptionsColumn.FixedWidth = true;
            this.colORD_SEQ1.OptionsColumn.ReadOnly = true;
            this.colORD_SEQ1.Visible = true;
            this.colORD_SEQ1.VisibleIndex = 0;
            this.colORD_SEQ1.Width = 40;
            // 
            // colCOMM_CD1
            // 
            this.colCOMM_CD1.Caption = "공통코드";
            this.colCOMM_CD1.FieldName = "COMM_CD";
            this.colCOMM_CD1.Name = "colCOMM_CD1";
            this.colCOMM_CD1.OptionsColumn.FixedWidth = true;
            this.colCOMM_CD1.Visible = true;
            this.colCOMM_CD1.VisibleIndex = 1;
            this.colCOMM_CD1.Width = 100;
            // 
            // colCOMM_CD_NM1
            // 
            this.colCOMM_CD_NM1.Caption = "공통코드명";
            this.colCOMM_CD_NM1.FieldName = "COMM_CD_NM";
            this.colCOMM_CD_NM1.Name = "colCOMM_CD_NM1";
            this.colCOMM_CD_NM1.OptionsColumn.FixedWidth = true;
            this.colCOMM_CD_NM1.Visible = true;
            this.colCOMM_CD_NM1.VisibleIndex = 2;
            this.colCOMM_CD_NM1.Width = 150;
            // 
            // colUSE_YN1
            // 
            this.colUSE_YN1.Caption = "사용여부";
            this.colUSE_YN1.FieldName = "USE_YN";
            this.colUSE_YN1.Name = "colUSE_YN1";
            this.colUSE_YN1.OptionsColumn.FixedWidth = true;
            this.colUSE_YN1.Visible = true;
            this.colUSE_YN1.VisibleIndex = 3;
            this.colUSE_YN1.Width = 60;
            // 
            // colCD_DESC1
            // 
            this.colCD_DESC1.Caption = "코드설명";
            this.colCD_DESC1.FieldName = "CD_DESC";
            this.colCD_DESC1.Name = "colCD_DESC1";
            this.colCD_DESC1.Visible = true;
            this.colCD_DESC1.VisibleIndex = 4;
            this.colCD_DESC1.Width = 242;
            // 
            // colREG_ID1
            // 
            this.colREG_ID1.Caption = "등록자ID";
            this.colREG_ID1.FieldName = "REG_ID";
            this.colREG_ID1.Name = "colREG_ID1";
            this.colREG_ID1.OptionsColumn.AllowEdit = false;
            this.colREG_ID1.OptionsColumn.AllowFocus = false;
            this.colREG_ID1.OptionsColumn.FixedWidth = true;
            this.colREG_ID1.OptionsColumn.ReadOnly = true;
            this.colREG_ID1.Visible = true;
            this.colREG_ID1.VisibleIndex = 5;
            this.colREG_ID1.Width = 70;
            // 
            // colREG_DTTM1
            // 
            this.colREG_DTTM1.Caption = "등록일시";
            this.colREG_DTTM1.FieldName = "REG_DTTM";
            this.colREG_DTTM1.Name = "colREG_DTTM1";
            this.colREG_DTTM1.OptionsColumn.AllowEdit = false;
            this.colREG_DTTM1.OptionsColumn.AllowFocus = false;
            this.colREG_DTTM1.OptionsColumn.FixedWidth = true;
            this.colREG_DTTM1.OptionsColumn.ReadOnly = true;
            this.colREG_DTTM1.Visible = true;
            this.colREG_DTTM1.VisibleIndex = 6;
            this.colREG_DTTM1.Width = 90;
            // 
            // colUPDT_ID1
            // 
            this.colUPDT_ID1.Caption = "수정자ID";
            this.colUPDT_ID1.FieldName = "UPDT_ID";
            this.colUPDT_ID1.Name = "colUPDT_ID1";
            this.colUPDT_ID1.OptionsColumn.AllowEdit = false;
            this.colUPDT_ID1.OptionsColumn.AllowFocus = false;
            this.colUPDT_ID1.OptionsColumn.FixedWidth = true;
            this.colUPDT_ID1.OptionsColumn.ReadOnly = true;
            this.colUPDT_ID1.Visible = true;
            this.colUPDT_ID1.VisibleIndex = 7;
            this.colUPDT_ID1.Width = 70;
            // 
            // colUPDT_DTTM1
            // 
            this.colUPDT_DTTM1.Caption = "수정일시";
            this.colUPDT_DTTM1.FieldName = "UPDT_DTTM";
            this.colUPDT_DTTM1.Name = "colUPDT_DTTM1";
            this.colUPDT_DTTM1.OptionsColumn.AllowEdit = false;
            this.colUPDT_DTTM1.OptionsColumn.AllowFocus = false;
            this.colUPDT_DTTM1.OptionsColumn.FixedWidth = true;
            this.colUPDT_DTTM1.OptionsColumn.ReadOnly = true;
            this.colUPDT_DTTM1.Visible = true;
            this.colUPDT_DTTM1.VisibleIndex = 8;
            this.colUPDT_DTTM1.Width = 90;
            // 
            // colCRUD1
            // 
            this.colCRUD1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colCRUD1.AppearanceCell.Options.UseBackColor = true;
            this.colCRUD1.Caption = "#";
            this.colCRUD1.FieldName = "CRUD";
            this.colCRUD1.Name = "colCRUD1";
            this.colCRUD1.OptionsColumn.AllowEdit = false;
            this.colCRUD1.OptionsColumn.AllowFocus = false;
            this.colCRUD1.OptionsColumn.FixedWidth = true;
            this.colCRUD1.OptionsColumn.ReadOnly = true;
            this.colCRUD1.Visible = true;
            this.colCRUD1.VisibleIndex = 9;
            this.colCRUD1.Width = 30;
            // 
            // adminCommCdRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 577);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "adminCommCdRegForm";
            this.Text = "공유코드 관리";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupConCommCdMaster)).EndInit();
            this.groupConCommCdMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConCommCdMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommCdMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupConCommCdDetail)).EndInit();
            this.groupConCommCdDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConCommCdDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCommCdDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupConCommCdMaster;
        private DevExpress.XtraEditors.GroupControl groupConCommCdDetail;
        private DevExpress.XtraGrid.GridControl grdConCommCdDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCommCdDetail;
        private DevExpress.XtraGrid.GridControl grdConCommCdMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCommCdMaster;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colGRP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMM_CD_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colORD_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colUSE_YN;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colREG_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colREG_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDT_DTTM;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.Columns.GridColumn colGRP_CD1;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMM_CD1;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMM_CD_NM1;
        private DevExpress.XtraGrid.Columns.GridColumn colORD_SEQ1;
        private DevExpress.XtraGrid.Columns.GridColumn colUSE_YN1;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_DESC1;
        private DevExpress.XtraGrid.Columns.GridColumn colREG_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colREG_DTTM1;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDT_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDT_DTTM1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colCRUD;
        private DevExpress.XtraGrid.Columns.GridColumn colCRUD1;
    }
}