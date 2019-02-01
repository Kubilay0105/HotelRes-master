namespace PL.Hotel
{
    partial class frmPersonelExtra
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
            this.pnlContext = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmAnasayfa = new System.Windows.Forms.ToolStripMenuItem();
            this.msPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContext
            // 
            this.pnlContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContext.Location = new System.Drawing.Point(0, 52);
            this.pnlContext.Name = "pnlContext";
            this.pnlContext.Size = new System.Drawing.Size(800, 398);
            this.pnlContext.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAnasayfa,
            this.msPersonel,
            this.ekstraİşlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 52);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmAnasayfa
            // 
            this.tsmAnasayfa.AutoSize = false;
            this.tsmAnasayfa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmAnasayfa.Name = "tsmAnasayfa";
            this.tsmAnasayfa.Size = new System.Drawing.Size(170, 40);
            this.tsmAnasayfa.Text = "Anasayfa";
            this.tsmAnasayfa.Click += new System.EventHandler(this.tsmAnasayfa_Click);
            // 
            // msPersonel
            // 
            this.msPersonel.AutoSize = false;
            this.msPersonel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.personelGüncelleToolStripMenuItem,
            this.personelSilToolStripMenuItem});
            this.msPersonel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.msPersonel.Name = "msPersonel";
            this.msPersonel.Size = new System.Drawing.Size(170, 40);
            this.msPersonel.Text = "Personel İşlemleri";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // personelGüncelleToolStripMenuItem
            // 
            this.personelGüncelleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.personelGüncelleToolStripMenuItem.Name = "personelGüncelleToolStripMenuItem";
            this.personelGüncelleToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.personelGüncelleToolStripMenuItem.Text = "Personel Güncelle";
            this.personelGüncelleToolStripMenuItem.Click += new System.EventHandler(this.personelGüncelleToolStripMenuItem_Click);
            // 
            // personelSilToolStripMenuItem
            // 
            this.personelSilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.personelSilToolStripMenuItem.Name = "personelSilToolStripMenuItem";
            this.personelSilToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.personelSilToolStripMenuItem.Text = "Personel Sil";
            this.personelSilToolStripMenuItem.Click += new System.EventHandler(this.personelSilToolStripMenuItem_Click);
            // 
            // ekstraİşlemlerToolStripMenuItem
            // 
            this.ekstraİşlemlerToolStripMenuItem.AutoSize = false;
            this.ekstraİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekstraEkleToolStripMenuItem,
            this.ekstraGüncelleToolStripMenuItem,
            this.ekstraSilToolStripMenuItem});
            this.ekstraİşlemlerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ekstraİşlemlerToolStripMenuItem.Name = "ekstraİşlemlerToolStripMenuItem";
            this.ekstraİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(170, 40);
            this.ekstraİşlemlerToolStripMenuItem.Text = "Ekstra İşlemler";
            // 
            // ekstraEkleToolStripMenuItem
            // 
            this.ekstraEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ekstraEkleToolStripMenuItem.Name = "ekstraEkleToolStripMenuItem";
            this.ekstraEkleToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.ekstraEkleToolStripMenuItem.Text = "Ekstra Ekle";
            this.ekstraEkleToolStripMenuItem.Click += new System.EventHandler(this.ekstraEkleToolStripMenuItem_Click);
            // 
            // ekstraGüncelleToolStripMenuItem
            // 
            this.ekstraGüncelleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ekstraGüncelleToolStripMenuItem.Name = "ekstraGüncelleToolStripMenuItem";
            this.ekstraGüncelleToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.ekstraGüncelleToolStripMenuItem.Text = "Ekstra Güncelle";
            this.ekstraGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ekstraGüncelleToolStripMenuItem_Click);
            // 
            // ekstraSilToolStripMenuItem
            // 
            this.ekstraSilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ekstraSilToolStripMenuItem.Name = "ekstraSilToolStripMenuItem";
            this.ekstraSilToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.ekstraSilToolStripMenuItem.Text = "Ekstra Sil";
            this.ekstraSilToolStripMenuItem.Click += new System.EventHandler(this.ekstraSilToolStripMenuItem_Click);
            // 
            // frmPersonelExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContext);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonelExtra";
            this.Text = "frmPersonelExtra";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAnasayfa;
        private System.Windows.Forms.ToolStripMenuItem msPersonel;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraSilToolStripMenuItem;
    }
}