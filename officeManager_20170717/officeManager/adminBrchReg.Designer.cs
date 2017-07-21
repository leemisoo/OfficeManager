namespace officeManager
{
    partial class adminBrchRegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminBrchRegForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ComboBoxAREA_CD = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ComboBoxBRCH_FG = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.simpleButtonQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridConBrchInfo = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewBrchInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBRCH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRCH_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRCH_FG_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colAREA_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colZIP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDR1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colADDR2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHON_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAX_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIZ_REG_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREPR_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREG_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREG_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDT_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRUD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpConBrchInfo = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxAREA_CD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxBRCH_FG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConBrchInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrchInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpConBrchInfo)).BeginInit();
            this.grpConBrchInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ComboBoxAREA_CD);
            this.panelControl1.Controls.Add(this.ComboBoxBRCH_FG);
            this.panelControl1.Controls.Add(this.simpleButtonQuery);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1163, 37);
            this.panelControl1.TabIndex = 0;
            // 
            // ComboBoxAREA_CD
            // 
            this.ComboBoxAREA_CD.Location = new System.Drawing.Point(236, 8);
            this.ComboBoxAREA_CD.Name = "ComboBoxAREA_CD";
            this.ComboBoxAREA_CD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxAREA_CD.Properties.DropDownRows = 10;
            this.ComboBoxAREA_CD.Size = new System.Drawing.Size(100, 20);
            this.ComboBoxAREA_CD.TabIndex = 2;
            // 
            // ComboBoxBRCH_FG
            // 
            this.ComboBoxBRCH_FG.Location = new System.Drawing.Point(66, 8);
            this.ComboBoxBRCH_FG.Name = "ComboBoxBRCH_FG";
            this.ComboBoxBRCH_FG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxBRCH_FG.Properties.DropDownRows = 10;
            this.ComboBoxBRCH_FG.Size = new System.Drawing.Size(100, 20);
            this.ComboBoxBRCH_FG.TabIndex = 1;
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
            this.simpleButtonQuery.Click += new System.EventHandler(this.simpleButtonQuery_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(182, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "지역코드";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "지사구분";
            // 
            // gridConBrchInfo
            // 
            this.gridConBrchInfo.DataMember = "Query";
            this.gridConBrchInfo.DataSource = this.sqlDataSource1;
            this.gridConBrchInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConBrchInfo.Location = new System.Drawing.Point(2, 27);
            this.gridConBrchInfo.MainView = this.gridViewBrchInfo;
            this.gridConBrchInfo.Name = "gridConBrchInfo";
            this.gridConBrchInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemButtonEdit1});
            this.gridConBrchInfo.Size = new System.Drawing.Size(1159, 511);
            this.gridConBrchInfo.TabIndex = 1;
            this.gridConBrchInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBrchInfo});
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
            // gridViewBrchInfo
            // 
            this.gridViewBrchInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBRCH_CD,
            this.colBRCH_NM,
            this.colBRCH_FG_CD,
            this.colAREA_CD,
            this.colZIP_NO,
            this.colADDR1,
            this.colADDR2,
            this.colPHON_NO,
            this.colFAX_NO,
            this.colBIZ_REG_NO,
            this.colREPR_NM,
            this.colREG_ID,
            this.colREG_DTTM,
            this.colUPDT_ID,
            this.colUPDT_DTTM,
            this.colCRUD});
            this.gridViewBrchInfo.GridControl = this.gridConBrchInfo;
            this.gridViewBrchInfo.Name = "gridViewBrchInfo";
            this.gridViewBrchInfo.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridViewBrchInfo.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewBrchInfo.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewBrchInfo.OptionsView.ShowGroupPanel = false;
            this.gridViewBrchInfo.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewBrchInfo_InitNewRow);
            this.gridViewBrchInfo.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewBrchInfo_ValidateRow);
            this.gridViewBrchInfo.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewBrchInfo_RowUpdated);
            this.gridViewBrchInfo.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewBrchInfo_ValidatingEditor);
            // 
            // colBRCH_CD
            // 
            this.colBRCH_CD.Caption = "지사코드";
            this.colBRCH_CD.FieldName = "BRCH_CD";
            this.colBRCH_CD.Name = "colBRCH_CD";
            this.colBRCH_CD.Visible = true;
            this.colBRCH_CD.VisibleIndex = 0;
            this.colBRCH_CD.Width = 55;
            // 
            // colBRCH_NM
            // 
            this.colBRCH_NM.Caption = "지사명";
            this.colBRCH_NM.FieldName = "BRCH_NM";
            this.colBRCH_NM.Name = "colBRCH_NM";
            this.colBRCH_NM.Visible = true;
            this.colBRCH_NM.VisibleIndex = 1;
            this.colBRCH_NM.Width = 83;
            // 
            // colBRCH_FG_CD
            // 
            this.colBRCH_FG_CD.Caption = "지사구분코드";
            this.colBRCH_FG_CD.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colBRCH_FG_CD.FieldName = "BRCH_FG_CD";
            this.colBRCH_FG_CD.Name = "colBRCH_FG_CD";
            this.colBRCH_FG_CD.Visible = true;
            this.colBRCH_FG_CD.VisibleIndex = 2;
            this.colBRCH_FG_CD.Width = 76;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("본사", "1", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("학습지지사", "2", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("어린이집지사", "3", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("해외지사", "4", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("지점", "5", -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colAREA_CD
            // 
            this.colAREA_CD.Caption = "지역코드";
            this.colAREA_CD.ColumnEdit = this.repositoryItemImageComboBox2;
            this.colAREA_CD.FieldName = "AREA_CD";
            this.colAREA_CD.Name = "colAREA_CD";
            this.colAREA_CD.Visible = true;
            this.colAREA_CD.VisibleIndex = 3;
            this.colAREA_CD.Width = 61;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("본사", "1", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("서울", "2", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("경기", "3", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("충청", "4", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("강원", "5", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("영남", "6", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("호남", "7", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("기타", "8", -1)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // colZIP_NO
            // 
            this.colZIP_NO.Caption = "우편번호";
            this.colZIP_NO.FieldName = "ZIP_NO";
            this.colZIP_NO.Name = "colZIP_NO";
            this.colZIP_NO.Width = 52;
            // 
            // colADDR1
            // 
            this.colADDR1.Caption = "주소1";
            this.colADDR1.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colADDR1.FieldName = "ADDR1";
            this.colADDR1.Name = "colADDR1";
            this.colADDR1.Visible = true;
            this.colADDR1.VisibleIndex = 4;
            this.colADDR1.Width = 154;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "postSearch", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit_ButtonClick);
            // 
            // colADDR2
            // 
            this.colADDR2.Caption = "주소2";
            this.colADDR2.FieldName = "ADDR2";
            this.colADDR2.Name = "colADDR2";
            this.colADDR2.Visible = true;
            this.colADDR2.VisibleIndex = 5;
            this.colADDR2.Width = 167;
            // 
            // colPHON_NO
            // 
            this.colPHON_NO.Caption = "전화번호";
            this.colPHON_NO.FieldName = "PHON_NO";
            this.colPHON_NO.Name = "colPHON_NO";
            this.colPHON_NO.Visible = true;
            this.colPHON_NO.VisibleIndex = 6;
            this.colPHON_NO.Width = 51;
            // 
            // colFAX_NO
            // 
            this.colFAX_NO.Caption = "팩스번호";
            this.colFAX_NO.FieldName = "FAX_NO";
            this.colFAX_NO.Name = "colFAX_NO";
            this.colFAX_NO.Visible = true;
            this.colFAX_NO.VisibleIndex = 7;
            this.colFAX_NO.Width = 51;
            // 
            // colBIZ_REG_NO
            // 
            this.colBIZ_REG_NO.Caption = "사업자등록번호";
            this.colBIZ_REG_NO.FieldName = "BIZ_REG_NO";
            this.colBIZ_REG_NO.Name = "colBIZ_REG_NO";
            this.colBIZ_REG_NO.Visible = true;
            this.colBIZ_REG_NO.VisibleIndex = 8;
            this.colBIZ_REG_NO.Width = 64;
            // 
            // colREPR_NM
            // 
            this.colREPR_NM.Caption = "대표자명";
            this.colREPR_NM.FieldName = "REPR_NM";
            this.colREPR_NM.Name = "colREPR_NM";
            this.colREPR_NM.Visible = true;
            this.colREPR_NM.VisibleIndex = 9;
            this.colREPR_NM.Width = 77;
            // 
            // colREG_ID
            // 
            this.colREG_ID.Caption = "등록자ID";
            this.colREG_ID.FieldName = "REG_ID";
            this.colREG_ID.Name = "colREG_ID";
            this.colREG_ID.OptionsColumn.AllowEdit = false;
            this.colREG_ID.OptionsColumn.AllowFocus = false;
            this.colREG_ID.OptionsColumn.ReadOnly = true;
            // 
            // colREG_DTTM
            // 
            this.colREG_DTTM.Caption = "등록일시";
            this.colREG_DTTM.FieldName = "REG_DTTM";
            this.colREG_DTTM.Name = "colREG_DTTM";
            this.colREG_DTTM.OptionsColumn.AllowEdit = false;
            this.colREG_DTTM.OptionsColumn.AllowFocus = false;
            this.colREG_DTTM.OptionsColumn.ReadOnly = true;
            // 
            // colUPDT_ID
            // 
            this.colUPDT_ID.Caption = "수정자ID";
            this.colUPDT_ID.FieldName = "UPDT_ID";
            this.colUPDT_ID.Name = "colUPDT_ID";
            this.colUPDT_ID.OptionsColumn.AllowEdit = false;
            this.colUPDT_ID.OptionsColumn.AllowFocus = false;
            this.colUPDT_ID.OptionsColumn.ReadOnly = true;
            // 
            // colUPDT_DTTM
            // 
            this.colUPDT_DTTM.Caption = "수정일시";
            this.colUPDT_DTTM.FieldName = "UPDT_DTTM";
            this.colUPDT_DTTM.Name = "colUPDT_DTTM";
            this.colUPDT_DTTM.OptionsColumn.AllowEdit = false;
            this.colUPDT_DTTM.OptionsColumn.AllowFocus = false;
            this.colUPDT_DTTM.OptionsColumn.ReadOnly = true;
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
            this.colCRUD.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colCRUD.Visible = true;
            this.colCRUD.VisibleIndex = 10;
            this.colCRUD.Width = 30;
            // 
            // grpConBrchInfo
            // 
            this.grpConBrchInfo.Controls.Add(this.gridConBrchInfo);
            this.grpConBrchInfo.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("행추가", null),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("행삭제", null),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("저장", null)});
            this.grpConBrchInfo.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grpConBrchInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConBrchInfo.Location = new System.Drawing.Point(0, 37);
            this.grpConBrchInfo.Name = "grpConBrchInfo";
            this.grpConBrchInfo.Size = new System.Drawing.Size(1163, 540);
            this.grpConBrchInfo.TabIndex = 2;
            this.grpConBrchInfo.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.grpConBrchInfo_CustomButtonClick);
            // 
            // adminBrchRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 577);
            this.Controls.Add(this.grpConBrchInfo);
            this.Controls.Add(this.panelControl1);
            this.Name = "adminBrchRegForm";
            this.Text = "지점 관리";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxAREA_CD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxBRCH_FG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConBrchInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrchInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpConBrchInfo)).EndInit();
            this.grpConBrchInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridConBrchInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBrchInfo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonQuery;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colBRCH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colBRCH_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colBRCH_FG_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colAREA_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colZIP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colADDR1;
        private DevExpress.XtraGrid.Columns.GridColumn colADDR2;
        private DevExpress.XtraGrid.Columns.GridColumn colPHON_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colFAX_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colBIZ_REG_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colREPR_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colREG_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colREG_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDT_DTTM;
        private DevExpress.XtraEditors.ImageComboBoxEdit ComboBoxBRCH_FG;
        private DevExpress.XtraEditors.ImageComboBoxEdit ComboBoxAREA_CD;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colCRUD;
        private DevExpress.XtraEditors.GroupControl grpConBrchInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}