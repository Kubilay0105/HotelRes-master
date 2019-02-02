using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Hotel
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HotelResDataSet.sp_YıllıkOrtalama' table. You can move, or remove it, as needed.
            this.sp_YıllıkOrtalamaTableAdapter.Fill(this.HotelResDataSet.sp_YıllıkOrtalama);
            // TODO: This line of code loads data into the 'HotelResDataSet.vw_AylıkOrtalama' table. You can move, or remove it, as needed.
            this.vw_AylıkOrtalamaTableAdapter.Fill(this.HotelResDataSet.vw_AylıkOrtalama);

            this.vw_SonBirYılTableAdapter.Fill(this.HotelResDataSet.vw_SonBirYıl);

            this.PaymentsTableAdapter.Fill(this.HotelResDataSet.Payments);
            
            

            this.reportViewer1.RefreshReport();
          
            this.reportViewer2.RefreshReport();
          
            this.reportViewer3.RefreshReport();


            this.reportViewer3.RefreshReport();
        }



    }
}
