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
    public partial class rpr1 : Form
    {
        public rpr1()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HotelResaDataSet.Payments' table. You can move, or remove it, as needed.
            this.PaymentsTableAdapter.Fill(this.HotelResaDataSet.Payments);

            this.reportViewer1.RefreshReport();
        }
    }
}
