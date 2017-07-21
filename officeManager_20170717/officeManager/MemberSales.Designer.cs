namespace officeManager
{
    partial class MemberSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberSalesForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonQuery = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBRCH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALES_PSN_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALES_PSN_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALES_DEPT_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENTCMPY_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colCELL_PHON_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWRK_STS_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colRR_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZIP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDR1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colADDR2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRUD = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.simpleButtonQuery);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1163, 37);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 14);
            this.labelControl1.TabIndex = 4;
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("행추가", null),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("행삭제", null),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("저장", null)});
            this.groupControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 37);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1163, 540);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl1_CustomButtonClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemDateEdit1,
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1159, 511);
            this.gridControl1.TabIndex = 0;
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
            this.colBRCH_CD,
            this.colSALES_PSN_NO,
            this.colSALES_PSN_NM,
            this.colSALES_DEPT_NM,
            this.colENTCMPY_DT,
            this.colCELL_PHON_NO,
            this.colWRK_STS_CD,
            this.colRR_NO,
            this.colZIP_NO,
            this.colADDR1,
            this.colADDR2,
            this.colCRUD});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
            // 
            // colBRCH_CD
            // 
            this.colBRCH_CD.Caption = "지사코드";
            this.colBRCH_CD.FieldName = "BRCH_CD";
            this.colBRCH_CD.Name = "colBRCH_CD";
            this.colBRCH_CD.OptionsColumn.AllowEdit = false;
            this.colBRCH_CD.OptionsColumn.AllowFocus = false;
            this.colBRCH_CD.OptionsColumn.ReadOnly = true;
            // 
            // colSALES_PSN_NO
            // 
            this.colSALES_PSN_NO.Caption = "영업자번호";
            this.colSALES_PSN_NO.FieldName = "SALES_PSN_NO";
            this.colSALES_PSN_NO.Name = "colSALES_PSN_NO";
            this.colSALES_PSN_NO.OptionsColumn.AllowEdit = false;
            this.colSALES_PSN_NO.OptionsColumn.AllowFocus = false;
            this.colSALES_PSN_NO.OptionsColumn.ReadOnly = true;
            this.colSALES_PSN_NO.Visible = true;
            this.colSALES_PSN_NO.VisibleIndex = 0;
            this.colSALES_PSN_NO.Width = 87;
            // 
            // colSALES_PSN_NM
            // 
            this.colSALES_PSN_NM.Caption = "영업자명";
            this.colSALES_PSN_NM.FieldName = "SALES_PSN_NM";
            this.colSALES_PSN_NM.Name = "colSALES_PSN_NM";
            this.colSALES_PSN_NM.Visible = true;
            this.colSALES_PSN_NM.VisibleIndex = 1;
            this.colSALES_PSN_NM.Width = 87;
            // 
            // colSALES_DEPT_NM
            // 
            this.colSALES_DEPT_NM.Caption = "영업부서명";
            this.colSALES_DEPT_NM.FieldName = "SALES_DEPT_NM";
            this.colSALES_DEPT_NM.Name = "colSALES_DEPT_NM";
            this.colSALES_DEPT_NM.Visible = true;
            this.colSALES_DEPT_NM.VisibleIndex = 2;
            this.colSALES_DEPT_NM.Width = 87;
            // 
            // colENTCMPY_DT
            // 
            this.colENTCMPY_DT.Caption = "입사일자";
            this.colENTCMPY_DT.ColumnEdit = this.repositoryItemDateEdit1;
            this.colENTCMPY_DT.FieldName = "ENTCMPY_DT";
            this.colENTCMPY_DT.Name = "colENTCMPY_DT";
            this.colENTCMPY_DT.Visible = true;
            this.colENTCMPY_DT.VisibleIndex = 3;
            this.colENTCMPY_DT.Width = 87;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colCELL_PHON_NO
            // 
            this.colCELL_PHON_NO.Caption = "핸드폰번호";
            this.colCELL_PHON_NO.FieldName = "CELL_PHON_NO";
            this.colCELL_PHON_NO.Name = "colCELL_PHON_NO";
            this.colCELL_PHON_NO.Visible = true;
            this.colCELL_PHON_NO.VisibleIndex = 4;
            this.colCELL_PHON_NO.Width = 87;
            // 
            // colWRK_STS_CD
            // 
            this.colWRK_STS_CD.Caption = "근무상태코드";
            this.colWRK_STS_CD.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colWRK_STS_CD.FieldName = "WRK_STS_CD";
            this.colWRK_STS_CD.Name = "colWRK_STS_CD";
            this.colWRK_STS_CD.Visible = true;
            this.colWRK_STS_CD.VisibleIndex = 5;
            this.colWRK_STS_CD.Width = 87;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("재직", "01", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("휴직", "02", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("퇴사", "09", -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colRR_NO
            // 
            this.colRR_NO.Caption = "주민번호";
            this.colRR_NO.FieldName = "RR_NO";
            this.colRR_NO.Name = "colRR_NO";
            this.colRR_NO.Visible = true;
            this.colRR_NO.VisibleIndex = 6;
            this.colRR_NO.Width = 87;
            // 
            // colZIP_NO
            // 
            this.colZIP_NO.Caption = "우편번호";
            this.colZIP_NO.FieldName = "ZIP_NO";
            this.colZIP_NO.Name = "colZIP_NO";
            this.colZIP_NO.Width = 87;
            // 
            // colADDR1
            // 
            this.colADDR1.Caption = "기본주소";
            this.colADDR1.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colADDR1.FieldName = "ADDR1";
            this.colADDR1.Name = "colADDR1";
            this.colADDR1.Visible = true;
            this.colADDR1.VisibleIndex = 7;
            this.colADDR1.Width = 87;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit_ButtonClick);
            // 
            // colADDR2
            // 
            this.colADDR2.Caption = "상세주소";
            this.colADDR2.FieldName = "ADDR2";
            this.colADDR2.Name = "colADDR2";
            this.colADDR2.Visible = true;
            this.colADDR2.VisibleIndex = 8;
            this.colADDR2.Width = 87;
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
            this.colCRUD.OptionsColumn.ReadOnly = true;
            this.colCRUD.Visible = true;
            this.colCRUD.VisibleIndex = 9;
            this.colCRUD.Width = 30;
            // 
            // MemberSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 577);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "MemberSalesForm";
            this.Text = "업무자 관리";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonQuery;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colBRCH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colSALES_PSN_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colSALES_PSN_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colSALES_DEPT_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colENTCMPY_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCELL_PHON_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colWRK_STS_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colRR_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colZIP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colADDR1;
        private DevExpress.XtraGrid.Columns.GridColumn colADDR2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colCRUD;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}