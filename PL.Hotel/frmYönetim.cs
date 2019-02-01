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
    public partial class frmYönetim : Form
    {
        public frmYönetim()
        {
            InitializeComponent();
        }

        private void tsmAnasayfa_Click(object sender, EventArgs e)
        {
            frmOtelAnasayfa frm = new frmOtelAnasayfa();
            frm.Show();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContext.Controls.Clear();
            frmPersonel frm = new frmPersonel();
            frm.TopLevel = false;
            pnlContext.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsGuncelle.Enabled = false;
            frm.tsSil.Enabled = false;
        }

        private void personelGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContext.Controls.Clear();
            frmPersonel frm = new frmPersonel();
            frm.TopLevel = false;
            pnlContext.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsEkle.Enabled = false;
            frm.tsSil.Enabled = false;
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContext.Controls.Clear();
            frmPersonel frm = new frmPersonel();
            frm.TopLevel = false;
            pnlContext.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsGuncelle.Enabled = false;
            frm.tsEkle.Enabled = false;
        }

        private void ekstraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContext.Controls.Clear();
            frmExtraa frm = new frmExtraa();
            frm.TopLevel = false;
            pnlContext.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsGuncelle.Enabled = false;
            frm.tsSil.Enabled = false;
        }

        private void ekstraGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContext.Controls.Clear();
            frmExtraa frm = new frmExtraa();
            frm.TopLevel = false;
            pnlContext.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsEkle.Enabled = false;
            frm.tsSil.Enabled = false;
        }

        private void ekstraSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContext.Controls.Clear();
            frmExtraa frm = new frmExtraa();
            frm.TopLevel = false;
            pnlContext.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsGuncelle.Enabled = false;
            frm.tsEkle.Enabled = false;
        }
    }
}
