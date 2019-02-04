namespace PL.Hotel
{
    partial class frmrprYıllık
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HotelResaDataSet = new PL.Hotel.HotelResaDataSet();
            this.sp_YıllıkOrtalamaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_YıllıkOrtalamaTableAdapter = new PL.Hotel.HotelResaDataSetTableAdapters.sp_YıllıkOrtalamaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HotelResaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_YıllıkOrtalamaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_YıllıkOrtalamaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PL.Hotel.Raporlar.rprYillikRaporllar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // HotelResaDataSet
            // 
            this.HotelResaDataSet.DataSetName = "HotelResaDataSet";
            this.HotelResaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_YıllıkOrtalamaBindingSource
            // 
            this.sp_YıllıkOrtalamaBindingSource.DataMember = "sp_YıllıkOrtalama";
            this.sp_YıllıkOrtalamaBindingSource.DataSource = this.HotelResaDataSet;
            // 
            // sp_YıllıkOrtalamaTableAdapter
            // 
            this.sp_YıllıkOrtalamaTableAdapter.ClearBeforeFill = true;
            // 
            // frmrprYıllık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmrprYıllık";
            this.Text = "frmrprYıllık";
            this.Load += new System.EventHandler(this.frmrprYıllık_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HotelResaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_YıllıkOrtalamaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_YıllıkOrtalamaBindingSource;
        private HotelResaDataSet HotelResaDataSet;
        private HotelResaDataSetTableAdapters.sp_YıllıkOrtalamaTableAdapter sp_YıllıkOrtalamaTableAdapter;
    }
}