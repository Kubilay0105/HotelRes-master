using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Hotel.Raporlar
{
    public partial class frmPersonelStis : Form
    {
        public frmPersonelStis()
        {
            InitializeComponent();
        }

        private void frmPersonelStis_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
