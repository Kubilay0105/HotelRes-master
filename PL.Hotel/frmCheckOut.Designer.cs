namespace PL.Hotel
{
    partial class frmCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckOut));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.btnCikisOnayla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBorc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKazanc = new System.Windows.Forms.TextBox();
            this.txtKalanBorc = new System.Windows.Forms.TextBox();
            this.gbMüsteriBilgileri = new System.Windows.Forms.GroupBox();
            this.btnBorcSorgula = new System.Windows.Forms.Button();
            this.txtTKCNO = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.ppdCikisFatura = new System.Windows.Forms.PrintPreviewDialog();
            this.pdFatura = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMüsteriBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çıkış İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnYazdir);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.btnOdemeYap);
            this.panel1.Controls.Add(this.btnCikisOnayla);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbMüsteriBilgileri);
            this.panel1.Controls.Add(this.dtpTarih);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 370);
            this.panel1.TabIndex = 3;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(459, 312);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(125, 44);
            this.btnIptal.TabIndex = 103;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(589, 263);
            this.btnOdemeYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(136, 44);
            this.btnOdemeYap.TabIndex = 106;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // btnCikisOnayla
            // 
            this.btnCikisOnayla.Location = new System.Drawing.Point(459, 263);
            this.btnCikisOnayla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCikisOnayla.Name = "btnCikisOnayla";
            this.btnCikisOnayla.Size = new System.Drawing.Size(125, 44);
            this.btnCikisOnayla.TabIndex = 105;
            this.btnCikisOnayla.Text = "Çıkış Onayla";
            this.btnCikisOnayla.UseVisualStyleBackColor = true;
            this.btnCikisOnayla.Click += new System.EventHandler(this.btnCikisOnayla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBorc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtKazanc);
            this.groupBox1.Controls.Add(this.txtKalanBorc);
            this.groupBox1.Location = new System.Drawing.Point(459, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(255, 155);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Bilgileri";
            // 
            // txtBorc
            // 
            this.txtBorc.Location = new System.Drawing.Point(89, 36);
            this.txtBorc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBorc.Name = "txtBorc";
            this.txtBorc.ReadOnly = true;
            this.txtBorc.Size = new System.Drawing.Size(119, 22);
            this.txtBorc.TabIndex = 69;
            this.txtBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 89;
            this.label9.Text = "Borç";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 102);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 91;
            this.label14.Text = "Kalan";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 70);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 90;
            this.label13.Text = "Ödenen";
            // 
            // txtKazanc
            // 
            this.txtKazanc.Location = new System.Drawing.Point(89, 66);
            this.txtKazanc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKazanc.Name = "txtKazanc";
            this.txtKazanc.ReadOnly = true;
            this.txtKazanc.Size = new System.Drawing.Size(119, 22);
            this.txtKazanc.TabIndex = 85;
            this.txtKazanc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKalanBorc
            // 
            this.txtKalanBorc.Location = new System.Drawing.Point(89, 98);
            this.txtKalanBorc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKalanBorc.Name = "txtKalanBorc";
            this.txtKalanBorc.ReadOnly = true;
            this.txtKalanBorc.Size = new System.Drawing.Size(119, 22);
            this.txtKalanBorc.TabIndex = 70;
            this.txtKalanBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbMüsteriBilgileri
            // 
            this.gbMüsteriBilgileri.Controls.Add(this.btnBorcSorgula);
            this.gbMüsteriBilgileri.Controls.Add(this.txtTKCNO);
            this.gbMüsteriBilgileri.Controls.Add(this.dateTimePicker1);
            this.gbMüsteriBilgileri.Controls.Add(this.textBox2);
            this.gbMüsteriBilgileri.Controls.Add(this.label5);
            this.gbMüsteriBilgileri.Controls.Add(this.label4);
            this.gbMüsteriBilgileri.Controls.Add(this.label3);
            this.gbMüsteriBilgileri.Controls.Add(this.txtOdaNo);
            this.gbMüsteriBilgileri.Controls.Add(this.label15);
            this.gbMüsteriBilgileri.Controls.Add(this.label17);
            this.gbMüsteriBilgileri.Controls.Add(this.txtAdi);
            this.gbMüsteriBilgileri.Controls.Add(this.txtSoyadi);
            this.gbMüsteriBilgileri.Controls.Add(this.label16);
            this.gbMüsteriBilgileri.Location = new System.Drawing.Point(57, 66);
            this.gbMüsteriBilgileri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMüsteriBilgileri.Name = "gbMüsteriBilgileri";
            this.gbMüsteriBilgileri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMüsteriBilgileri.Size = new System.Drawing.Size(339, 290);
            this.gbMüsteriBilgileri.TabIndex = 100;
            this.gbMüsteriBilgileri.TabStop = false;
            this.gbMüsteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // btnBorcSorgula
            // 
            this.btnBorcSorgula.Location = new System.Drawing.Point(128, 240);
            this.btnBorcSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorcSorgula.Name = "btnBorcSorgula";
            this.btnBorcSorgula.Size = new System.Drawing.Size(136, 44);
            this.btnBorcSorgula.TabIndex = 102;
            this.btnBorcSorgula.Text = "Borç Sorgula";
            this.btnBorcSorgula.UseVisualStyleBackColor = true;
            this.btnBorcSorgula.Click += new System.EventHandler(this.btnBorcSorgula_Click);
            // 
            // txtTKCNO
            // 
            this.txtTKCNO.Location = new System.Drawing.Point(128, 133);
            this.txtTKCNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTKCNO.Name = "txtTKCNO";
            this.txtTKCNO.Size = new System.Drawing.Size(185, 22);
            this.txtTKCNO.TabIndex = 104;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 162);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 22);
            this.dateTimePicker1.TabIndex = 102;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 198);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 22);
            this.textBox2.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 103;
            this.label5.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "Kişi Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 98;
            this.label3.Text = "Giriş Tarihi:";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(128, 102);
            this.txtOdaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(185, 22);
            this.txtOdaNo.TabIndex = 97;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 17);
            this.label15.TabIndex = 92;
            this.label15.Text = "Adı";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 96;
            this.label17.Text = "Oda No:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(128, 33);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(185, 22);
            this.txtAdi.TabIndex = 93;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(128, 68);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(185, 22);
            this.txtSoyadi.TabIndex = 95;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 17);
            this.label16.TabIndex = 94;
            this.label16.Text = "Soyadı";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(115, 26);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(193, 22);
            this.dtpTarih.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Tarih";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(590, 311);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(136, 44);
            this.btnYazdir.TabIndex = 107;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.button1_Click);
            // 
            // ppdCikisFatura
            // 
            this.ppdCikisFatura.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdCikisFatura.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdCikisFatura.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdCikisFatura.Document = this.pdFatura;
            this.ppdCikisFatura.Enabled = true;
            this.ppdCikisFatura.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdCikisFatura.Icon")));
            this.ppdCikisFatura.Name = "ppdCikisFatura";
            this.ppdCikisFatura.Visible = false;
            // 
            // pdFatura
            // 
            this.pdFatura.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdFatura_PrintPage);
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCheckOut";
            this.Text = "frmCheckOut";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMüsteriBilgileri.ResumeLayout(false);
            this.gbMüsteriBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBorc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKazanc;
        private System.Windows.Forms.TextBox txtKalanBorc;
        private System.Windows.Forms.GroupBox gbMüsteriBilgileri;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Button btnCikisOnayla;
        private System.Windows.Forms.Button btnBorcSorgula;
        private System.Windows.Forms.TextBox txtTKCNO;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.PrintPreviewDialog ppdCikisFatura;
        private System.Drawing.Printing.PrintDocument pdFatura;
    }
}