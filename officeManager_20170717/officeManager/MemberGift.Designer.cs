namespace officeManager
{
    partial class MemberGiftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberGiftForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ComboBoxGIFT_FG = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.simpleButtonQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBRCH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIFT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIFT_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIFT_PRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCK_AMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIFT_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colUSE_STR_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colUSE_END_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRUD = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGIFT_FG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ComboBoxGIFT_FG);
            this.panelControl1.Controls.Add(this.simpleButtonQuery);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1163, 37);
            this.panelControl1.TabIndex = 1;
            // 
            // ComboBoxGIFT_FG
            // 
            this.ComboBoxGIFT_FG.Location = new System.Drawing.Point(78, 8);
            this.ComboBoxGIFT_FG.Name = "ComboBoxGIFT_FG";
            this.ComboBoxGIFT_FG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGIFT_FG.Properties.DropDownRows = 10;
            this.ComboBoxGIFT_FG.Size = new System.Drawing.Size(100, 20);
            this.ComboBoxGIFT_FG.TabIndex = 4;
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "사은품구분";
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
            this.groupControl1.TabIndex = 2;
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
            this.repositoryItemDateEdit1});
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
            this.colGIFT_CD,
            this.colGIFT_NM,
            this.colGIFT_PRC,
            this.colSTOCK_AMT,
            this.colGIFT_FG,
            this.colUSE_STR_DT,
            this.colUSE_END_DT,
            this.colCRUD});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colBRCH_CD
            // 
            this.colBRCH_CD.Caption = "지사코드";
            this.colBRCH_CD.FieldName = "BRCH_CD";
            this.colBRCH_CD.Name = "colBRCH_CD";
            this.colBRCH_CD.OptionsColumn.AllowEdit = false;
            this.colBRCH_CD.OptionsColumn.AllowFocus = false;
            this.colBRCH_CD.OptionsColumn.ReadOnly = true;
            this.colBRCH_CD.Width = 118;
            // 
            // colGIFT_CD
            // 
            this.colGIFT_CD.Caption = "사은품코드";
            this.colGIFT_CD.FieldName = "GIFT_CD";
            this.colGIFT_CD.Name = "colGIFT_CD";
            this.colGIFT_CD.OptionsColumn.AllowEdit = false;
            this.colGIFT_CD.OptionsColumn.AllowFocus = false;
            this.colGIFT_CD.OptionsColumn.ReadOnly = true;
            this.colGIFT_CD.Visible = true;
            this.colGIFT_CD.VisibleIndex = 0;
            this.colGIFT_CD.Width = 118;
            // 
            // colGIFT_NM
            // 
            this.colGIFT_NM.Caption = "사은품명";
            this.colGIFT_NM.FieldName = "GIFT_NM";
            this.colGIFT_NM.Name = "colGIFT_NM";
            this.colGIFT_NM.Visible = true;
            this.colGIFT_NM.VisibleIndex = 1;
            this.colGIFT_NM.Width = 118;
            // 
            // colGIFT_PRC
            // 
            this.colGIFT_PRC.Caption = "사은품가격";
            this.colGIFT_PRC.FieldName = "GIFT_PRC";
            this.colGIFT_PRC.Name = "colGIFT_PRC";
            this.colGIFT_PRC.Visible = true;
            this.colGIFT_PRC.VisibleIndex = 2;
            this.colGIFT_PRC.Width = 118;
            // 
            // colSTOCK_AMT
            // 
            this.colSTOCK_AMT.Caption = "입고가격";
            this.colSTOCK_AMT.FieldName = "STOCK_AMT";
            this.colSTOCK_AMT.Name = "colSTOCK_AMT";
            this.colSTOCK_AMT.Visible = true;
            this.colSTOCK_AMT.VisibleIndex = 3;
            // 
            // colGIFT_FG
            // 
            this.colGIFT_FG.Caption = "사은품구분";
            this.colGIFT_FG.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colGIFT_FG.FieldName = "GIFT_FG";
            this.colGIFT_FG.Name = "colGIFT_FG";
            this.colGIFT_FG.Visible = true;
            this.colGIFT_FG.VisibleIndex = 4;
            this.colGIFT_FG.Width = 118;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("전집", "01", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("완구", "02", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("교구", "03", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("기타", "09", -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colUSE_STR_DT
            // 
            this.colUSE_STR_DT.Caption = "사용시작일자";
            this.colUSE_STR_DT.ColumnEdit = this.repositoryItemDateEdit1;
            this.colUSE_STR_DT.FieldName = "USE_STR_DT";
            this.colUSE_STR_DT.Name = "colUSE_STR_DT";
            this.colUSE_STR_DT.Visible = true;
            this.colUSE_STR_DT.VisibleIndex = 5;
            this.colUSE_STR_DT.Width = 118;
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
            // colUSE_END_DT
            // 
            this.colUSE_END_DT.Caption = "사용종료일자";
            this.colUSE_END_DT.ColumnEdit = this.repositoryItemDateEdit1;
            this.colUSE_END_DT.FieldName = "USE_END_DT";
            this.colUSE_END_DT.Name = "colUSE_END_DT";
            this.colUSE_END_DT.Visible = true;
            this.colUSE_END_DT.VisibleIndex = 6;
            this.colUSE_END_DT.Width = 118;
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
            this.colCRUD.VisibleIndex = 7;
            this.colCRUD.Width = 30;
            // 
            // MemberGiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 577);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "MemberGiftForm";
            this.Text = "상품 관리";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGIFT_FG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonQuery;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit ComboBoxGIFT_FG;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colBRCH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGIFT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGIFT_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colGIFT_PRC;
        private DevExpress.XtraGrid.Columns.GridColumn colGIFT_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colUSE_STR_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colUSE_END_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCRUD;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCK_AMT;
    }
}