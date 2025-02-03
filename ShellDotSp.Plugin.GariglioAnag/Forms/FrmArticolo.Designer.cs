namespace ShellDotSp.Plugin.GariglioAnag.Forms
    {
    partial class FrmArticolo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticolo));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txDescrizione = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txQtaDiluizione = new DevExpress.XtraEditors.TextEdit();
            this.txDiluizione = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lkCategoria = new DevExpress.XtraEditors.LookUpEdit();
            this.bndCategorie = new System.Windows.Forms.BindingSource(this.components);
            this.txNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txCodiceArticoloFor = new DevExpress.XtraEditors.TextEdit();
            this.bndUmVendita = new System.Windows.Forms.BindingSource(this.components);
            this.bndUmDosaggio = new System.Windows.Forms.BindingSource(this.components);
            this.lkUmVendita = new DevExpress.XtraEditors.LookUpEdit();
            this.lkUmDosaggio = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txClassificazionePericolo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txMotivoTrattamento = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txDescrizione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txQtaDiluizione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDiluizione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndCategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCodiceArticoloFor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndUmVendita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndUmDosaggio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUmVendita.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUmDosaggio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txClassificazionePericolo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMotivoTrattamento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(129, 28);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Descrizione :";
            // 
            // txDescrizione
            // 
            this.txDescrizione.Location = new System.Drawing.Point(17, 111);
            this.txDescrizione.Name = "txDescrizione";
            this.txDescrizione.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescrizione.Properties.Appearance.Options.UseFont = true;
            this.txDescrizione.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txDescrizione.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txDescrizione.Size = new System.Drawing.Size(609, 34);
            this.txDescrizione.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(15, 586);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(608, 16);
            this.labelControl6.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(322, 608);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 54);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Annulla";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOK.ImageOptions.SvgImage")));
            this.btnOK.Location = new System.Drawing.Point(156, 608);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(160, 54);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 151);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(130, 28);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Um vendita :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(227, 234);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(144, 28);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "um dosaggio :";
            // 
            // txQtaDiluizione
            // 
            this.txQtaDiluizione.EditValue = "0";
            this.txQtaDiluizione.Location = new System.Drawing.Point(17, 268);
            this.txQtaDiluizione.Name = "txQtaDiluizione";
            this.txQtaDiluizione.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQtaDiluizione.Properties.Appearance.Options.UseFont = true;
            this.txQtaDiluizione.Properties.Appearance.Options.UseTextOptions = true;
            this.txQtaDiluizione.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txQtaDiluizione.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txQtaDiluizione.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txQtaDiluizione.Properties.Mask.EditMask = "f0";
            this.txQtaDiluizione.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txQtaDiluizione.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txQtaDiluizione.Size = new System.Drawing.Size(204, 34);
            this.txQtaDiluizione.TabIndex = 18;
            // 
            // txDiluizione
            // 
            this.txDiluizione.EditValue = "0";
            this.txDiluizione.Location = new System.Drawing.Point(419, 268);
            this.txDiluizione.Name = "txDiluizione";
            this.txDiluizione.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDiluizione.Properties.Appearance.Options.UseFont = true;
            this.txDiluizione.Properties.Appearance.Options.UseTextOptions = true;
            this.txDiluizione.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txDiluizione.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txDiluizione.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txDiluizione.Properties.Mask.EditMask = "f0";
            this.txDiluizione.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txDiluizione.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txDiluizione.Size = new System.Drawing.Size(142, 34);
            this.txDiluizione.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(419, 234);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 28);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "su :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(242, 151);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(111, 28);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Categoria :";
            // 
            // lkCategoria
            // 
            this.lkCategoria.Location = new System.Drawing.Point(242, 185);
            this.lkCategoria.Name = "lkCategoria";
            this.lkCategoria.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkCategoria.Properties.Appearance.Options.UseFont = true;
            this.lkCategoria.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkCategoria.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCategoria.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 124, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkCategoria.Properties.DataSource = this.bndCategorie;
            this.lkCategoria.Properties.DisplayMember = "Descrizione";
            this.lkCategoria.Properties.NullText = "<Seleziona>";
            this.lkCategoria.Properties.ShowFooter = false;
            this.lkCategoria.Properties.ShowHeader = false;
            this.lkCategoria.Properties.ValueMember = "Codice";
            this.lkCategoria.Size = new System.Drawing.Size(381, 34);
            this.lkCategoria.TabIndex = 22;
            // 
            // bndCategorie
            // 
            this.bndCategorie.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.CategoriaCollection);
            // 
            // txNote
            // 
            this.txNote.Location = new System.Drawing.Point(17, 318);
            this.txNote.Name = "txNote";
            this.txNote.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNote.Properties.Appearance.Options.UseFont = true;
            this.txNote.Size = new System.Drawing.Size(606, 96);
            this.txNote.TabIndex = 23;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(585, 271);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(18, 28);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "hl";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(17, 234);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(102, 28);
            this.labelControl8.TabIndex = 26;
            this.labelControl8.Text = "qta dose :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(18, 12);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(254, 28);
            this.labelControl9.TabIndex = 27;
            this.labelControl9.Text = "Codice articolo fornitore :";
            // 
            // txCodiceArticoloFor
            // 
            this.txCodiceArticoloFor.Location = new System.Drawing.Point(338, 12);
            this.txCodiceArticoloFor.Name = "txCodiceArticoloFor";
            this.txCodiceArticoloFor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCodiceArticoloFor.Properties.Appearance.Options.UseFont = true;
            this.txCodiceArticoloFor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txCodiceArticoloFor.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txCodiceArticoloFor.Size = new System.Drawing.Size(288, 34);
            this.txCodiceArticoloFor.TabIndex = 28;
            // 
            // bndUmVendita
            // 
            this.bndUmVendita.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.UnitaMisuraCollection);
            // 
            // bndUmDosaggio
            // 
            this.bndUmDosaggio.DataSource = typeof(ShellDotSp.Plugin.GariglioCore.Model.UnitaMisuraCollection);
            // 
            // lkUmVendita
            // 
            this.lkUmVendita.Location = new System.Drawing.Point(17, 185);
            this.lkUmVendita.Name = "lkUmVendita";
            this.lkUmVendita.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkUmVendita.Properties.Appearance.Options.UseFont = true;
            this.lkUmVendita.Properties.Appearance.Options.UseTextOptions = true;
            this.lkUmVendita.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lkUmVendita.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkUmVendita.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkUmVendita.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUmVendita.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 124, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkUmVendita.Properties.DataSource = this.bndUmVendita;
            this.lkUmVendita.Properties.DisplayMember = "Descrizione";
            this.lkUmVendita.Properties.NullText = "<sel>";
            this.lkUmVendita.Properties.ShowFooter = false;
            this.lkUmVendita.Properties.ShowHeader = false;
            this.lkUmVendita.Properties.ShowLines = false;
            this.lkUmVendita.Properties.ValueMember = "Codice";
            this.lkUmVendita.Size = new System.Drawing.Size(204, 34);
            this.lkUmVendita.TabIndex = 31;
            // 
            // lkUmDosaggio
            // 
            this.lkUmDosaggio.Location = new System.Drawing.Point(227, 268);
            this.lkUmDosaggio.Name = "lkUmDosaggio";
            this.lkUmDosaggio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkUmDosaggio.Properties.Appearance.Options.UseFont = true;
            this.lkUmDosaggio.Properties.Appearance.Options.UseTextOptions = true;
            this.lkUmDosaggio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lkUmDosaggio.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkUmDosaggio.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkUmDosaggio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUmDosaggio.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descrizione", "Descrizione", 124, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkUmDosaggio.Properties.DataSource = this.bndUmDosaggio;
            this.lkUmDosaggio.Properties.DisplayMember = "Descrizione";
            this.lkUmDosaggio.Properties.NullText = "<sel>";
            this.lkUmDosaggio.Properties.ShowFooter = false;
            this.lkUmDosaggio.Properties.ShowHeader = false;
            this.lkUmDosaggio.Properties.ShowLines = false;
            this.lkUmDosaggio.Properties.ValueMember = "Codice";
            this.lkUmDosaggio.Size = new System.Drawing.Size(186, 34);
            this.lkUmDosaggio.TabIndex = 32;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(18, 433);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(243, 28);
            this.labelControl10.TabIndex = 33;
            this.labelControl10.Text = "Classificazione pericolo :";
            // 
            // txClassificazionePericolo
            // 
            this.txClassificazionePericolo.Location = new System.Drawing.Point(18, 467);
            this.txClassificazionePericolo.Name = "txClassificazionePericolo";
            this.txClassificazionePericolo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txClassificazionePericolo.Properties.Appearance.Options.UseFont = true;
            this.txClassificazionePericolo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txClassificazionePericolo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txClassificazionePericolo.Size = new System.Drawing.Size(609, 34);
            this.txClassificazionePericolo.TabIndex = 34;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(18, 507);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(208, 28);
            this.labelControl11.TabIndex = 35;
            this.labelControl11.Text = "Motivo trattamento :";
            // 
            // txMotivoTrattamento
            // 
            this.txMotivoTrattamento.Location = new System.Drawing.Point(18, 541);
            this.txMotivoTrattamento.Name = "txMotivoTrattamento";
            this.txMotivoTrattamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMotivoTrattamento.Properties.Appearance.Options.UseFont = true;
            this.txMotivoTrattamento.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txMotivoTrattamento.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txMotivoTrattamento.Size = new System.Drawing.Size(609, 34);
            this.txMotivoTrattamento.TabIndex = 37;
            // 
            // FrmArticolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 674);
            this.Controls.Add(this.txMotivoTrattamento);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txClassificazionePericolo);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.lkUmDosaggio);
            this.Controls.Add(this.lkUmVendita);
            this.Controls.Add(this.txCodiceArticoloFor);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txNote);
            this.Controls.Add(this.lkCategoria);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txDiluizione);
            this.Controls.Add(this.txQtaDiluizione);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txDescrizione);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmArticolo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articolo";
            this.Load += new System.EventHandler(this.FrmAnagrafica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txDescrizione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txQtaDiluizione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDiluizione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndCategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCodiceArticoloFor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndUmVendita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndUmDosaggio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUmVendita.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUmDosaggio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txClassificazionePericolo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMotivoTrattamento.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txDescrizione;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bndCategorie;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txQtaDiluizione;
        private DevExpress.XtraEditors.TextEdit txDiluizione;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lkCategoria;
        private DevExpress.XtraEditors.MemoEdit txNote;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txCodiceArticoloFor;
        private System.Windows.Forms.BindingSource bndUmVendita;
        private System.Windows.Forms.BindingSource bndUmDosaggio;
        private DevExpress.XtraEditors.LookUpEdit lkUmVendita;
        private DevExpress.XtraEditors.LookUpEdit lkUmDosaggio;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txClassificazionePericolo;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txMotivoTrattamento;
    }
    }