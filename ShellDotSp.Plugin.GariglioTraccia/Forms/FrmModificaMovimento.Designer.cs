
namespace ShellDotSp.Plugin.GariglioTraccia.Forms
{
    partial class FrmModificaMovimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificaMovimento));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitolo = new DevExpress.XtraEditors.LabelControl();
            this.txCausale = new DevExpress.XtraEditors.TextEdit();
            this.txQta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txLotto = new DevExpress.XtraEditors.TextEdit();
            this.txLottoOrigine = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txQtaPrec = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txFormatoConf = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txUbicazione = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txUbicazionePrec = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txCausale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txQta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txLotto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txLottoOrigine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txQtaPrec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txFormatoConf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txUbicazione.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txUbicazionePrec.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(13, 221);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(627, 16);
            this.labelControl6.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(334, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 54);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Annulla";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOK.ImageOptions.SvgImage")));
            this.btnOK.Location = new System.Drawing.Point(168, 243);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(160, 54);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTitolo
            // 
            this.lblTitolo.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Appearance.Options.UseFont = true;
            this.lblTitolo.Location = new System.Drawing.Point(12, 21);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(62, 16);
            this.lblTitolo.TabIndex = 24;
            this.lblTitolo.Text = "CAUSALE :";
            // 
            // txCausale
            // 
            this.txCausale.EditValue = "";
            this.txCausale.Location = new System.Drawing.Point(12, 43);
            this.txCausale.Name = "txCausale";
            this.txCausale.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCausale.Properties.Appearance.Options.UseFont = true;
            this.txCausale.Properties.Appearance.Options.UseTextOptions = true;
            this.txCausale.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txCausale.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txCausale.Properties.ReadOnly = true;
            this.txCausale.Size = new System.Drawing.Size(205, 40);
            this.txCausale.TabIndex = 23;
            // 
            // txQta
            // 
            this.txQta.EditValue = "0";
            this.txQta.Location = new System.Drawing.Point(12, 111);
            this.txQta.Name = "txQta";
            this.txQta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQta.Properties.Appearance.Options.UseFont = true;
            this.txQta.Properties.Appearance.Options.UseTextOptions = true;
            this.txQta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txQta.Properties.Mask.EditMask = "f3";
            this.txQta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txQta.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txQta.Size = new System.Drawing.Size(205, 40);
            this.txQta.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(223, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 16);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "LOTTO :";
            // 
            // txLotto
            // 
            this.txLotto.EditValue = "";
            this.txLotto.Location = new System.Drawing.Point(223, 43);
            this.txLotto.Name = "txLotto";
            this.txLotto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLotto.Properties.Appearance.Options.UseFont = true;
            this.txLotto.Properties.Appearance.Options.UseTextOptions = true;
            this.txLotto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txLotto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txLotto.Size = new System.Drawing.Size(205, 40);
            this.txLotto.TabIndex = 27;
            // 
            // txLottoOrigine
            // 
            this.txLottoOrigine.EditValue = "";
            this.txLottoOrigine.Location = new System.Drawing.Point(434, 43);
            this.txLottoOrigine.Name = "txLottoOrigine";
            this.txLottoOrigine.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLottoOrigine.Properties.Appearance.Options.UseFont = true;
            this.txLottoOrigine.Properties.Appearance.Options.UseTextOptions = true;
            this.txLottoOrigine.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txLottoOrigine.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txLottoOrigine.Size = new System.Drawing.Size(205, 40);
            this.txLottoOrigine.TabIndex = 28;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(434, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 16);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "LOTTO ORIGINE :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 16);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "QTA :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(223, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 16);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "QTA PREC. :";
            // 
            // txQtaPrec
            // 
            this.txQtaPrec.EditValue = "0";
            this.txQtaPrec.Location = new System.Drawing.Point(223, 111);
            this.txQtaPrec.Name = "txQtaPrec";
            this.txQtaPrec.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQtaPrec.Properties.Appearance.Options.UseFont = true;
            this.txQtaPrec.Properties.Appearance.Options.UseTextOptions = true;
            this.txQtaPrec.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txQtaPrec.Properties.Mask.EditMask = "f3";
            this.txQtaPrec.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txQtaPrec.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txQtaPrec.Size = new System.Drawing.Size(205, 40);
            this.txQtaPrec.TabIndex = 32;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(434, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(108, 16);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "FORMATO CONF. :";
            // 
            // txFormatoConf
            // 
            this.txFormatoConf.EditValue = "";
            this.txFormatoConf.Location = new System.Drawing.Point(434, 111);
            this.txFormatoConf.Name = "txFormatoConf";
            this.txFormatoConf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFormatoConf.Properties.Appearance.Options.UseFont = true;
            this.txFormatoConf.Properties.Appearance.Options.UseTextOptions = true;
            this.txFormatoConf.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txFormatoConf.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txFormatoConf.Size = new System.Drawing.Size(205, 40);
            this.txFormatoConf.TabIndex = 34;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(118, 157);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 16);
            this.labelControl7.TabIndex = 35;
            this.labelControl7.Text = "UBICAZIONE :";
            // 
            // txUbicazione
            // 
            this.txUbicazione.EditValue = "";
            this.txUbicazione.Location = new System.Drawing.Point(118, 179);
            this.txUbicazione.Name = "txUbicazione";
            this.txUbicazione.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUbicazione.Properties.Appearance.Options.UseFont = true;
            this.txUbicazione.Properties.Appearance.Options.UseTextOptions = true;
            this.txUbicazione.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txUbicazione.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txUbicazione.Size = new System.Drawing.Size(205, 40);
            this.txUbicazione.TabIndex = 36;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(329, 157);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(121, 16);
            this.labelControl8.TabIndex = 37;
            this.labelControl8.Text = "UBICAZIONE PREC . :";
            // 
            // txUbicazionePrec
            // 
            this.txUbicazionePrec.EditValue = "";
            this.txUbicazionePrec.Location = new System.Drawing.Point(329, 179);
            this.txUbicazionePrec.Name = "txUbicazionePrec";
            this.txUbicazionePrec.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUbicazionePrec.Properties.Appearance.Options.UseFont = true;
            this.txUbicazionePrec.Properties.Appearance.Options.UseTextOptions = true;
            this.txUbicazionePrec.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txUbicazionePrec.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txUbicazionePrec.Size = new System.Drawing.Size(205, 40);
            this.txUbicazionePrec.TabIndex = 38;
            // 
            // FrmModificaMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 304);
            this.Controls.Add(this.txUbicazionePrec);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txUbicazione);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txFormatoConf);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txQtaPrec);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txLottoOrigine);
            this.Controls.Add(this.txLotto);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txQta);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.txCausale);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificaMovimento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica movimento";
            this.Load += new System.EventHandler(this.FrmModificaMovimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txCausale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txQta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txLotto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txLottoOrigine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txQtaPrec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txFormatoConf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txUbicazione.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txUbicazionePrec.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl lblTitolo;
        private DevExpress.XtraEditors.TextEdit txCausale;
        private DevExpress.XtraEditors.TextEdit txQta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txLotto;
        private DevExpress.XtraEditors.TextEdit txLottoOrigine;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txQtaPrec;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txFormatoConf;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txUbicazione;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txUbicazionePrec;
    }
}