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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vw_SonBirYılBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HotelResDataSet = new PL.Hotel.HotelResDataSet();
            this.PaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PaymentsTableAdapter = new PL.Hotel.HotelResDataSetTableAdapters.PaymentsTableAdapter();
            this.vw_SonBirYılTableAdapter = new PL.Hotel.HotelResDataSetTableAdapters.vw_SonBirYılTableAdapter();
            this.vw_AylıkOrtalamaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_AylıkOrtalamaTableAdapter = new PL.Hotel.HotelResDataSetTableAdapters.vw_AylıkOrtalamaTableAdapter();
            this.sp_YıllıkOrtalamaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_YıllıkOrtalamaTableAdapter = new PL.Hotel.HotelResDataSetTableAdapters.sp_YıllıkOrtalamaTableAdapter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.vw_SonBirYılBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelResDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_AylıkOrtalamaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_YıllıkOrtalamaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_SonBirYılBindingSource
            // 
            this.vw_SonBirYılBindingSource.DataMember = "vw_SonBirYıl";
            this.vw_SonBirYılBindingSource.DataSource = this.HotelResDataSet;
            // 
            // HotelResDataSet
            // 
            this.HotelResDataSet.DataSetName = "HotelResDataSet";
            this.HotelResDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PaymentsBindingSource
            // 
            this.PaymentsBindingSource.DataMember = "Payments";
            this.PaymentsBindingSource.DataSource = this.HotelResDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1308, 687);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Aylık Gelir/Gider ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.sp_YıllıkOrtalamaBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "PL.Hotel.rprAylıkGelir.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1302, 681);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1308, 687);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oda Satış Raporlu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource8.Name = "DataSet1";
            reportDataSource8.Value = this.vw_SonBirYılBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "PL.Hotel.rprOdaSatis.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1302, 681);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1308, 687);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kasa Hareketleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource9.Name = "DataSet1";
            reportDataSource9.Value = this.PaymentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PL.Hotel.rpr.OtelKasaHareket.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1302, 681);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1316, 716);
            this.tabControl1.TabIndex = 1;
            // 
            // PaymentsTableAdapter
            // 
            this.PaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // vw_SonBirYılTableAdapter
            // 
            this.vw_SonBirYılTableAdapter.ClearBeforeFill = true;
            // 
            // vw_AylıkOrtalamaBindingSource
            // 
            this.vw_AylıkOrtalamaBindingSource.DataMember = "vw_AylıkOrtalama";
            this.vw_AylıkOrtalamaBindingSource.DataSource = this.HotelResDataSet;
            // 
            // vw_AylıkOrtalamaTableAdapter
            // 
            this.vw_AylıkOrtalamaTableAdapter.ClearBeforeFill = true;
            // 
            // sp_YıllıkOrtalamaBindingSource
            // 
            this.sp_YıllıkOrtalamaBindingSource.DataMember = "sp_YıllıkOrtalama";
            this.sp_YıllıkOrtalamaBindingSource.DataSource = this.HotelResDataSet;
            // 
            // sp_YıllıkOrtalamaTableAdapter
            // 
            this.sp_YıllıkOrtalamaTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1308, 687);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Personel Sorgu";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 716);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRaporlar";
            this.Text = "frmRaporlar";
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_SonBirYılBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelResDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vw_AylıkOrtalamaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_YıllıkOrtalamaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PaymentsBindingSource;
        private HotelResDataSet HotelResDataSet;
        private HotelResDataSetTableAdapters.PaymentsTableAdapter PaymentsTableAdapter;
        private System.Windows.Forms.BindingSource vw_SonBirYılBindingSource;
        private HotelResDataSetTableAdapters.vw_SonBirYılTableAdapter vw_SonBirYılTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabControl tabControl1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource vw_AylıkOrtalamaBindingSource;
        private HotelResDataSetTableAdapters.vw_AylıkOrtalamaTableAdapter vw_AylıkOrtalamaTableAdapter;
        private System.Windows.Forms.BindingSource sp_YıllıkOrtalamaBindingSource;
        private HotelResDataSetTableAdapters.sp_YıllıkOrtalamaTableAdapter sp_YıllıkOrtalamaTableAdapter;
        private System.Windows.Forms.TabPage tabPage4;
    }
}