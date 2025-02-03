namespace ShellDotSp.Plugin.GariglioAnag.UI
    {
    partial class MainControlGariglioAnag
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.btnAnagrafiche = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btnArticoli = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnCategorie = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tileBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 140);
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
            this.tileBar1.MaxId = 4;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Padding = new System.Windows.Forms.Padding(22, 0, 22, 10);
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(1024, 140);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            this.tileBar1.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.tileBar1.WideTileWidth = 160;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.btnAnagrafiche);
            this.tileBarGroup2.Items.Add(this.btnArticoli);
            this.tileBarGroup2.Items.Add(this.btnCategorie);
            this.tileBarGroup2.Name = "tileBarGroup2";
            this.tileBarGroup2.Text = "HOME";
            // 
            // btnAnagrafiche
            // 
            this.btnAnagrafiche.AppearanceItem.Normal.BackColor = System.Drawing.Color.Green;
            this.btnAnagrafiche.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnAnagrafiche.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Text = "Anagrafiche";
            this.btnAnagrafiche.Elements.Add(tileItemElement1);
            this.btnAnagrafiche.Id = 0;
            this.btnAnagrafiche.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btnAnagrafiche.Name = "btnAnagrafiche";
            this.btnAnagrafiche.Tag = "AnagraficheView";
            this.btnAnagrafiche.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.Toolbar_ItemClick);
            // 
            // btnArticoli
            // 
            this.btnArticoli.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnArticoli.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnArticoli.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Text = "Articoli";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.btnArticoli.Elements.Add(tileItemElement2);
            this.btnArticoli.Id = 2;
            this.btnArticoli.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btnArticoli.Name = "btnArticoli";
            this.btnArticoli.Tag = "ArticoliView";
            this.btnArticoli.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.Toolbar_ItemClick);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 140);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1024, 477);
            this.panelDesktop.TabIndex = 1;
            // 
            // btnCategorie
            // 
            this.btnCategorie.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Text = "Categorie";
            this.btnCategorie.Elements.Add(tileItemElement3);
            this.btnCategorie.Id = 3;
            this.btnCategorie.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Tag = "CategorieView";
            this.btnCategorie.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.Toolbar_ItemClick);
            // 
            // MainControlGariglioAnag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Name = "MainControlGariglioAnag";
            this.Size = new System.Drawing.Size(1024, 617);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem btnAnagrafiche;
        private System.Windows.Forms.Panel panelDesktop;
        private DevExpress.XtraBars.Navigation.TileBarItem btnArticoli;
        private DevExpress.XtraBars.Navigation.TileBarItem btnCategorie;
        }
    }
