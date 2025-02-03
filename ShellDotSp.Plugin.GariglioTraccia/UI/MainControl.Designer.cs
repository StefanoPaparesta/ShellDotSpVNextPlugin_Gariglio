namespace ShellDotSp.Plugin.GariglioTraccia.UI
    {
    partial class MainControlGariglioTraccia
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btnAnagrafiche = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btnDestinazioni = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btnCicliProduzione = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btnReport = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btnImportaIrrigazioni = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tileBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 140);
            this.panel1.TabIndex = 0;
            // 
            // tileBar1
            // 
            this.tileBar1.AppearanceGroupText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar1.AppearanceGroupText.Options.UseFont = true;
            this.tileBar1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar1.AppearanceText.Options.UseFont = true;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.GroupTextToItemsIndent = 10;
            this.tileBar1.ItemSize = 80;
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 6;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Padding = new System.Windows.Forms.Padding(22, 0, 22, 10);
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(1166, 140);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            this.tileBar1.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.tileBar1.WideTileWidth = 160;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tileBarItem1);
            this.tileBarGroup2.Items.Add(this.btnAnagrafiche);
            this.tileBarGroup2.Items.Add(this.btnDestinazioni);
            this.tileBarGroup2.Items.Add(this.btnCicliProduzione);
            this.tileBarGroup2.Items.Add(this.btnReport);
            this.tileBarGroup2.Items.Add(this.btnImportaIrrigazioni);
            this.tileBarGroup2.Name = "tileBarGroup2";
            this.tileBarGroup2.Text = "HOME";
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tileBarItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Text = "Tracciabilità";
            this.tileBarItem1.Elements.Add(tileItemElement1);
            this.tileBarItem1.Id = 5;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            this.tileBarItem1.Tag = "TracciaView";
            this.tileBarItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.Toolbar_ItemClick);
            // 
            // btnAnagrafiche
            // 
            this.btnAnagrafiche.AppearanceItem.Normal.BackColor = System.Drawing.Color.Green;
            this.btnAnagrafiche.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnAnagrafiche.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Text = "Ubicazioni";
            this.btnAnagrafiche.Elements.Add(tileItemElement2);
            this.btnAnagrafiche.Id = 0;
            this.btnAnagrafiche.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btnAnagrafiche.Name = "btnAnagrafiche";
            this.btnAnagrafiche.Tag = "UbicazioniAttiveView";
            this.btnAnagrafiche.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.Toolbar_ItemClick);
            // 
            // btnDestinazioni
            // 
            this.btnDestinazioni.AppearanceItem.Normal.BackColor = System.Drawing.Color.Yellow;
            this.btnDestinazioni.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.btnDestinazioni.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnDestinazioni.AppearanceItem.Normal.Options.UseForeColor = true;
            this.btnDestinazioni.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Text = "Storico Ubicazioni";
            this.btnDestinazioni.Elements.Add(tileItemElement3);
            this.btnDestinazioni.Id = 1;
            this.btnDestinazioni.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btnDestinazioni.Name = "btnDestinazioni";
            this.btnDestinazioni.Tag = "StoricoUbicazioniView";
            this.btnDestinazioni.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.Toolbar_ItemClick);
            // 
            // btnCicliProduzione
            // 
            this.btnCicliProduzione.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCicliProduzione.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnCicliProduzione.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.Text = "Cicli produzione";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.btnCicliProduzione.Elements.Add(tileItemElement4);
            this.btnCicliProduzione.Id = 2;
            this.btnCicliProduzione.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btnCicliProduzione.Name = "btnCicliProduzione";
            this.btnCicliProduzione.Tag = "CicliProduzioneView";
            this.btnCicliProduzione.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.Toolbar_ItemClick);
            // 
            // btnReport
            // 
            this.btnReport.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement5.Appearance.Normal.Options.UseFont = true;
            tileItemElement5.Text = "Report";
            this.btnReport.Elements.Add(tileItemElement5);
            this.btnReport.Id = 3;
            this.btnReport.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btnReport.Name = "btnReport";
            this.btnReport.Tag = "ReportView";
            this.btnReport.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.Toolbar_ItemClick);
            // 
            // btnImportaIrrigazioni
            // 
            this.btnImportaIrrigazioni.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement6.Appearance.Normal.Options.UseFont = true;
            tileItemElement6.Text = "Importa irrigazioni";
            this.btnImportaIrrigazioni.Elements.Add(tileItemElement6);
            this.btnImportaIrrigazioni.Id = 4;
            this.btnImportaIrrigazioni.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btnImportaIrrigazioni.Name = "btnImportaIrrigazioni";
            this.btnImportaIrrigazioni.Tag = "ImportaIrrigazioniView";
            this.btnImportaIrrigazioni.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.Toolbar_ItemClick);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 140);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1166, 477);
            this.panelDesktop.TabIndex = 1;
            // 
            // MainControlGariglioTraccia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Name = "MainControlGariglioTraccia";
            this.Size = new System.Drawing.Size(1166, 617);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem btnAnagrafiche;
        private DevExpress.XtraBars.Navigation.TileBarItem btnDestinazioni;
        private System.Windows.Forms.Panel panelDesktop;
        private DevExpress.XtraBars.Navigation.TileBarItem btnCicliProduzione;
        private DevExpress.XtraBars.Navigation.TileBarItem btnReport;
        private DevExpress.XtraBars.Navigation.TileBarItem btnImportaIrrigazioni;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
    }
    }
