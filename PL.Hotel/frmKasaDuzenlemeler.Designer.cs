namespace PL.Hotel
{
    partial class frmKasaDuzenlemeler
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.cbIslemTurleri = new System.Windows.Forms.ComboBox();
            this.rbGuest = new System.Windows.Forms.RadioButton();
            this.dgvKasaHareketler = new System.Windows.Forms.DataGridView();
            this.rbPersonel = new System.Windows.Forms.RadioButton();
            this.rbTumu = new System.Windows.Forms.RadioButton();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaHareketler)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 64);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoSize = true;
            this.pnlContent.Controls.Add(this.dtpTarih);
            this.pnlContent.Controls.Add(this.rbTumu);
            this.pnlContent.Controls.Add(this.rbPersonel);
            this.pnlContent.Controls.Add(this.dgvKasaHareketler);
            this.pnlContent.Controls.Add(this.cbIslemTurleri);
            this.pnlContent.Controls.Add(this.rbGuest);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 64);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1000, 486);
            this.pnlContent.TabIndex = 1;
            // 
            // cbIslemTurleri
            // 
            this.cbIslemTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTurleri.FormattingEnabled = true;
            this.cbIslemTurleri.Location = new System.Drawing.Point(24, 18);
            this.cbIslemTurleri.Name = "cbIslemTurleri";
            this.cbIslemTurleri.Size = new System.Drawing.Size(121, 21);
            this.cbIslemTurleri.TabIndex = 2;
            this.cbIslemTurleri.SelectedIndexChanged += new System.EventHandler(this.cbIslemTurleri_SelectedIndexChanged);
            // 
            // rbGuest
            // 
            this.rbGuest.AutoSize = true;
            this.rbGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbGuest.Location = new System.Drawing.Point(505, 17);
            this.rbGuest.Name = "rbGuest";
            this.rbGuest.Size = new System.Drawing.Size(69, 19);
            this.rbGuest.TabIndex = 0;
            this.rbGuest.TabStop = true;
            this.rbGuest.Text = "Misafir";
            this.rbGuest.UseVisualStyleBackColor = true;
            // 
            // dgvKasaHareketler
            // 
            this.dgvKasaHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKasaHareketler.Location = new System.Drawing.Point(24, 45);
            this.dgvKasaHareketler.Name = "dgvKasaHareketler";
            this.dgvKasaHareketler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKasaHareketler.Size = new System.Drawing.Size(649, 243);
            this.dgvKasaHareketler.TabIndex = 3;
            // 
            // rbPersonel
            // 
            this.rbPersonel.AutoSize = true;
            this.rbPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPersonel.Location = new System.Drawing.Point(591, 17);
            this.rbPersonel.Name = "rbPersonel";
            this.rbPersonel.Size = new System.Drawing.Size(82, 19);
            this.rbPersonel.TabIndex = 4;
            this.rbPersonel.TabStop = true;
            this.rbPersonel.Text = "Personel";
            this.rbPersonel.UseVisualStyleBackColor = true;
            // 
            // rbTumu
            // 
            this.rbTumu.AutoSize = true;
            this.rbTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTumu.Location = new System.Drawing.Point(421, 17);
            this.rbTumu.Name = "rbTumu";
            this.rbTumu.Size = new System.Drawing.Size(61, 19);
            this.rbTumu.TabIndex = 8;
            this.rbTumu.TabStop = true;
            this.rbTumu.Text = "Tümü";
            this.rbTumu.UseVisualStyleBackColor = true;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(151, 19);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(102, 20);
            this.dtpTarih.TabIndex = 9;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // frmKasaDuzenlemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKasaDuzenlemeler";
            this.Text = "frmKasaDuzenlemeler";
            this.Load += new System.EventHandler(this.frmKasaDuzenlemeler_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaHareketler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.RadioButton rbPersonel;
        private System.Windows.Forms.DataGridView dgvKasaHareketler;
        private System.Windows.Forms.ComboBox cbIslemTurleri;
        private System.Windows.Forms.RadioButton rbGuest;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.RadioButton rbTumu;
    }
}