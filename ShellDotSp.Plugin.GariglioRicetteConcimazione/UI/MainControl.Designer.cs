namespace ShellDotSp.Plugin.GariglioRicetteConcimazione.UI
    {
    partial class MainControlRicetteConcimazione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControlRicetteConcimazione));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDettaglio = new DevExpress.XtraEditors.SimpleButton();
            this.btnModifica = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancella = new DevExpress.XtraEditors.SimpleButton();
            this.btnAggiungi = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltra = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bndData = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescrizione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataInizioUtilizzo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataFineUtilizzo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDettaglio);
            this.panel1.Controls.Add(this.btnModifica);
            this.panel1.Controls.Add(this.btnCancella);
            this.panel1.Controls.Add(this.btnAggiungi);
            this.panel1.Controls.Add(this.btnFiltra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 95);
            this.panel1.TabIndex = 0;
            // 
            // btnDettaglio
            // 
            this.btnDettaglio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDettaglio.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDettaglio.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDettaglio.ImageOptions.SvgImage")));
            this.btnDettaglio.Location = new System.Drawing.Point(843, 18);
            this.btnDettaglio.Name = "btnDettaglio";
            this.btnDettaglio.Size = new System.Drawing.Size(67, 65);
            this.btnDettaglio.TabIndex = 54;
            this.btnDettaglio.Click += new System.EventHandler(this.btnDettaglio_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifica.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnModifica.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnModifica.ImageOptions.SvgImage")));
            this.btnModifica.Location = new System.Drawing.Point(916, 18);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(67, 65);
            this.btnModifica.TabIndex = 53;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCancella
            // 
            this.btnCancella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancella.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCancella.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancella.ImageOptions.SvgImage")));
            this.btnCancella.Location = new System.Drawing.Point(989, 18);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(67, 65);
            this.btnCancella.TabIndex = 52;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAggiungi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAggiungi.ImageOptions.SvgImage")));
            this.btnAggiungi.Location = new System.Drawing.Point(770, 18);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(67, 65);
            this.btnAggiungi.TabIndex = 51;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnFiltra
            // 
            this.btnFiltra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltra.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltra.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFiltra.ImageOptions.SvgImage")));
            this.btnFiltra.Location = new System.Drawing.Point(697, 18);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(67, 65);
            this.btnFiltra.TabIndex = 50;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bndData;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 95);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1069, 601);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // bndData
            // 
            this.bndData.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.RicettaIrrigazioneTestataCollection);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
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
            this.colDescrizione,
            this.colDataInizioUtilizzo,
            this.colDataFineUtilizzo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colDescrizione
            // 
            this.colDescrizione.AppearanceCell.Options.UseTextOptions = true;
            this.colDescrizione.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescrizione.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescrizione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescrizione.FieldName = "Descrizione";
            this.colDescrizione.MinWidth = 25;
            this.colDescrizione.Name = "colDescrizione";
            this.colDescrizione.OptionsColumn.AllowEdit = false;
            this.colDescrizione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescrizione.OptionsFilter.AllowFilter = false;
            this.colDescrizione.Visible = true;
            this.colDescrizione.VisibleIndex = 0;
            this.colDescrizione.Width = 495;
            // 
            // colDataInizioUtilizzo
            // 
            this.colDataInizioUtilizzo.AppearanceCell.Options.UseTextOptions = true;
            this.colDataInizioUtilizzo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataInizioUtilizzo.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataInizioUtilizzo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataInizioUtilizzo.FieldName = "DataInizioUtilizzo";
            this.colDataInizioUtilizzo.MinWidth = 25;
            this.colDataInizioUtilizzo.Name = "colDataInizioUtilizzo";
            this.colDataInizioUtilizzo.OptionsColumn.AllowEdit = false;
            this.colDataInizioUtilizzo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataInizioUtilizzo.OptionsFilter.AllowFilter = false;
            this.colDataInizioUtilizzo.Visible = true;
            this.colDataInizioUtilizzo.VisibleIndex = 1;
            this.colDataInizioUtilizzo.Width = 165;
            // 
            // colDataFineUtilizzo
            // 
            this.colDataFineUtilizzo.AppearanceCell.Options.UseTextOptions = true;
            this.colDataFineUtilizzo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataFineUtilizzo.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataFineUtilizzo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataFineUtilizzo.FieldName = "DataFineUtilizzo";
            this.colDataFineUtilizzo.MinWidth = 25;
            this.colDataFineUtilizzo.Name = "colDataFineUtilizzo";
            this.colDataFineUtilizzo.OptionsColumn.AllowEdit = false;
            this.colDataFineUtilizzo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDataFineUtilizzo.OptionsFilter.AllowFilter = false;
            this.colDataFineUtilizzo.Visible = true;
            this.colDataFineUtilizzo.VisibleIndex = 2;
            this.colDataFineUtilizzo.Width = 198;
            // 
            // MainControlRicetteConcimazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "MainControlRicetteConcimazione";
            this.Size = new System.Drawing.Size(1069, 696);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnModifica;
        private DevExpress.XtraEditors.SimpleButton btnCancella;
        private DevExpress.XtraEditors.SimpleButton btnAggiungi;
        private DevExpress.XtraEditors.SimpleButton btnFiltra;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bndData;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrizione;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInizioUtilizzo;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFineUtilizzo;
        private DevExpress.XtraEditors.SimpleButton btnDettaglio;
        }
    }
