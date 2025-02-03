
namespace ShellDotSp.Plugin.GariglioTraccia.Forms
{
    partial class FrmCambiaQta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiaQta));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTipoMovimento = new DevExpress.XtraEditors.LabelControl();
            this.lblUbicazione = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txQta = new DevExpress.XtraEditors.TextEdit();
            this.txQtaPrecedente = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txQta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txQtaPrecedente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelControl2.Size = new System.Drawing.Size(468, 29);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Modifica Quantità";
            // 
            // lblTipoMovimento
            // 
            this.lblTipoMovimento.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMovimento.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblTipoMovimento.Appearance.Options.UseFont = true;
            this.lblTipoMovimento.Appearance.Options.UseForeColor = true;
            this.lblTipoMovimento.Appearance.Options.UseTextOptions = true;
            this.lblTipoMovimento.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTipoMovimento.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTipoMovimento.Location = new System.Drawing.Point(12, 60);
            this.lblTipoMovimento.Name = "lblTipoMovimento";
            this.lblTipoMovimento.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTipoMovimento.Size = new System.Drawing.Size(468, 29);
            this.lblTipoMovimento.TabIndex = 6;
            this.lblTipoMovimento.Text = "CARICO\\SCARICO";
            // 
            // lblUbicazione
            // 
            this.lblUbicazione.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicazione.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblUbicazione.Appearance.Options.UseFont = true;
            this.lblUbicazione.Appearance.Options.UseForeColor = true;
            this.lblUbicazione.Appearance.Options.UseTextOptions = true;
            this.lblUbicazione.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblUbicazione.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUbicazione.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblUbicazione.Location = new System.Drawing.Point(12, 105);
            this.lblUbicazione.Name = "lblUbicazione";
            this.lblUbicazione.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblUbicazione.Size = new System.Drawing.Size(468, 47);
            this.lblUbicazione.TabIndex = 7;
            this.lblUbicazione.Text = "#";
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(8, 336);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(468, 16);
            this.labelControl6.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(245, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 54);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "&Annulla";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOK.ImageOptions.SvgImage")));
            this.btnOK.Location = new System.Drawing.Point(45, 368);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(194, 54);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "&CONFERMO";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(12, 180);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelControl3.Size = new System.Drawing.Size(167, 47);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Qta :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 248);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(167, 47);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Qta precedente :";
            // 
            // txQta
            // 
            this.txQta.EditValue = "0";
            this.txQta.Location = new System.Drawing.Point(282, 181);
            this.txQta.Name = "txQta";
            this.txQta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQta.Properties.Appearance.Options.UseFont = true;
            this.txQta.Properties.Appearance.Options.UseTextOptions = true;
            this.txQta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txQta.Properties.Mask.EditMask = "f0";
            this.txQta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txQta.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txQta.Size = new System.Drawing.Size(194, 46);
            this.txQta.TabIndex = 24;
            // 
            // txQtaPrecedente
            // 
            this.txQtaPrecedente.EditValue = "0";
            this.txQtaPrecedente.Location = new System.Drawing.Point(282, 249);
            this.txQtaPrecedente.Name = "txQtaPrecedente";
            this.txQtaPrecedente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQtaPrecedente.Properties.Appearance.Options.UseFont = true;
            this.txQtaPrecedente.Properties.Appearance.Options.UseTextOptions = true;
            this.txQtaPrecedente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txQtaPrecedente.Properties.Mask.EditMask = "f0";
            this.txQtaPrecedente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txQtaPrecedente.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txQtaPrecedente.Size = new System.Drawing.Size(194, 46);
            this.txQtaPrecedente.TabIndex = 25;
            // 
            // FrmCambiaQta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 444);
            this.Controls.Add(this.txQtaPrecedente);
            this.Controls.Add(this.txQta);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblUbicazione);
            this.Controls.Add(this.lblTipoMovimento);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCambiaQta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio qta";
            this.Load += new System.EventHandler(this.FrmCambiaQta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txQta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txQtaPrecedente.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblTipoMovimento;
        private DevExpress.XtraEditors.LabelControl lblUbicazione;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txQta;
        private DevExpress.XtraEditors.TextEdit txQtaPrecedente;
    }
}