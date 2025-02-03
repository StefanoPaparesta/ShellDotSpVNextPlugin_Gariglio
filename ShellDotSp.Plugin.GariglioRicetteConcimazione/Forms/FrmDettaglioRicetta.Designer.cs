namespace ShellDotSp.Plugin.GariglioRicetteConcimazione.Forms
    {
    partial class FrmDettaglioRicetta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDettaglioRicetta));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancella = new DevExpress.XtraEditors.SimpleButton();
            this.btnAggiungi = new DevExpress.XtraEditors.SimpleButton();
            this.txQta = new DevExpress.XtraEditors.TextEdit();
            this.lkArticolo = new DevExpress.XtraEditors.LookUpEdit();
            this.bndArticoli = new System.Windows.Forms.BindingSource(this.components);
            this.lkTanica = new DevExpress.XtraEditors.LookUpEdit();
            this.bndTaniche = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bndData = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescrizioneArticolo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodiceTanica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescrizioneUbicazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txQta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkArticolo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndArticoli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTanica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndTaniche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 631);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(859, 16);
            this.labelControl6.TabIndex = 24;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOK.ImageOptions.SvgImage")));
            this.btnOK.Location = new System.Drawing.Point(361, 653);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(160, 54);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.btnCancella);
            this.panel1.Controls.Add(this.btnAggiungi);
            this.panel1.Controls.Add(this.txQta);
            this.panel1.Controls.Add(this.lkArticolo);
            this.panel1.Controls.Add(this.lkTanica);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 95);
            this.panel1.TabIndex = 27;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(418, 15);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(90, 24);
            this.labelControl8.TabIndex = 55;
            this.labelControl8.Text = "Quantità :";
            // 
            // btnCancella
            // 
            this.btnCancella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancella.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCancella.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancella.ImageOptions.SvgImage")));
            this.btnCancella.Location = new System.Drawing.Point(795, 12);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(67, 65);
            this.btnCancella.TabIndex = 54;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAggiungi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAggiungi.ImageOptions.SvgImage")));
            this.btnAggiungi.Location = new System.Drawing.Point(722, 12);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(67, 65);
            this.btnAggiungi.TabIndex = 53;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // txQta
            // 
            this.txQta.EditValue = "0";
            this.errorProvider1.SetIconPadding(this.txQta, 3);
            this.txQta.Location = new System.Drawing.Point(514, 12);
            this.txQta.Name = "txQta";
            this.txQta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQta.Properties.Appearance.Options.UseFont = true;
            this.txQta.Properties.Appearance.Options.UseTextOptions = true;
            this.txQta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txQta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txQta.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txQta.Properties.Mask.EditMask = "f2";
            this.txQta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txQta.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txQta.Size = new System.Drawing.Size(141, 30);
            this.txQta.TabIndex = 7;
            // 
            // lkArticolo
            // 
            this.errorProvider1.SetIconPadding(this.lkArticolo, 3);
            this.lkArticolo.Location = new System.Drawing.Point(12, 48);
            this.lkArticolo.Name = "lkArticolo";
            this.lkArticolo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkArticolo.Properties.Appearance.Options.UseFont = true;
            this.lkArticolo.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkArticolo.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkArticolo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkArticolo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 112, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkArticolo.Properties.DataSource = this.bndArticoli;
            this.lkArticolo.Properties.DisplayMember = "Descrizione";
            this.lkArticolo.Properties.NullText = "<Seleziona Articolo>";
            this.lkArticolo.Properties.ShowFooter = false;
            this.lkArticolo.Properties.ShowHeader = false;
            this.lkArticolo.Properties.ShowLines = false;
            this.lkArticolo.Properties.ValueMember = "Id";
            this.lkArticolo.Size = new System.Drawing.Size(373, 30);
            this.lkArticolo.TabIndex = 1;
            // 
            // bndArticoli
            // 
            this.bndArticoli.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.ArticoloCollection);
            // 
            // lkTanica
            // 
            this.errorProvider1.SetIconPadding(this.lkTanica, 3);
            this.lkTanica.Location = new System.Drawing.Point(12, 12);
            this.lkTanica.Name = "lkTanica";
            this.lkTanica.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkTanica.Properties.Appearance.Options.UseFont = true;
            this.lkTanica.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkTanica.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkTanica.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTanica.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 112, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkTanica.Properties.DataSource = this.bndTaniche;
            this.lkTanica.Properties.DisplayMember = "Descrizione";
            this.lkTanica.Properties.NullText = "<Seleziona Tanica>";
            this.lkTanica.Properties.ShowFooter = false;
            this.lkTanica.Properties.ShowHeader = false;
            this.lkTanica.Properties.ShowLines = false;
            this.lkTanica.Properties.ValueMember = "Codice";
            this.lkTanica.Size = new System.Drawing.Size(373, 30);
            this.lkTanica.TabIndex = 0;
            // 
            // bndTaniche
            // 
            this.bndTaniche.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.UbicazioneCollection);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bndData;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 95);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(883, 530);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // bndData
            // 
            this.bndData.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.VRicettaDettaglioCollection);
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
            this.colDescrizioneArticolo,
            this.colQta,
            this.colCodiceTanica,
            this.colDescrizioneUbicazione});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colDescrizioneArticolo
            // 
            this.colDescrizioneArticolo.AppearanceCell.Options.UseTextOptions = true;
            this.colDescrizioneArticolo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescrizioneArticolo.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescrizioneArticolo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescrizioneArticolo.Caption = "Articolo";
            this.colDescrizioneArticolo.FieldName = "DescrizioneArticolo";
            this.colDescrizioneArticolo.MinWidth = 25;
            this.colDescrizioneArticolo.Name = "colDescrizioneArticolo";
            this.colDescrizioneArticolo.OptionsColumn.AllowEdit = false;
            this.colDescrizioneArticolo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescrizioneArticolo.OptionsFilter.AllowFilter = false;
            this.colDescrizioneArticolo.Visible = true;
            this.colDescrizioneArticolo.VisibleIndex = 2;
            this.colDescrizioneArticolo.Width = 368;
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
            this.colQta.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQta.OptionsFilter.AllowFilter = false;
            this.colQta.Visible = true;
            this.colQta.VisibleIndex = 3;
            this.colQta.Width = 94;
            // 
            // colCodiceTanica
            // 
            this.colCodiceTanica.AppearanceCell.Options.UseTextOptions = true;
            this.colCodiceTanica.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodiceTanica.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodiceTanica.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodiceTanica.Caption = "# Tanica";
            this.colCodiceTanica.FieldName = "CodiceTanica";
            this.colCodiceTanica.MinWidth = 25;
            this.colCodiceTanica.Name = "colCodiceTanica";
            this.colCodiceTanica.OptionsColumn.AllowEdit = false;
            this.colCodiceTanica.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCodiceTanica.OptionsFilter.AllowFilter = false;
            this.colCodiceTanica.Visible = true;
            this.colCodiceTanica.VisibleIndex = 1;
            this.colCodiceTanica.Width = 112;
            // 
            // colDescrizioneUbicazione
            // 
            this.colDescrizioneUbicazione.AppearanceCell.Options.UseTextOptions = true;
            this.colDescrizioneUbicazione.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescrizioneUbicazione.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescrizioneUbicazione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescrizioneUbicazione.Caption = "Tanica";
            this.colDescrizioneUbicazione.FieldName = "DescrizioneUbicazione";
            this.colDescrizioneUbicazione.MinWidth = 25;
            this.colDescrizioneUbicazione.Name = "colDescrizioneUbicazione";
            this.colDescrizioneUbicazione.OptionsColumn.AllowEdit = false;
            this.colDescrizioneUbicazione.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescrizioneUbicazione.OptionsFilter.AllowFilter = false;
            this.colDescrizioneUbicazione.Visible = true;
            this.colDescrizioneUbicazione.VisibleIndex = 0;
            this.colDescrizioneUbicazione.Width = 266;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmDettaglioRicetta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 719);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDettaglioRicetta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dettaglio Ricetta";
            this.Load += new System.EventHandler(this.FrmDettaglioRicetta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txQta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkArticolo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndArticoli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTanica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndTaniche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bndData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrizioneArticolo;
        private DevExpress.XtraGrid.Columns.GridColumn colQta;
        private DevExpress.XtraGrid.Columns.GridColumn colCodiceTanica;
        private DevExpress.XtraGrid.Columns.GridColumn colDescrizioneUbicazione;
        private DevExpress.XtraEditors.LookUpEdit lkArticolo;
        private DevExpress.XtraEditors.LookUpEdit lkTanica;
        private DevExpress.XtraEditors.TextEdit txQta;
        private DevExpress.XtraEditors.SimpleButton btnCancella;
        private DevExpress.XtraEditors.SimpleButton btnAggiungi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.BindingSource bndArticoli;
        private System.Windows.Forms.BindingSource bndTaniche;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        }
    }