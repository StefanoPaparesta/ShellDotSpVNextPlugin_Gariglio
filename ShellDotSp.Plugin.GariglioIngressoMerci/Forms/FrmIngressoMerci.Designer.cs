namespace ShellDotSp.Plugin.GariglioIngressoMerci.Forms
    {
    partial class FrmIngressoMerci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngressoMerci));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabPageHome = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.lkCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.bndFornitori = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txNumeroDocumento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataDocumento = new DevExpress.XtraEditors.DateEdit();
            this.tabPageArticoli = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txPrezzoAcquisto = new DevExpress.XtraEditors.TextEdit();
            this.txLotto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bndRighe = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdArticolo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkArticoliGrid = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bndArticoli = new System.Windows.Forms.BindingSource(this.components);
            this.colUm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkLavorazioneGrid = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.txQta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancellaArticolo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAggiungiArticolo = new DevExpress.XtraEditors.SimpleButton();
            this.lblUM = new DevExpress.XtraEditors.LabelControl();
            this.lkArticoli = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndFornitori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txNumeroDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDocumento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDocumento.Properties)).BeginInit();
            this.tabPageArticoli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txPrezzoAcquisto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txLotto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndRighe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkArticoliGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndArticoli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLavorazioneGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txQta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkArticoli.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.AppearanceButton.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.AppearanceButton.Hovered.Options.UseFont = true;
            this.tabPane1.AppearanceButton.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.AppearanceButton.Normal.Options.UseFont = true;
            this.tabPane1.AppearanceButton.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.AppearanceButton.Pressed.Options.UseFont = true;
            this.tabPane1.Controls.Add(this.tabPageHome);
            this.tabPane1.Controls.Add(this.tabPageArticoli);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabPageHome,
            this.tabPageArticoli});
            this.tabPane1.RegularSize = new System.Drawing.Size(690, 475);
            this.tabPane1.SelectedPage = this.tabPageHome;
            this.tabPane1.Size = new System.Drawing.Size(690, 475);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "Dati generali";
            this.tabPane1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPane1_SelectedPageChanged);
            // 
            // tabPageHome
            // 
            this.tabPageHome.Caption = "Dati generali";
            this.tabPageHome.Controls.Add(this.lkCliente);
            this.tabPageHome.Controls.Add(this.labelControl3);
            this.tabPageHome.Controls.Add(this.txNumeroDocumento);
            this.tabPageHome.Controls.Add(this.labelControl2);
            this.tabPageHome.Controls.Add(this.labelControl1);
            this.tabPageHome.Controls.Add(this.dataDocumento);
            this.tabPageHome.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabPageHome.ImageOptions.SvgImage")));
            this.tabPageHome.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPageHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPageHome.Size = new System.Drawing.Size(690, 432);
            // 
            // lkCliente
            // 
            this.errorProvider1.SetIconPadding(this.lkCliente, 3);
            this.lkCliente.Location = new System.Drawing.Point(28, 151);
            this.lkCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lkCliente.Name = "lkCliente";
            this.lkCliente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkCliente.Properties.Appearance.Options.UseFont = true;
            this.lkCliente.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkCliente.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RagioneSociale", "Ragione Sociale", 4, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkCliente.Properties.DataSource = this.bndFornitori;
            this.lkCliente.Properties.DisplayMember = "RagioneSociale";
            this.lkCliente.Properties.NullText = "<Seleziona>";
            this.lkCliente.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lkCliente.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lkCliente.Properties.ShowFooter = false;
            this.lkCliente.Properties.ShowHeader = false;
            this.lkCliente.Properties.ShowLines = false;
            this.lkCliente.Properties.ValueMember = "Id";
            this.lkCliente.Size = new System.Drawing.Size(626, 28);
            this.lkCliente.TabIndex = 6;
            this.lkCliente.EditValueChanged += new System.EventHandler(this.lkCliente_EditValueChanged);
            // 
            // bndFornitori
            // 
            this.bndFornitori.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.AnagraficaCollection);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(28, 116);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 19);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Fornitore :";
            // 
            // txNumeroDocumento
            // 
            this.errorProvider1.SetIconPadding(this.txNumeroDocumento, 3);
            this.txNumeroDocumento.Location = new System.Drawing.Point(233, 69);
            this.txNumeroDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txNumeroDocumento.Name = "txNumeroDocumento";
            this.txNumeroDocumento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumeroDocumento.Properties.Appearance.Options.UseFont = true;
            this.txNumeroDocumento.Properties.Appearance.Options.UseTextOptions = true;
            this.txNumeroDocumento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txNumeroDocumento.Size = new System.Drawing.Size(161, 26);
            this.txNumeroDocumento.TabIndex = 9;
            this.txNumeroDocumento.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(233, 45);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(152, 19);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Numero documento :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 45);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(127, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Data documento :";
            // 
            // dataDocumento
            // 
            this.dataDocumento.EditValue = null;
            this.errorProvider1.SetIconPadding(this.dataDocumento, 3);
            this.dataDocumento.Location = new System.Drawing.Point(28, 69);
            this.dataDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataDocumento.Name = "dataDocumento";
            this.dataDocumento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDocumento.Properties.Appearance.Options.UseFont = true;
            this.dataDocumento.Properties.Appearance.Options.UseTextOptions = true;
            this.dataDocumento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dataDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataDocumento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataDocumento.Size = new System.Drawing.Size(146, 26);
            this.dataDocumento.TabIndex = 5;
            this.dataDocumento.EditValueChanged += new System.EventHandler(this.dataDocumento_EditValueChanged);
            // 
            // tabPageArticoli
            // 
            this.tabPageArticoli.Caption = "Dettaglio articoli";
            this.tabPageArticoli.Controls.Add(this.labelControl5);
            this.tabPageArticoli.Controls.Add(this.txPrezzoAcquisto);
            this.tabPageArticoli.Controls.Add(this.txLotto);
            this.tabPageArticoli.Controls.Add(this.labelControl4);
            this.tabPageArticoli.Controls.Add(this.gridControl1);
            this.tabPageArticoli.Controls.Add(this.txQta);
            this.tabPageArticoli.Controls.Add(this.labelControl11);
            this.tabPageArticoli.Controls.Add(this.btnCancellaArticolo);
            this.tabPageArticoli.Controls.Add(this.btnAggiungiArticolo);
            this.tabPageArticoli.Controls.Add(this.lblUM);
            this.tabPageArticoli.Controls.Add(this.lkArticoli);
            this.tabPageArticoli.Controls.Add(this.labelControl8);
            this.tabPageArticoli.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabPageArticoli.ImageOptions.SvgImage")));
            this.tabPageArticoli.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPageArticoli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageArticoli.Name = "tabPageArticoli";
            this.tabPageArticoli.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPageArticoli.Size = new System.Drawing.Size(690, 432);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(432, 61);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 19);
            this.labelControl5.TabIndex = 48;
            this.labelControl5.Text = "€ acquisto :";
            // 
            // txPrezzoAcquisto
            // 
            this.txPrezzoAcquisto.EditValue = "0";
            this.txPrezzoAcquisto.Location = new System.Drawing.Point(514, 58);
            this.txPrezzoAcquisto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txPrezzoAcquisto.Name = "txPrezzoAcquisto";
            this.txPrezzoAcquisto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrezzoAcquisto.Properties.Appearance.Options.UseFont = true;
            this.txPrezzoAcquisto.Properties.Appearance.Options.UseTextOptions = true;
            this.txPrezzoAcquisto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txPrezzoAcquisto.Properties.Mask.EditMask = "f2";
            this.txPrezzoAcquisto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txPrezzoAcquisto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txPrezzoAcquisto.Size = new System.Drawing.Size(116, 28);
            this.txPrezzoAcquisto.TabIndex = 47;
            // 
            // txLotto
            // 
            this.txLotto.EditValue = "";
            this.txLotto.Location = new System.Drawing.Point(94, 56);
            this.txLotto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txLotto.Name = "txLotto";
            this.txLotto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLotto.Properties.Appearance.Options.UseFont = true;
            this.txLotto.Properties.Appearance.Options.UseTextOptions = true;
            this.txLotto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txLotto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txLotto.Size = new System.Drawing.Size(324, 28);
            this.txLotto.TabIndex = 46;
            this.txLotto.TextChanged += new System.EventHandler(this.txLotto_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(39, 61);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 19);
            this.labelControl4.TabIndex = 45;
            this.labelControl4.Text = "Lotto :";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bndRighe;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Location = new System.Drawing.Point(23, 104);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkArticoliGrid,
            this.lkLavorazioneGrid});
            this.gridControl1.Size = new System.Drawing.Size(653, 318);
            this.gridControl1.TabIndex = 44;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // bndRighe
            // 
            this.bndRighe.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.DocumentoRigaCollection);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HorzLine.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HorzLine.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdArticolo,
            this.colUm,
            this.colQta,
            this.colLotto});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 20;
            // 
            // colIdArticolo
            // 
            this.colIdArticolo.AppearanceCell.Options.UseTextOptions = true;
            this.colIdArticolo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdArticolo.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdArticolo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdArticolo.Caption = "Articolo";
            this.colIdArticolo.ColumnEdit = this.lkArticoliGrid;
            this.colIdArticolo.FieldName = "IdArticolo";
            this.colIdArticolo.MinWidth = 19;
            this.colIdArticolo.Name = "colIdArticolo";
            this.colIdArticolo.OptionsColumn.AllowEdit = false;
            this.colIdArticolo.OptionsFilter.AllowFilter = false;
            this.colIdArticolo.Visible = true;
            this.colIdArticolo.VisibleIndex = 0;
            this.colIdArticolo.Width = 333;
            // 
            // lkArticoliGrid
            // 
            this.lkArticoliGrid.AutoHeight = false;
            this.lkArticoliGrid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkArticoliGrid.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkArticoliGrid.DataSource = this.bndArticoli;
            this.lkArticoliGrid.DisplayMember = "Descrizione";
            this.lkArticoliGrid.Name = "lkArticoliGrid";
            this.lkArticoliGrid.ValueMember = "Id";
            // 
            // bndArticoli
            // 
            this.bndArticoli.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.ArticoloCollection);
            // 
            // colUm
            // 
            this.colUm.AppearanceCell.Options.UseTextOptions = true;
            this.colUm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUm.AppearanceHeader.Options.UseTextOptions = true;
            this.colUm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUm.FieldName = "Um";
            this.colUm.MinWidth = 19;
            this.colUm.Name = "colUm";
            this.colUm.OptionsColumn.AllowEdit = false;
            this.colUm.OptionsFilter.AllowFilter = false;
            this.colUm.Visible = true;
            this.colUm.VisibleIndex = 1;
            this.colUm.Width = 77;
            // 
            // colQta
            // 
            this.colQta.AppearanceCell.Options.UseTextOptions = true;
            this.colQta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQta.AppearanceHeader.Options.UseTextOptions = true;
            this.colQta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQta.DisplayFormat.FormatString = "n1";
            this.colQta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQta.FieldName = "Qta";
            this.colQta.MinWidth = 19;
            this.colQta.Name = "colQta";
            this.colQta.OptionsColumn.AllowEdit = false;
            this.colQta.OptionsFilter.AllowFilter = false;
            this.colQta.Visible = true;
            this.colQta.VisibleIndex = 2;
            this.colQta.Width = 67;
            // 
            // colLotto
            // 
            this.colLotto.AppearanceCell.Options.UseTextOptions = true;
            this.colLotto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLotto.AppearanceHeader.Options.UseTextOptions = true;
            this.colLotto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLotto.FieldName = "Lotto";
            this.colLotto.MinWidth = 19;
            this.colLotto.Name = "colLotto";
            this.colLotto.OptionsColumn.AllowEdit = false;
            this.colLotto.OptionsFilter.AllowFilter = false;
            this.colLotto.Visible = true;
            this.colLotto.VisibleIndex = 3;
            this.colLotto.Width = 175;
            // 
            // lkLavorazioneGrid
            // 
            this.lkLavorazioneGrid.AutoHeight = false;
            this.lkLavorazioneGrid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLavorazioneGrid.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkLavorazioneGrid.DisplayMember = "Descrizione";
            this.lkLavorazioneGrid.Name = "lkLavorazioneGrid";
            this.lkLavorazioneGrid.ValueMember = "Id";
            // 
            // txQta
            // 
            this.txQta.EditValue = "0";
            this.txQta.Location = new System.Drawing.Point(514, 11);
            this.txQta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txQta.Name = "txQta";
            this.txQta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQta.Properties.Appearance.Options.UseFont = true;
            this.txQta.Properties.Appearance.Options.UseTextOptions = true;
            this.txQta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txQta.Properties.Mask.EditMask = "f1";
            this.txQta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txQta.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txQta.Size = new System.Drawing.Size(116, 28);
            this.txQta.TabIndex = 38;
            this.txQta.TextChanged += new System.EventHandler(this.txQta_TextChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(476, 15);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(36, 19);
            this.labelControl11.TabIndex = 43;
            this.labelControl11.Text = "Qta :";
            // 
            // btnCancellaArticolo
            // 
            this.btnCancellaArticolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancellaArticolo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCancellaArticolo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancellaArticolo.ImageOptions.SvgImage")));
            this.btnCancellaArticolo.Location = new System.Drawing.Point(639, 58);
            this.btnCancellaArticolo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancellaArticolo.Name = "btnCancellaArticolo";
            this.btnCancellaArticolo.Size = new System.Drawing.Size(38, 41);
            this.btnCancellaArticolo.TabIndex = 40;
            this.btnCancellaArticolo.Click += new System.EventHandler(this.btnCancellaArticolo_Click);
            // 
            // btnAggiungiArticolo
            // 
            this.btnAggiungiArticolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiArticolo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAggiungiArticolo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAggiungiArticolo.ImageOptions.SvgImage")));
            this.btnAggiungiArticolo.Location = new System.Drawing.Point(639, 11);
            this.btnAggiungiArticolo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAggiungiArticolo.Name = "btnAggiungiArticolo";
            this.btnAggiungiArticolo.Size = new System.Drawing.Size(38, 41);
            this.btnAggiungiArticolo.TabIndex = 39;
            this.btnAggiungiArticolo.Click += new System.EventHandler(this.btnAggiungiArticolo_Click);
            // 
            // lblUM
            // 
            this.lblUM.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUM.Appearance.Options.UseFont = true;
            this.lblUM.Appearance.Options.UseTextOptions = true;
            this.lblUM.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblUM.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUM.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblUM.Location = new System.Drawing.Point(422, 11);
            this.lblUM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(50, 28);
            this.lblUM.TabIndex = 37;
            // 
            // lkArticoli
            // 
            this.lkArticoli.Location = new System.Drawing.Point(94, 11);
            this.lkArticoli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lkArticoli.Name = "lkArticoli";
            this.lkArticoli.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkArticoli.Properties.Appearance.Options.UseFont = true;
            this.lkArticoli.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkArticoli.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkArticoli.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkArticoli.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 4, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkArticoli.Properties.DataSource = this.bndArticoli;
            this.lkArticoli.Properties.DisplayMember = "Descrizione";
            this.lkArticoli.Properties.NullText = "<Seleziona>";
            this.lkArticoli.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lkArticoli.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lkArticoli.Properties.ShowFooter = false;
            this.lkArticoli.Properties.ShowHeader = false;
            this.lkArticoli.Properties.ShowLines = false;
            this.lkArticoli.Properties.ValueMember = "Id";
            this.lkArticoli.Size = new System.Drawing.Size(324, 28);
            this.lkArticoli.TabIndex = 36;
            this.lkArticoli.EditValueChanged += new System.EventHandler(this.lkArticoli_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(23, 12);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 19);
            this.labelControl8.TabIndex = 41;
            this.labelControl8.Text = "Articolo :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 475);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 77);
            this.panel1.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(0, 6);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(681, 13);
            this.labelControl6.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(342, 20);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 44);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Annulla";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOK.ImageOptions.SvgImage")));
            this.btnOK.Location = new System.Drawing.Point(218, 20);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 44);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmIngressoMerci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 552);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIngressoMerci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingresso merci";
            this.Load += new System.EventHandler(this.FrmIngressoMerci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndFornitori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txNumeroDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDocumento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDocumento.Properties)).EndInit();
            this.tabPageArticoli.ResumeLayout(false);
            this.tabPageArticoli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txPrezzoAcquisto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txLotto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndRighe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkArticoliGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndArticoli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLavorazioneGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txQta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkArticoli.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPageHome;
        private DevExpress.XtraEditors.LookUpEdit lkCliente;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txNumeroDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dataDocumento;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPageArticoli;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.BindingSource bndFornitori;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdArticolo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkArticoliGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colUm;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkLavorazioneGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colQta;
        private DevExpress.XtraEditors.TextEdit txQta;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btnCancellaArticolo;
        private DevExpress.XtraEditors.SimpleButton btnAggiungiArticolo;
        private DevExpress.XtraEditors.LabelControl lblUM;
        private DevExpress.XtraEditors.LookUpEdit lkArticoli;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.BindingSource bndRighe;
        private System.Windows.Forms.BindingSource bndArticoli;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.TextEdit txLotto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn colLotto;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txPrezzoAcquisto;
        }
    }