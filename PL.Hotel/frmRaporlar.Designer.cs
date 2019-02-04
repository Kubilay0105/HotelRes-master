namespace PL.Hotel
{
    partial class frmRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporlar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsRaporlar = new System.Windows.Forms.ToolStrip();
            this.tsGunlukKasaHareketleri = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMusteriHareketler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tsPersonel = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.tsRaporlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.tsRaporlar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 51);
            this.panel1.TabIndex = 0;
            // 
            // tsRaporlar
            // 
            this.tsRaporlar.AutoSize = false;
            this.tsRaporlar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tsRaporlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGunlukKasaHareketleri,
            this.toolStripSeparator1,
            this.tsMusteriHareketler,
            this.toolStripSeparator2,
            this.tsPersonel});
            this.tsRaporlar.Location = new System.Drawing.Point(0, 0);
            this.tsRaporlar.Name = "tsRaporlar";
            this.tsRaporlar.Size = new System.Drawing.Size(987, 48);
            this.tsRaporlar.TabIndex = 1;
            this.tsRaporlar.Text = "toolStrip1";
            // 
            // tsGunlukKasaHareketleri
            // 
            this.tsGunlukKasaHareketleri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsGunlukKasaHareketleri.Image = ((System.Drawing.Image)(resources.GetObject("tsGunlukKasaHareketleri.Image")));
            this.tsGunlukKasaHareketleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGunlukKasaHareketleri.Name = "tsGunlukKasaHareketleri";
            this.tsGunlukKasaHareketleri.Size = new System.Drawing.Size(95, 45);
            this.tsGunlukKasaHareketleri.Text = "Kasa Hareketleri";
            this.tsGunlukKasaHareketleri.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsGunlukKasaHareketleri.Click += new System.EventHandler(this.tsGunlukKasaHareketleri_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // tsMusteriHareketler
            // 
            this.tsMusteriHareketler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMusteriHareketler.Image = ((System.Drawing.Image)(resources.GetObject("tsMusteriHareketler.Image")));
            this.tsMusteriHareketler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMusteriHareketler.Name = "tsMusteriHareketler";
            this.tsMusteriHareketler.Size = new System.Drawing.Size(108, 45);
            this.tsMusteriHareketler.Text = "Müşteri Hareketler";
            this.tsMusteriHareketler.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsMusteriHareketler.Click += new System.EventHandler(this.tsMusteriHareketler_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 51);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(987, 531);
            this.pnlContent.TabIndex = 1;
            // 
            // tsPersonel
            // 
            this.tsPersonel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsPersonel.Image = ((System.Drawing.Image)(resources.GetObject("tsPersonel.Image")));
            this.tsPersonel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPersonel.Name = "tsPersonel";
            this.tsPersonel.Size = new System.Drawing.Size(99, 45);
            this.tsPersonel.Text = "Personel Satışları";
            this.tsPersonel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsPersonel.Click += new System.EventHandler(this.tsPersonel_Click);
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 582);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.Name = "frmRaporlar";
            this.Text = "frmRaporlar";
            this.panel1.ResumeLayout(false);
            this.tsRaporlar.ResumeLayout(false);
            this.tsRaporlar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsRaporlar;
        private System.Windows.Forms.ToolStripButton tsGunlukKasaHareketleri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsMusteriHareketler;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripButton tsPersonel;
    }
}