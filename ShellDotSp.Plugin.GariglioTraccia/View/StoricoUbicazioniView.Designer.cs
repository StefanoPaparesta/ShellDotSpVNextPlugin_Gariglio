namespace ShellDotSp.Plugin.GariglioTraccia.View
    {
    partial class StoricoUbicazioniView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoricoUbicazioniView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateEditAl = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDal = new DevExpress.XtraEditors.DateEdit();
            this.btnFiltra = new DevExpress.XtraEditors.SimpleButton();
            this.btnModifica = new DevExpress.XtraEditors.SimpleButton();
            this.btnAggiungi = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bndData = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDataCreazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataChiusura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUbicazione = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateEditAl);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.dateEditDal);
            this.panel1.Controls.Add(this.btnFiltra);
            this.panel1.Controls.Add(this.btnModifica);
            this.panel1.Controls.Add(this.btnAggiungi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 78);
            this.panel1.TabIndex = 2;
            // 
            // dateEditAl
            // 
            this.dateEditAl.EditValue = null;
            this.dateEditAl.Location = new System.Drawing.Point(305, 22);
            this.dateEditAl.Name = "dateEditAl";
            this.dateEditAl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditAl.Properties.Appearance.Options.UseFont = true;
            this.dateEditAl.Properties.Appearance.Options.UseTextOptions = true;
            this.dateEditAl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateEditAl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAl.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAl.Size = new System.Drawing.Size(191, 34);
            this.dateEditAl.TabIndex = 49;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(265, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 28);
            this.labelControl2.TabIndex = 48;
            this.labelControl2.Text = "Al :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(14, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 28);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Dal :";
            // 
            // dateEditDal
            // 
            this.dateEditDal.EditValue = null;
            this.dateEditDal.Location = new System.Drawing.Point(68, 22);
            this.dateEditDal.Name = "dateEditDal";
            this.dateEditDal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditDal.Properties.Appearance.Options.UseFont = true;
            this.dateEditDal.Properties.Appearance.Options.UseTextOptions = true;
            this.dateEditDal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateEditDal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDal.Size = new System.Drawing.Size(191, 34);
            this.dateEditDal.TabIndex = 46;
            // 
            // btnFiltra
            // 
            this.btnFiltra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltra.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltra.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFiltra.ImageOptions.SvgImage")));
            this.btnFiltra.Location = new System.Drawing.Point(777, 7);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(67, 65);
            this.btnFiltra.TabIndex = 44;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifica.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnModifica.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnModifica.ImageOptions.SvgImage")));
            this.btnModifica.Location = new System.Drawing.Point(923, 7);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(67, 65);
            this.btnModifica.TabIndex = 33;
            this.btnModifica.Click += new System.EventHandler(this.BtnModifica_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAggiungi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAggiungi.ImageOptions.SvgImage")));
            this.btnAggiungi.Location = new System.Drawing.Point(850, 7);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(67, 65);
            this.btnAggiungi.TabIndex = 31;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bndData;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(10, 88);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1003, 554);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridControl1_MouseClick);
            // 
            // bndData
            // 
            this.bndData.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.UbicazioneStoricoCollection);
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
            this.colDataCreazione,
            this.colDataChiusura,
            this.colUbicazione,
            this.colLotto});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsFilter.ShowCustomFunctions = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colDataCreazione
            // 
            this.colDataCreazione.AppearanceCell.Options.UseTextOptions = true;
            this.colDataCreazione.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataCreazione.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataCreazione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataCreazione.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colDataCreazione.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataCreazione.FieldName = "DataCreazione";
            this.colDataCreazione.MinWidth = 25;
            this.colDataCreazione.Name = "colDataCreazione";
            this.colDataCreazione.OptionsColumn.AllowEdit = false;
            this.colDataCreazione.OptionsColumn.AllowMove = false;
            this.colDataCreazione.OptionsFilter.AllowFilter = false;
            this.colDataCreazione.Visible = true;
            this.colDataCreazione.VisibleIndex = 0;
            this.colDataCreazione.Width = 181;
            // 
            // colDataChiusura
            // 
            this.colDataChiusura.AppearanceCell.Options.UseTextOptions = true;
            this.colDataChiusura.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataChiusura.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataChiusura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataChiusura.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colDataChiusura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataChiusura.FieldName = "DataChiusura";
            this.colDataChiusura.MinWidth = 25;
            this.colDataChiusura.Name = "colDataChiusura";
            this.colDataChiusura.OptionsColumn.AllowEdit = false;
            this.colDataChiusura.OptionsColumn.AllowMove = false;
            this.colDataChiusura.OptionsFilter.AllowFilter = false;
            this.colDataChiusura.Visible = true;
            this.colDataChiusura.VisibleIndex = 1;
            this.colDataChiusura.Width = 172;
            // 
            // colUbicazione
            // 
            this.colUbicazione.AppearanceCell.Options.UseTextOptions = true;
            this.colUbicazione.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUbicazione.AppearanceHeader.Options.UseTextOptions = true;
            this.colUbicazione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUbicazione.FieldName = "Ubicazione";
            this.colUbicazione.MinWidth = 25;
            this.colUbicazione.Name = "colUbicazione";
            this.colUbicazione.OptionsColumn.AllowEdit = false;
            this.colUbicazione.OptionsColumn.AllowMove = false;
            this.colUbicazione.OptionsFilter.AllowFilter = false;
            this.colUbicazione.Visible = true;
            this.colUbicazione.VisibleIndex = 2;
            this.colUbicazione.Width = 134;
            // 
            // colLotto
            // 
            this.colLotto.AppearanceCell.Options.UseTextOptions = true;
            this.colLotto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLotto.AppearanceHeader.Options.UseTextOptions = true;
            this.colLotto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLotto.FieldName = "Lotto";
            this.colLotto.MinWidth = 25;
            this.colLotto.Name = "colLotto";
            this.colLotto.OptionsColumn.AllowEdit = false;
            this.colLotto.OptionsColumn.AllowMove = false;
            this.colLotto.OptionsFilter.AllowFilter = false;
            this.colLotto.Visible = true;
            this.colLotto.VisibleIndex = 3;
            this.colLotto.Width = 94;
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
            this.labelControl1.Text = "Storico Ubicazioni";
            // 
            // StoricoUbicazioniView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "StoricoUbicazioniView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1023, 683);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnModifica;
        private DevExpress.XtraEditors.SimpleButton btnAggiungi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bndData;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCreazione;
        private DevExpress.XtraGrid.Columns.GridColumn colDataChiusura;
        private DevExpress.XtraGrid.Columns.GridColumn colUbicazione;
        private DevExpress.XtraGrid.Columns.GridColumn colLotto;
        private DevExpress.XtraEditors.SimpleButton btnFiltra;
        private DevExpress.XtraEditors.DateEdit dateEditAl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateEditDal;
    }
    }
