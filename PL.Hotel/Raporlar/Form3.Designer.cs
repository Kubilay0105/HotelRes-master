namespace PL.Hotel
{
    partial class rpr1
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
            this.PaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentsTableAdapter = new PL.Hotel.HotelResaDataSetTableAdapters.PaymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HotelResaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsGunlukKasa";
            reportDataSource1.Value = this.PaymentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PL.Hotel.Report1.rdlc";
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
            // PaymentsBindingSource
            // 
            this.PaymentsBindingSource.DataMember = "Payments";
            this.PaymentsBindingSource.DataSource = this.HotelResaDataSet;
            // 
            // PaymentsTableAdapter
            // 
            this.PaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // rpr1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpr1";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HotelResaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PaymentsBindingSource;
        private HotelResaDataSet HotelResaDataSet;
        private HotelResaDataSetTableAdapters.PaymentsTableAdapter PaymentsTableAdapter;
    }
}