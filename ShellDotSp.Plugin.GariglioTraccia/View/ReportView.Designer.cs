namespace ShellDotSp.Plugin.GariglioTraccia.View
{
    partial class ReportView
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEsporta = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditAl = new DevExpress.XtraEditors.DateEdit();
            this.dateEditDal = new DevExpress.XtraEditors.DateEdit();
            this.cmbReport = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnStampa = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.bndPivot = new System.Windows.Forms.BindingSource(this.components);
            this.fieldTipoDescrizione1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDataDocumento1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNumero1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIdAnagrafica1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRagioneSociale1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIdArticolo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDescrizioneArticolo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUm1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQta1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReport.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndPivot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEsporta);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.dateEditAl);
            this.panel1.Controls.Add(this.dateEditDal);
            this.panel1.Controls.Add(this.cmbReport);
            this.panel1.Controls.Add(this.btnStampa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 156);
            this.panel1.TabIndex = 2;
            // 
            // btnEsporta
            // 
            this.btnEsporta.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEsporta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnEsporta.ImageOptions.SvgImageSize = new System.Drawing.Size(64, 64);
            this.btnEsporta.Location = new System.Drawing.Point(642, 25);
            this.btnEsporta.Name = "btnEsporta";
            this.btnEsporta.Size = new System.Drawing.Size(107, 109);
            this.btnEsporta.TabIndex = 37;
            this.btnEsporta.Click += new System.EventHandler(this.btnEsporta_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(282, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(15, 21);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "Al";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 21);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Dal";
            // 
            // dateEditAl
            // 
            this.dateEditAl.EditValue = null;
            this.dateEditAl.Location = new System.Drawing.Point(282, 99);
            this.dateEditAl.Name = "dateEditAl";
            this.dateEditAl.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditAl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditAl.Properties.Appearance.Options.UseFont = true;
            this.dateEditAl.Properties.Appearance.Options.UseTextOptions = true;
            this.dateEditAl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateEditAl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAl.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAl.Size = new System.Drawing.Size(241, 34);
            this.dateEditAl.TabIndex = 34;
            this.dateEditAl.EditValueChanged += new System.EventHandler(this.dateEditAl_EditValueChanged);
            // 
            // dateEditDal
            // 
            this.dateEditDal.EditValue = null;
            this.dateEditDal.Location = new System.Drawing.Point(25, 99);
            this.dateEditDal.Name = "dateEditDal";
            this.dateEditDal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditDal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditDal.Properties.Appearance.Options.UseFont = true;
            this.dateEditDal.Properties.Appearance.Options.UseTextOptions = true;
            this.dateEditDal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateEditDal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDal.Size = new System.Drawing.Size(241, 34);
            this.dateEditDal.TabIndex = 33;
            this.dateEditDal.EditValueChanged += new System.EventHandler(this.dateEditDal_EditValueChanged);
            // 
            // cmbReport
            // 
            this.cmbReport.Location = new System.Drawing.Point(25, 27);
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReport.Properties.Appearance.Options.UseFont = true;
            this.cmbReport.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReport.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbReport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbReport.Properties.Items.AddRange(new object[] {
            "REPORT - MATERIE PRIME",
            "REPORT - VENDITE",
            "REPORT - ELENCO IRRIGAZIONI",
            "REPORT - REGISTRO SEMINE",
            "REPORT - REGISTRO CARICO TANICHE",
            "REPORT - QUADERNO DI CAMPAGNA",
            "REPORT - GIACENZE PERIODO",
            "REPORT - BILANCIO MASSA",
            "REPORT - REGISTRO UTILIZZO TORBA",
            "STATISTICA - VENDITE"});
            this.cmbReport.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbReport.Size = new System.Drawing.Size(498, 34);
            this.cmbReport.TabIndex = 32;
            this.cmbReport.SelectedIndexChanged += new System.EventHandler(this.cmbReport_SelectedIndexChanged);
            // 
            // btnStampa
            // 
            this.btnStampa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnStampa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStampa.ImageOptions.SvgImage")));
            this.btnStampa.ImageOptions.SvgImageSize = new System.Drawing.Size(64, 64);
            this.btnStampa.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnStampa.Location = new System.Drawing.Point(529, 24);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(107, 109);
            this.btnStampa.TabIndex = 31;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 642);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 31);
            this.panel3.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(227, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Report";
            // 
            // tabPane1
            // 
            this.tabPane1.AppearanceButton.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.AppearanceButton.Hovered.Options.UseFont = true;
            this.tabPane1.AppearanceButton.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.AppearanceButton.Normal.Options.UseFont = true;
            this.tabPane1.AppearanceButton.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.AppearanceButton.Pressed.Options.UseFont = true;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(10, 166);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(1003, 476);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1003, 476);
            this.tabPane1.TabIndex = 9;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Pivot Vendita";
            this.tabNavigationPage1.Controls.Add(this.pivotGridControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1003, 435);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.bndPivot;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldTipoDescrizione1,
            this.fieldDataDocumento1,
            this.fieldNumero1,
            this.fieldIdAnagrafica1,
            this.fieldRagioneSociale1,
            this.fieldIdArticolo1,
            this.fieldDescrizioneArticolo1,
            this.fieldUm1,
            this.fieldQta1,
            this.pivotGridField1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(1003, 435);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // bndPivot
            // 
            this.bndPivot.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.VStatsPivotVenditaCollection);
            // 
            // fieldTipoDescrizione1
            // 
            this.fieldTipoDescrizione1.AreaIndex = 0;
            this.fieldTipoDescrizione1.Caption = "Tipo Descrizione";
            this.fieldTipoDescrizione1.FieldName = "TipoDescrizione";
            this.fieldTipoDescrizione1.Name = "fieldTipoDescrizione1";
            // 
            // fieldDataDocumento1
            // 
            this.fieldDataDocumento1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldDataDocumento1.AreaIndex = 1;
            this.fieldDataDocumento1.Caption = "DataDocumento";
            this.fieldDataDocumento1.FieldName = "DataDocumento";
            this.fieldDataDocumento1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldDataDocumento1.Name = "fieldDataDocumento1";
            this.fieldDataDocumento1.UnboundFieldName = "fieldDataDocumento1";
            // 
            // fieldNumero1
            // 
            this.fieldNumero1.AreaIndex = 1;
            this.fieldNumero1.Caption = "Numero";
            this.fieldNumero1.FieldName = "Numero";
            this.fieldNumero1.Name = "fieldNumero1";
            // 
            // fieldIdAnagrafica1
            // 
            this.fieldIdAnagrafica1.AreaIndex = 2;
            this.fieldIdAnagrafica1.Caption = "Id Anagrafica";
            this.fieldIdAnagrafica1.FieldName = "IdAnagrafica";
            this.fieldIdAnagrafica1.Name = "fieldIdAnagrafica1";
            this.fieldIdAnagrafica1.Visible = false;
            // 
            // fieldRagioneSociale1
            // 
            this.fieldRagioneSociale1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldRagioneSociale1.AreaIndex = 0;
            this.fieldRagioneSociale1.Caption = "Ragione Sociale";
            this.fieldRagioneSociale1.FieldName = "RagioneSociale";
            this.fieldRagioneSociale1.Name = "fieldRagioneSociale1";
            this.fieldRagioneSociale1.Width = 173;
            // 
            // fieldIdArticolo1
            // 
            this.fieldIdArticolo1.AreaIndex = 2;
            this.fieldIdArticolo1.Caption = "Id Articolo";
            this.fieldIdArticolo1.FieldName = "IdArticolo";
            this.fieldIdArticolo1.Name = "fieldIdArticolo1";
            this.fieldIdArticolo1.Visible = false;
            // 
            // fieldDescrizioneArticolo1
            // 
            this.fieldDescrizioneArticolo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDescrizioneArticolo1.AreaIndex = 1;
            this.fieldDescrizioneArticolo1.Caption = "Descrizione Articolo";
            this.fieldDescrizioneArticolo1.FieldName = "DescrizioneArticolo";
            this.fieldDescrizioneArticolo1.Name = "fieldDescrizioneArticolo1";
            // 
            // fieldUm1
            // 
            this.fieldUm1.AreaIndex = 2;
            this.fieldUm1.Caption = "Um";
            this.fieldUm1.FieldName = "Um";
            this.fieldUm1.Name = "fieldUm1";
            // 
            // fieldQta1
            // 
            this.fieldQta1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQta1.AreaIndex = 0;
            this.fieldQta1.Caption = "Qta";
            this.fieldQta1.CellFormat.FormatString = "n0";
            this.fieldQta1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQta1.FieldName = "Qta";
            this.fieldQta1.Name = "fieldQta1";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Anno";
            this.pivotGridField1.FieldName = "DataDocumento";
            this.pivotGridField1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.UnboundFieldName = "pivotGridField1";
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ReportView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1023, 683);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReport.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndPivot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnStampa;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbReport;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEditAl;
        private DevExpress.XtraEditors.DateEdit dateEditDal;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource bndPivot;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTipoDescrizione1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDataDocumento1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNumero1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIdAnagrafica1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRagioneSociale1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIdArticolo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDescrizioneArticolo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUm1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQta1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraEditors.SimpleButton btnEsporta;
    }
}
