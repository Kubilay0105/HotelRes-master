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
    public partial class GunlukKasa : Form
    {
        public GunlukKasa()
        {
            InitializeComponent();
        }

        private void GunlukKasa_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
