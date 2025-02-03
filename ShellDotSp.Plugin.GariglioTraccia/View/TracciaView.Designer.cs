namespace ShellDotSp.Plugin.GariglioTraccia.View
    {
    partial class TracciaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TracciaView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txLotto = new DevExpress.XtraEditors.TextEdit();
            this.btnFiltra = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bndData = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCicloProduzioneDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeProdotto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescrizione1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescrizione2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.bndDocVendita = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataDocumento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRagioneSociale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticolo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.bndUbicazioni = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLottoOrigine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUbicazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUbicazionePrecedente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtaPrecedente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormatoConf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCausale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txLotto.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndDocVendita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndUbicazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txLotto);
            this.panel1.Controls.Add(this.btnFiltra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 78);
            this.panel1.TabIndex = 2;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExport.ImageOptions.SvgImage")));
            this.btnExport.Location = new System.Drawing.Point(1005, 7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(67, 65);
            this.btnExport.TabIndex = 46;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(217, 24);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Lotto confezionamento :";
            // 
            // txLotto
            // 
            this.txLotto.Location = new System.Drawing.Point(263, 19);
            this.txLotto.Name = "txLotto";
            this.txLotto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLotto.Properties.Appearance.Options.UseFont = true;
            this.txLotto.Properties.Appearance.Options.UseTextOptions = true;
            this.txLotto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txLotto.Size = new System.Drawing.Size(240, 40);
            this.txLotto.TabIndex = 44;
            // 
            // btnFiltra
            // 
            this.btnFiltra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltra.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltra.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFiltra.ImageOptions.SvgImage")));
            this.btnFiltra.Location = new System.Drawing.Point(1078, 7);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(67, 65);
            this.btnFiltra.TabIndex = 43;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 712);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1161, 31);
            this.panel3.TabIndex = 7;
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
            this.labelControl1.Size = new System.Drawing.Size(250, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ricerca Tracciabilità";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1161, 624);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabPane1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(1155, 618);
            this.panel2.TabIndex = 0;
            // 
            // tabPane1
            // 
            this.tabPane1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Appearance.Options.UseFont = true;
            this.tabPane1.AppearanceButton.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.AppearanceButton.Hovered.Options.UseFont = true;
            this.tabPane1.AppearanceButton.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.AppearanceButton.Normal.Options.UseFont = true;
            this.tabPane1.AppearanceButton.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.AppearanceButton.Pressed.Options.UseFont = true;
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.PageProperties.AppearanceCaption.Options.UseFont = true;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage2,
            this.tabNavigationPage1,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(1155, 618);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(1155, 618);
            this.tabPane1.TabIndex = 11;
            this.tabPane1.Text = "Tab";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Cicli produzione";
            this.tabNavigationPage2.Controls.Add(this.gridControl1);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Properties.AppearanceCaption.Options.UseFont = true;
            this.tabNavigationPage2.Size = new System.Drawing.Size(1155, 577);
            this.tabNavigationPage2.Tag = "0";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bndData;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1155, 577);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridControl1_MouseClick);
            // 
            // bndData
            // 
            this.bndData.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.TracciaCollection);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupButton.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HorzLine.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HorzLine.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCicloProduzioneDesc,
            this.colDataDocumento,
            this.colNomeProdotto,
            this.colLotto,
            this.colDescrizione1,
            this.colDescrizione2,
            this.colQta});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colCicloProduzioneDesc
            // 
            this.colCicloProduzioneDesc.AppearanceCell.Options.UseTextOptions = true;
            this.colCicloProduzioneDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCicloProduzioneDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colCicloProduzioneDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCicloProduzioneDesc.Caption = "Ciclo Produzione";
            this.colCicloProduzioneDesc.FieldName = "CicloProduzioneDesc";
            this.colCicloProduzioneDesc.MinWidth = 25;
            this.colCicloProduzioneDesc.Name = "colCicloProduzioneDesc";
            this.colCicloProduzioneDesc.OptionsColumn.AllowEdit = false;
            this.colCicloProduzioneDesc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colCicloProduzioneDesc.OptionsFilter.AllowFilter = false;
            this.colCicloProduzioneDesc.Visible = true;
            this.colCicloProduzioneDesc.VisibleIndex = 1;
            this.colCicloProduzioneDesc.Width = 213;
            // 
            // colDataDocumento
            // 
            this.colDataDocumento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataDocumento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataDocumento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataDocumento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataDocumento.Caption = "Data";
            this.colDataDocumento.FieldName = "DataDocumento";
            this.colDataDocumento.MinWidth = 25;
            this.colDataDocumento.Name = "colDataDocumento";
            this.colDataDocumento.OptionsColumn.AllowEdit = false;
            this.colDataDocumento.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colDataDocumento.OptionsFilter.AllowFilter = false;
            this.colDataDocumento.Visible = true;
            this.colDataDocumento.VisibleIndex = 2;
            this.colDataDocumento.Width = 168;
            // 
            // colNomeProdotto
            // 
            this.colNomeProdotto.AppearanceHeader.Options.UseTextOptions = true;
            this.colNomeProdotto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNomeProdotto.FieldName = "NomeProdotto";
            this.colNomeProdotto.MinWidth = 25;
            this.colNomeProdotto.Name = "colNomeProdotto";
            this.colNomeProdotto.OptionsColumn.AllowEdit = false;
            this.colNomeProdotto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colNomeProdotto.OptionsFilter.AllowFilter = false;
            this.colNomeProdotto.Visible = true;
            this.colNomeProdotto.VisibleIndex = 3;
            this.colNomeProdotto.Width = 163;
            // 
            // colLotto
            // 
            this.colLotto.AppearanceCell.Options.UseTextOptions = true;
            this.colLotto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLotto.AppearanceHeader.Options.UseTextOptions = true;
            this.colLotto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLotto.Caption = "Lotto Semina";
            this.colLotto.FieldName = "Lotto";
            this.colLotto.MinWidth = 25;
            this.colLotto.Name = "colLotto";
            this.colLotto.OptionsColumn.AllowEdit = false;
            this.colLotto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colLotto.OptionsFilter.AllowFilter = false;
            this.colLotto.Visible = true;
            this.colLotto.VisibleIndex = 0;
            this.colLotto.Width = 141;
            // 
            // colDescrizione1
            // 
            this.colDescrizione1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescrizione1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescrizione1.FieldName = "Descrizione1";
            this.colDescrizione1.MinWidth = 25;
            this.colDescrizione1.Name = "colDescrizione1";
            this.colDescrizione1.OptionsColumn.AllowEdit = false;
            this.colDescrizione1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colDescrizione1.OptionsFilter.AllowFilter = false;
            this.colDescrizione1.Visible = true;
            this.colDescrizione1.VisibleIndex = 5;
            this.colDescrizione1.Width = 162;
            // 
            // colDescrizione2
            // 
            this.colDescrizione2.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescrizione2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescrizione2.FieldName = "Descrizione2";
            this.colDescrizione2.MinWidth = 25;
            this.colDescrizione2.Name = "colDescrizione2";
            this.colDescrizione2.OptionsColumn.AllowEdit = false;
            this.colDescrizione2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colDescrizione2.OptionsFilter.AllowFilter = false;
            this.colDescrizione2.Visible = true;
            this.colDescrizione2.VisibleIndex = 6;
            this.colDescrizione2.Width = 201;
            // 
            // colQta
            // 
            this.colQta.AppearanceCell.Options.UseTextOptions = true;
            this.colQta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQta.AppearanceHeader.Options.UseTextOptions = true;
            this.colQta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQta.FieldName = "Qta";
            this.colQta.MinWidth = 25;
            this.colQta.Name = "colQta";
            this.colQta.OptionsColumn.AllowEdit = false;
            this.colQta.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colQta.OptionsFilter.AllowFilter = false;
            this.colQta.Visible = true;
            this.colQta.VisibleIndex = 4;
            this.colQta.Width = 133;
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Doc.Vendita";
            this.tabNavigationPage1.Controls.Add(this.gridControl2);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1155, 577);
            this.tabNavigationPage1.Tag = "1";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.bndDocVendita;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1155, 577);
            this.gridControl2.TabIndex = 11;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bndDocVendita
            // 
            this.bndDocVendita.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.TracciaDocVenditaCollection);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.EvenRow.Options.UseFont = true;
            this.gridView2.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.GroupButton.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView2.Appearance.HorzLine.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HorzLine.Options.UseFont = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.RowSeparator.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Appearance.VertLine.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.VertLine.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipo,
            this.colDataDocumento1,
            this.colNumero,
            this.colRagioneSociale,
            this.colArticolo,
            this.colUm,
            this.colQta1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowIndicator = false;
            // 
            // colTipo
            // 
            this.colTipo.AppearanceCell.Options.UseTextOptions = true;
            this.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTipo.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTipo.FieldName = "Tipo";
            this.colTipo.MinWidth = 25;
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTipo.OptionsFilter.AllowFilter = false;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 0;
            this.colTipo.Width = 114;
            // 
            // colDataDocumento1
            // 
            this.colDataDocumento1.AppearanceCell.Options.UseTextOptions = true;
            this.colDataDocumento1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataDocumento1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataDocumento1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataDocumento1.FieldName = "DataDocumento";
            this.colDataDocumento1.MinWidth = 25;
            this.colDataDocumento1.Name = "colDataDocumento1";
            this.colDataDocumento1.OptionsColumn.AllowEdit = false;
            this.colDataDocumento1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataDocumento1.OptionsFilter.AllowFilter = false;
            this.colDataDocumento1.Visible = true;
            this.colDataDocumento1.VisibleIndex = 1;
            this.colDataDocumento1.Width = 143;
            // 
            // colNumero
            // 
            this.colNumero.AppearanceCell.Options.UseTextOptions = true;
            this.colNumero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumero.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumero.FieldName = "Numero";
            this.colNumero.MinWidth = 25;
            this.colNumero.Name = "colNumero";
            this.colNumero.OptionsColumn.AllowEdit = false;
            this.colNumero.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNumero.OptionsFilter.AllowFilter = false;
            this.colNumero.Visible = true;
            this.colNumero.VisibleIndex = 2;
            this.colNumero.Width = 190;
            // 
            // colRagioneSociale
            // 
            this.colRagioneSociale.AppearanceHeader.Options.UseTextOptions = true;
            this.colRagioneSociale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRagioneSociale.FieldName = "RagioneSociale";
            this.colRagioneSociale.MinWidth = 25;
            this.colRagioneSociale.Name = "colRagioneSociale";
            this.colRagioneSociale.OptionsColumn.AllowEdit = false;
            this.colRagioneSociale.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRagioneSociale.OptionsFilter.AllowFilter = false;
            this.colRagioneSociale.Visible = true;
            this.colRagioneSociale.VisibleIndex = 3;
            this.colRagioneSociale.Width = 338;
            // 
            // colArticolo
            // 
            this.colArticolo.AppearanceHeader.Options.UseTextOptions = true;
            this.colArticolo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArticolo.FieldName = "Articolo";
            this.colArticolo.MinWidth = 25;
            this.colArticolo.Name = "colArticolo";
            this.colArticolo.OptionsColumn.AllowEdit = false;
            this.colArticolo.OptionsFilter.AllowFilter = false;
            this.colArticolo.Visible = true;
            this.colArticolo.VisibleIndex = 4;
            this.colArticolo.Width = 267;
            // 
            // colUm
            // 
            this.colUm.AppearanceCell.Options.UseTextOptions = true;
            this.colUm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUm.AppearanceHeader.Options.UseTextOptions = true;
            this.colUm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUm.FieldName = "Um";
            this.colUm.MinWidth = 25;
            this.colUm.Name = "colUm";
            this.colUm.OptionsColumn.AllowEdit = false;
            this.colUm.OptionsFilter.AllowFilter = false;
            this.colUm.Visible = true;
            this.colUm.VisibleIndex = 5;
            this.colUm.Width = 94;
            // 
            // colQta1
            // 
            this.colQta1.AppearanceCell.Options.UseTextOptions = true;
            this.colQta1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQta1.AppearanceHeader.Options.UseTextOptions = true;
            this.colQta1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQta1.DisplayFormat.FormatString = "n0";
            this.colQta1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQta1.FieldName = "Qta";
            this.colQta1.MinWidth = 25;
            this.colQta1.Name = "colQta1";
            this.colQta1.OptionsColumn.AllowEdit = false;
            this.colQta1.OptionsFilter.AllowFilter = false;
            this.colQta1.Visible = true;
            this.colQta1.VisibleIndex = 6;
            this.colQta1.Width = 94;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Confezionamento";
            this.tabNavigationPage3.Controls.Add(this.gridControl3);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1155, 577);
            this.tabNavigationPage3.Tag = "2";
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.bndUbicazioni;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(1155, 577);
            this.gridControl3.TabIndex = 12;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // bndUbicazioni
            // 
            this.bndUbicazioni.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.MagazzinoMovimento);
            // 
            // gridView3
            // 
            this.gridView3.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.EvenRow.Options.UseFont = true;
            this.gridView3.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView3.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView3.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView3.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView3.Appearance.HorzLine.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.HorzLine.Options.UseFont = true;
            this.gridView3.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView3.Appearance.OddRow.Options.UseFont = true;
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Appearance.RowSeparator.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView3.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView3.Appearance.VertLine.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.VertLine.Options.UseFont = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colLottoOrigine,
            this.colUbicazione,
            this.colUbicazionePrecedente,
            this.colQtaPrecedente,
            this.colFormatoConf,
            this.colId1,
            this.colCausale});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.EnableAppearanceOddRow = true;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.gridColumn1.FieldName = "Qta";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.gridColumn2.FieldName = "Lotto";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 166;
            // 
            // colLottoOrigine
            // 
            this.colLottoOrigine.AppearanceCell.Options.UseTextOptions = true;
            this.colLottoOrigine.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLottoOrigine.AppearanceHeader.Options.UseTextOptions = true;
            this.colLottoOrigine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLottoOrigine.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colLottoOrigine.FieldName = "LottoOrigine";
            this.colLottoOrigine.MinWidth = 25;
            this.colLottoOrigine.Name = "colLottoOrigine";
            this.colLottoOrigine.OptionsColumn.AllowEdit = false;
            this.colLottoOrigine.OptionsFilter.AllowFilter = false;
            this.colLottoOrigine.Visible = true;
            this.colLottoOrigine.VisibleIndex = 3;
            this.colLottoOrigine.Width = 143;
            // 
            // colUbicazione
            // 
            this.colUbicazione.AppearanceCell.Options.UseTextOptions = true;
            this.colUbicazione.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUbicazione.AppearanceHeader.Options.UseTextOptions = true;
            this.colUbicazione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUbicazione.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colUbicazione.Caption = "Ub.";
            this.colUbicazione.FieldName = "Ubicazione";
            this.colUbicazione.MinWidth = 25;
            this.colUbicazione.Name = "colUbicazione";
            this.colUbicazione.OptionsColumn.AllowEdit = false;
            this.colUbicazione.OptionsFilter.AllowFilter = false;
            this.colUbicazione.Visible = true;
            this.colUbicazione.VisibleIndex = 7;
            this.colUbicazione.Width = 94;
            // 
            // colUbicazionePrecedente
            // 
            this.colUbicazionePrecedente.AppearanceCell.Options.UseTextOptions = true;
            this.colUbicazionePrecedente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUbicazionePrecedente.AppearanceHeader.Options.UseTextOptions = true;
            this.colUbicazionePrecedente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUbicazionePrecedente.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colUbicazionePrecedente.Caption = "Ub. Prec.";
            this.colUbicazionePrecedente.FieldName = "UbicazionePrecedente";
            this.colUbicazionePrecedente.MinWidth = 25;
            this.colUbicazionePrecedente.Name = "colUbicazionePrecedente";
            this.colUbicazionePrecedente.OptionsColumn.AllowEdit = false;
            this.colUbicazionePrecedente.OptionsFilter.AllowFilter = false;
            this.colUbicazionePrecedente.Visible = true;
            this.colUbicazionePrecedente.VisibleIndex = 8;
            this.colUbicazionePrecedente.Width = 140;
            // 
            // colQtaPrecedente
            // 
            this.colQtaPrecedente.AppearanceCell.Options.UseTextOptions = true;
            this.colQtaPrecedente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtaPrecedente.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colQtaPrecedente.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtaPrecedente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtaPrecedente.Caption = "Qta Prec.";
            this.colQtaPrecedente.FieldName = "QtaPrecedente";
            this.colQtaPrecedente.MinWidth = 25;
            this.colQtaPrecedente.Name = "colQtaPrecedente";
            this.colQtaPrecedente.OptionsColumn.AllowEdit = false;
            this.colQtaPrecedente.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQtaPrecedente.OptionsFilter.AllowFilter = false;
            this.colQtaPrecedente.Visible = true;
            this.colQtaPrecedente.VisibleIndex = 5;
            this.colQtaPrecedente.Width = 125;
            // 
            // colFormatoConf
            // 
            this.colFormatoConf.AppearanceCell.Options.UseTextOptions = true;
            this.colFormatoConf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFormatoConf.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colFormatoConf.AppearanceHeader.Options.UseTextOptions = true;
            this.colFormatoConf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFormatoConf.Caption = "Fmt Conf.";
            this.colFormatoConf.FieldName = "FormatoConf";
            this.colFormatoConf.MinWidth = 25;
            this.colFormatoConf.Name = "colFormatoConf";
            this.colFormatoConf.OptionsColumn.AllowEdit = false;
            this.colFormatoConf.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFormatoConf.OptionsFilter.AllowFilter = false;
            this.colFormatoConf.Visible = true;
            this.colFormatoConf.VisibleIndex = 6;
            this.colFormatoConf.Width = 143;
            // 
            // colId1
            // 
            this.colId1.AppearanceCell.Options.UseTextOptions = true;
            this.colId1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId1.AppearanceHeader.Options.UseTextOptions = true;
            this.colId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId1.Caption = "#";
            this.colId1.FieldName = "Id";
            this.colId1.MinWidth = 25;
            this.colId1.Name = "colId1";
            this.colId1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colId1.OptionsFilter.AllowFilter = false;
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            this.colId1.Width = 94;
            // 
            // colCausale
            // 
            this.colCausale.AppearanceCell.Options.UseTextOptions = true;
            this.colCausale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCausale.AppearanceHeader.Options.UseTextOptions = true;
            this.colCausale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCausale.FieldName = "Causale";
            this.colCausale.MinWidth = 25;
            this.colCausale.Name = "colCausale";
            this.colCausale.OptionsColumn.AllowEdit = false;
            this.colCausale.OptionsFilter.AllowFilter = false;
            this.colCausale.Visible = true;
            this.colCausale.VisibleIndex = 1;
            this.colCausale.Width = 90;
            // 
            // TracciaView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "TracciaView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1181, 753);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txLotto.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndDocVendita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndUbicazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnFiltra;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txLotto;
        private System.Windows.Forms.BindingSource bndData;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCicloProduzioneDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colDataDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProdotto;
        private DevExpress.XtraGrid.Columns.GridColumn colLotto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrizione1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrizione2;
        private DevExpress.XtraGrid.Columns.GridColumn colQta;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource bndDocVendita;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colDataDocumento1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colRagioneSociale;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraGrid.Columns.GridColumn colArticolo;
        private DevExpress.XtraGrid.Columns.GridColumn colUm;
        private DevExpress.XtraGrid.Columns.GridColumn colQta1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private System.Windows.Forms.BindingSource bndUbicazioni;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colLottoOrigine;
        private DevExpress.XtraGrid.Columns.GridColumn colUbicazione;
        private DevExpress.XtraGrid.Columns.GridColumn colUbicazionePrecedente;
        private DevExpress.XtraGrid.Columns.GridColumn colQtaPrecedente;
        private DevExpress.XtraGrid.Columns.GridColumn colFormatoConf;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colCausale;
    }
    }
