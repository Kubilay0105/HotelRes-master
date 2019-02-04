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

        private void tsGunlukKasaHareketleri_Click(object sender, EventArgs e)
        {
            rpr1 frm = new rpr1();
            FormAc(frm);
        }
        private void FormAc(Form AF)
        {
            foreach (Control F in this.pnlContent.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    MF.Close();
                }
            }
            AF.TopLevel = false;
            this.pnlContent.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
        }

        private void tsMusteriHareketler_Click(object sender, EventArgs e)
        {
            frmrprYıllık frm = new frmrprYıllık();
            FormAc(frm);
        }

        private void tsPersonel_Click(object sender, EventArgs e)
        {
            frmPERSONELLLL frm = new frmPERSONELLLL();
            FormAc(frm);
        }
    }
}
