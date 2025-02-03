namespace ShellDotSp.Plugin.GariglioAnag.View
    {
    partial class AnagraficheView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnagraficheView));
            this.bndAnagrafiche = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRagioneSociale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirizzo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodiceFiscale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartitaIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnModifica = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancella = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAggiungi = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.bndAnagrafiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipo.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bndAnagrafiche
            // 
            this.bndAnagrafiche.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.AnagraficaCollection);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bndAnagrafiche;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1069, 427);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridControl1_MouseClick);
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
            this.colRagioneSociale,
            this.colIndirizzo,
            this.colLocalita,
            this.colProvincia,
            this.colCap,
            this.colCodiceFiscale,
            this.colPartitaIva});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colRagioneSociale
            // 
            this.colRagioneSociale.AppearanceHeader.Options.UseTextOptions = true;
            this.colRagioneSociale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRagioneSociale.FieldName = "RagioneSociale";
            this.colRagioneSociale.MinWidth = 25;
            this.colRagioneSociale.Name = "colRagioneSociale";
            this.colRagioneSociale.OptionsColumn.AllowEdit = false;
            this.colRagioneSociale.OptionsColumn.AllowMove = false;
            this.colRagioneSociale.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colRagioneSociale.OptionsFilter.AllowFilter = false;
            this.colRagioneSociale.Visible = true;
            this.colRagioneSociale.VisibleIndex = 0;
            this.colRagioneSociale.Width = 94;
            // 
            // colIndirizzo
            // 
            this.colIndirizzo.AppearanceCell.Options.UseTextOptions = true;
            this.colIndirizzo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIndirizzo.AppearanceHeader.Options.UseTextOptions = true;
            this.colIndirizzo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIndirizzo.FieldName = "Indirizzo";
            this.colIndirizzo.MinWidth = 25;
            this.colIndirizzo.Name = "colIndirizzo";
            this.colIndirizzo.OptionsColumn.AllowEdit = false;
            this.colIndirizzo.OptionsColumn.AllowMove = false;
            this.colIndirizzo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colIndirizzo.OptionsFilter.AllowFilter = false;
            this.colIndirizzo.Visible = true;
            this.colIndirizzo.VisibleIndex = 1;
            this.colIndirizzo.Width = 94;
            // 
            // colLocalita
            // 
            this.colLocalita.AppearanceCell.Options.UseTextOptions = true;
            this.colLocalita.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLocalita.AppearanceHeader.Options.UseTextOptions = true;
            this.colLocalita.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLocalita.FieldName = "Localita";
            this.colLocalita.MinWidth = 25;
            this.colLocalita.Name = "colLocalita";
            this.colLocalita.OptionsColumn.AllowEdit = false;
            this.colLocalita.OptionsColumn.AllowMove = false;
            this.colLocalita.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colLocalita.OptionsFilter.AllowFilter = false;
            this.colLocalita.Visible = true;
            this.colLocalita.VisibleIndex = 2;
            this.colLocalita.Width = 94;
            // 
            // colProvincia
            // 
            this.colProvincia.AppearanceCell.Options.UseTextOptions = true;
            this.colProvincia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProvincia.AppearanceHeader.Options.UseTextOptions = true;
            this.colProvincia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProvincia.FieldName = "Provincia";
            this.colProvincia.MinWidth = 25;
            this.colProvincia.Name = "colProvincia";
            this.colProvincia.OptionsColumn.AllowEdit = false;
            this.colProvincia.OptionsColumn.AllowMove = false;
            this.colProvincia.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colProvincia.OptionsFilter.AllowFilter = false;
            this.colProvincia.Visible = true;
            this.colProvincia.VisibleIndex = 3;
            this.colProvincia.Width = 94;
            // 
            // colCap
            // 
            this.colCap.AppearanceCell.Options.UseTextOptions = true;
            this.colCap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCap.AppearanceHeader.Options.UseTextOptions = true;
            this.colCap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCap.FieldName = "Cap";
            this.colCap.MinWidth = 25;
            this.colCap.Name = "colCap";
            this.colCap.OptionsColumn.AllowEdit = false;
            this.colCap.OptionsColumn.AllowMove = false;
            this.colCap.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colCap.OptionsFilter.AllowFilter = false;
            this.colCap.Visible = true;
            this.colCap.VisibleIndex = 4;
            this.colCap.Width = 94;
            // 
            // colCodiceFiscale
            // 
            this.colCodiceFiscale.AppearanceCell.Options.UseTextOptions = true;
            this.colCodiceFiscale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodiceFiscale.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodiceFiscale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodiceFiscale.FieldName = "CodiceFiscale";
            this.colCodiceFiscale.MinWidth = 25;
            this.colCodiceFiscale.Name = "colCodiceFiscale";
            this.colCodiceFiscale.OptionsColumn.AllowEdit = false;
            this.colCodiceFiscale.OptionsColumn.AllowMove = false;
            this.colCodiceFiscale.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colCodiceFiscale.OptionsFilter.AllowFilter = false;
            this.colCodiceFiscale.Visible = true;
            this.colCodiceFiscale.VisibleIndex = 5;
            this.colCodiceFiscale.Width = 94;
            // 
            // colPartitaIva
            // 
            this.colPartitaIva.AppearanceCell.Options.UseTextOptions = true;
            this.colPartitaIva.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPartitaIva.AppearanceHeader.Options.UseTextOptions = true;
            this.colPartitaIva.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPartitaIva.FieldName = "PartitaIva";
            this.colPartitaIva.MinWidth = 25;
            this.colPartitaIva.Name = "colPartitaIva";
            this.colPartitaIva.OptionsColumn.AllowEdit = false;
            this.colPartitaIva.OptionsColumn.AllowMove = false;
            this.colPartitaIva.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colPartitaIva.OptionsFilter.AllowFilter = false;
            this.colPartitaIva.Visible = true;
            this.colPartitaIva.VisibleIndex = 6;
            this.colPartitaIva.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.btnModifica);
            this.panel1.Controls.Add(this.btnCancella);
            this.panel1.Controls.Add(this.BtnAggiungi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 93);
            this.panel1.TabIndex = 1;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Location = new System.Drawing.Point(0, 26);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.Properties.Appearance.Options.UseFont = true;
            this.cmbTipo.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipo.Properties.Items.AddRange(new object[] {
            "CLIENTE",
            "FORNITORE"});
            this.cmbTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTipo.Size = new System.Drawing.Size(347, 34);
            this.cmbTipo.TabIndex = 34;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifica.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnModifica.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnModifica.ImageOptions.SvgImage")));
            this.btnModifica.Location = new System.Drawing.Point(916, 14);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(67, 65);
            this.btnModifica.TabIndex = 33;
            this.btnModifica.Click += new System.EventHandler(this.BtnModifica_Click);
            // 
            // btnCancella
            // 
            this.btnCancella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancella.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCancella.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancella.ImageOptions.SvgImage")));
            this.btnCancella.Location = new System.Drawing.Point(989, 14);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(67, 65);
            this.btnCancella.TabIndex = 32;
            this.btnCancella.Click += new System.EventHandler(this.BtnCancella_Click);
            // 
            // BtnAggiungi
            // 
            this.BtnAggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAggiungi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnAggiungi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAggiungi.ImageOptions.SvgImage")));
            this.BtnAggiungi.Location = new System.Drawing.Point(843, 14);
            this.BtnAggiungi.Name = "BtnAggiungi";
            this.BtnAggiungi.Size = new System.Drawing.Size(67, 65);
            this.BtnAggiungi.TabIndex = 31;
            this.BtnAggiungi.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 458);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1069, 31);
            this.panel3.TabIndex = 6;
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
            this.labelControl1.Size = new System.Drawing.Size(184, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Anagrafiche";
            // 
            // AnagraficheView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AnagraficheView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1089, 571);
            ((System.ComponentModel.ISupportInitialize)(this.bndAnagrafiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipo.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.BindingSource bndAnagrafiche;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRagioneSociale;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirizzo;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalita;
        private DevExpress.XtraGrid.Columns.GridColumn colProvincia;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnModifica;
        private DevExpress.XtraEditors.SimpleButton btnCancella;
        private DevExpress.XtraEditors.SimpleButton BtnAggiungi;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipo;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn colCap;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodiceFiscale;
        private DevExpress.XtraGrid.Columns.GridColumn colPartitaIva;
        }
    }
