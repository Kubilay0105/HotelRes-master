namespace PL.Hotel
{
    partial class frmMisafir
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnOnay = new System.Windows.Forms.Button();
            this.dgwMisafirListesi = new System.Windows.Forms.DataGridView();
            this.btnIptal = new System.Windows.Forms.Button();
            this.gbMisafirKonaklama = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gbMisafirBilgi = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMisafirAdi = new System.Windows.Forms.TextBox();
            this.txtMisafirSoyadi = new System.Windows.Forms.TextBox();
            this.txtMisafirTC = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cbMisafirCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpMisafirDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTC = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.cbAktif = new System.Windows.Forms.CheckBox();
            this.cbTum = new System.Windows.Forms.CheckBox();
            this.dgvMisafirSorgu = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnIptalS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMisafirListesi)).BeginInit();
            this.gbMisafirKonaklama.SuspendLayout();
            this.gbMisafirBilgi.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisafirSorgu)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(1096, 80);
            this.label1.TabIndex = 52;
            this.label1.Text = "Misafir Ekranı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 630);
            this.tabControl1.TabIndex = 53;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.Controls.Add(this.btnOnay);
            this.tabPage1.Controls.Add(this.dgwMisafirListesi);
            this.tabPage1.Controls.Add(this.btnIptal);
            this.tabPage1.Controls.Add(this.gbMisafirKonaklama);
            this.tabPage1.Controls.Add(this.gbMisafirBilgi);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1088, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Misafir Kayıt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(901, 434);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(145, 49);
            this.btnEkle.TabIndex = 64;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnOnay
            // 
            this.btnOnay.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnay.Location = new System.Drawing.Point(901, 487);
            this.btnOnay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(145, 49);
            this.btnOnay.TabIndex = 63;
            this.btnOnay.Text = "ONAYLA";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click_1);
            // 
            // dgwMisafirListesi
            // 
            this.dgwMisafirListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMisafirListesi.Location = new System.Drawing.Point(42, 434);
            this.dgwMisafirListesi.Margin = new System.Windows.Forms.Padding(4);
            this.dgwMisafirListesi.Name = "dgwMisafirListesi";
            this.dgwMisafirListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMisafirListesi.Size = new System.Drawing.Size(769, 138);
            this.dgwMisafirListesi.TabIndex = 62;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Transparent;
            this.btnIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIptal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.Location = new System.Drawing.Point(901, 541);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(145, 49);
            this.btnIptal.TabIndex = 61;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // gbMisafirKonaklama
            // 
            this.gbMisafirKonaklama.Controls.Add(this.textBox3);
            this.gbMisafirKonaklama.Controls.Add(this.label9);
            this.gbMisafirKonaklama.Controls.Add(this.label12);
            this.gbMisafirKonaklama.Controls.Add(this.dateTimePicker1);
            this.gbMisafirKonaklama.Controls.Add(this.txtOdaNo);
            this.gbMisafirKonaklama.Controls.Add(this.label10);
            this.gbMisafirKonaklama.Controls.Add(this.label11);
            this.gbMisafirKonaklama.Controls.Add(this.dateTimePicker2);
            this.gbMisafirKonaklama.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMisafirKonaklama.Location = new System.Drawing.Point(524, 11);
            this.gbMisafirKonaklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMisafirKonaklama.Name = "gbMisafirKonaklama";
            this.gbMisafirKonaklama.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMisafirKonaklama.Size = new System.Drawing.Size(367, 400);
            this.gbMisafirKonaklama.TabIndex = 60;
            this.gbMisafirKonaklama.TabStop = false;
            this.gbMisafirKonaklama.Text = "Konaklama Bilgileri";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(120, 151);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 122);
            this.textBox3.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Giriş Tarihi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "Açıklama:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 30);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 30);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdaNo.Location = new System.Drawing.Point(120, 113);
            this.txtOdaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(73, 30);
            this.txtOdaNo.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Çıkış Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "Oda No:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(120, 68);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(167, 30);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // gbMisafirBilgi
            // 
            this.gbMisafirBilgi.Controls.Add(this.richTextBox1);
            this.gbMisafirBilgi.Controls.Add(this.label8);
            this.gbMisafirBilgi.Controls.Add(this.txtMisafirAdi);
            this.gbMisafirBilgi.Controls.Add(this.txtMisafirSoyadi);
            this.gbMisafirBilgi.Controls.Add(this.txtMisafirTC);
            this.gbMisafirBilgi.Controls.Add(this.txtTelefon);
            this.gbMisafirBilgi.Controls.Add(this.label2);
            this.gbMisafirBilgi.Controls.Add(this.label3);
            this.gbMisafirBilgi.Controls.Add(this.label4);
            this.gbMisafirBilgi.Controls.Add(this.label5);
            this.gbMisafirBilgi.Controls.Add(this.label6);
            this.gbMisafirBilgi.Controls.Add(this.label7);
            this.gbMisafirBilgi.Controls.Add(this.txtMail);
            this.gbMisafirBilgi.Controls.Add(this.cbMisafirCinsiyet);
            this.gbMisafirBilgi.Controls.Add(this.dtpMisafirDogumTarihi);
            this.gbMisafirBilgi.Controls.Add(this.label13);
            this.gbMisafirBilgi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMisafirBilgi.Location = new System.Drawing.Point(96, 11);
            this.gbMisafirBilgi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMisafirBilgi.Name = "gbMisafirBilgi";
            this.gbMisafirBilgi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMisafirBilgi.Size = new System.Drawing.Size(367, 400);
            this.gbMisafirBilgi.TabIndex = 59;
            this.gbMisafirBilgi.TabStop = false;
            this.gbMisafirBilgi.Text = "Misafir Bilgileri";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(147, 299);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(204, 82);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Adres:";
            // 
            // txtMisafirAdi
            // 
            this.txtMisafirAdi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisafirAdi.Location = new System.Drawing.Point(147, 31);
            this.txtMisafirAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMisafirAdi.Name = "txtMisafirAdi";
            this.txtMisafirAdi.Size = new System.Drawing.Size(161, 30);
            this.txtMisafirAdi.TabIndex = 0;
            // 
            // txtMisafirSoyadi
            // 
            this.txtMisafirSoyadi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisafirSoyadi.Location = new System.Drawing.Point(147, 70);
            this.txtMisafirSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMisafirSoyadi.Name = "txtMisafirSoyadi";
            this.txtMisafirSoyadi.Size = new System.Drawing.Size(161, 30);
            this.txtMisafirSoyadi.TabIndex = 1;
            // 
            // txtMisafirTC
            // 
            this.txtMisafirTC.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisafirTC.Location = new System.Drawing.Point(147, 108);
            this.txtMisafirTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMisafirTC.Name = "txtMisafirTC";
            this.txtMisafirTC.Size = new System.Drawing.Size(161, 30);
            this.txtMisafirTC.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(147, 148);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(161, 30);
            this.txtTelefon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cinsiyet:";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(147, 188);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(161, 30);
            this.txtMail.TabIndex = 14;
            // 
            // cbMisafirCinsiyet
            // 
            this.cbMisafirCinsiyet.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMisafirCinsiyet.FormattingEnabled = true;
            this.cbMisafirCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cbMisafirCinsiyet.Location = new System.Drawing.Point(147, 228);
            this.cbMisafirCinsiyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMisafirCinsiyet.Name = "cbMisafirCinsiyet";
            this.cbMisafirCinsiyet.Size = new System.Drawing.Size(111, 31);
            this.cbMisafirCinsiyet.TabIndex = 15;
            // 
            // dtpMisafirDogumTarihi
            // 
            this.dtpMisafirDogumTarihi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMisafirDogumTarihi.Location = new System.Drawing.Point(147, 266);
            this.dtpMisafirDogumTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpMisafirDogumTarihi.Name = "dtpMisafirDogumTarihi";
            this.dtpMisafirDogumTarihi.Size = new System.Drawing.Size(168, 30);
            this.dtpMisafirDogumTarihi.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 23);
            this.label13.TabIndex = 16;
            this.label13.Text = "DoğumTarihi:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnIptalS);
            this.tabPage2.Controls.Add(this.btnSil);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbTC);
            this.tabPage2.Controls.Add(this.tbSoyad);
            this.tabPage2.Controls.Add(this.tbAd);
            this.tabPage2.Controls.Add(this.cbAktif);
            this.tabPage2.Controls.Add(this.cbTum);
            this.tabPage2.Controls.Add(this.dgvMisafirSorgu);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1088, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Misafir Sorgu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(553, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "TC";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(329, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Soyadı";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(159, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Adı";
            // 
            // tbTC
            // 
            this.tbTC.Location = new System.Drawing.Point(585, 77);
            this.tbTC.Name = "tbTC";
            this.tbTC.Size = new System.Drawing.Size(100, 22);
            this.tbTC.TabIndex = 14;
            this.tbTC.TextChanged += new System.EventHandler(this.tbAd_TextChanged);
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(400, 77);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(100, 22);
            this.tbSoyad.TabIndex = 13;
            this.tbSoyad.TextChanged += new System.EventHandler(this.tbAd_TextChanged);
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(203, 79);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(100, 22);
            this.tbAd.TabIndex = 12;
            this.tbAd.TextChanged += new System.EventHandler(this.tbAd_TextChanged);
            // 
            // cbAktif
            // 
            this.cbAktif.AutoSize = true;
            this.cbAktif.Location = new System.Drawing.Point(809, 302);
            this.cbAktif.Name = "cbAktif";
            this.cbAktif.Size = new System.Drawing.Size(57, 21);
            this.cbAktif.TabIndex = 11;
            this.cbAktif.Text = "Aktif";
            this.cbAktif.UseVisualStyleBackColor = true;
            this.cbAktif.Click += new System.EventHandler(this.cbAktif_Click);
            // 
            // cbTum
            // 
            this.cbTum.AutoSize = true;
            this.cbTum.Location = new System.Drawing.Point(809, 249);
            this.cbTum.Name = "cbTum";
            this.cbTum.Size = new System.Drawing.Size(66, 21);
            this.cbTum.TabIndex = 10;
            this.cbTum.Text = "Tümü";
            this.cbTum.UseVisualStyleBackColor = true;
            this.cbTum.Click += new System.EventHandler(this.cbTum_Click);
            // 
            // dgvMisafirSorgu
            // 
            this.dgvMisafirSorgu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMisafirSorgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisafirSorgu.Location = new System.Drawing.Point(122, 160);
            this.dgvMisafirSorgu.Name = "dgvMisafirSorgu";
            this.dgvMisafirSorgu.RowTemplate.Height = 24;
            this.dgvMisafirSorgu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvMisafirSorgu.Size = new System.Drawing.Size(621, 351);
            this.dgvMisafirSorgu.TabIndex = 9;
            this.dgvMisafirSorgu.DoubleClick += new System.EventHandler(this.dgvMisafirSorgu_DoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(809, 420);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 42);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnIptalS
            // 
            this.btnIptalS.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIptalS.Location = new System.Drawing.Point(809, 468);
            this.btnIptalS.Name = "btnIptalS";
            this.btnIptalS.Size = new System.Drawing.Size(98, 48);
            this.btnIptalS.TabIndex = 20;
            this.btnIptalS.Text = "İptal";
            this.btnIptalS.UseVisualStyleBackColor = true;
            this.btnIptalS.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(809, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 48);
            this.button1.TabIndex = 21;
            this.button1.Text = "Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMisafir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 710);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMisafir";
            this.Text = "frmMisafir";
            this.Load += new System.EventHandler(this.frmMisafir_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMisafirListesi)).EndInit();
            this.gbMisafirKonaklama.ResumeLayout(false);
            this.gbMisafirKonaklama.PerformLayout();
            this.gbMisafirBilgi.ResumeLayout(false);
            this.gbMisafirBilgi.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisafirSorgu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.DataGridView dgwMisafirListesi;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.GroupBox gbMisafirKonaklama;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox gbMisafirBilgi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMisafirAdi;
        private System.Windows.Forms.TextBox txtMisafirSoyadi;
        private System.Windows.Forms.TextBox txtMisafirTC;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cbMisafirCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpMisafirDogumTarihi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTC;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.CheckBox cbAktif;
        private System.Windows.Forms.CheckBox cbTum;
        private System.Windows.Forms.DataGridView dgvMisafirSorgu;
        private System.Windows.Forms.Button btnIptalS;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button1;
    }
}