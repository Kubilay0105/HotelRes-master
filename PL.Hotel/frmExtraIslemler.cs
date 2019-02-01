using BLL.Hotel.Repositories;
using DAL.Hotel.Context;
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
    public partial class frmExtraIslemler : Form
    {
        public frmExtraIslemler()
        {
            InitializeComponent();
        }
        RoomRepository Rr = new RoomRepository();
        ExtraRepository ex = new ExtraRepository();
        ExtraType ET = new ExtraType();
        int ID;
        private void frmExtraIslemler_Load(object sender, EventArgs e)
        {
            cbEkstra.DataSource = ex.GetExtraTypes();
            txtDate.Text = DateTime.Now.ToShortDateString();         
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnit.Text))
            {
                txtSum.Text = (Convert.ToInt32(txtUnit.Text) * Convert.ToDecimal(txtPrice.Text)).ToString();
            }
            else
            {
                txtSum.Clear();
            }
        }

        private void cbEkstra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEkstra.SelectedIndex != -1)
            {
                txtPrice.Text = (cbEkstra.SelectedItem as ExtraType).Price.ToString();
            }
        }

        private void btnAdminn_Click(object sender, EventArgs e)
        {
            dgvOdalar.DataSource = Rr.GetFullRooms(DateTime.Now);
            //pnlExtraa.Controls.Clear();
            //frmExtraa frm = new frmExtraa();
            //frm.TopLevel = false;
            //pnlExtraa.Controls.Add(frm);
            //frm.Show();
            //frm.Dock = DockStyle.Fill;
        }

        private void nudAdet_ValueChanged(object sender, EventArgs e)
        {
            txtUnit.Text = nudAdet.Value.ToString();
            txtSum.Text = (Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtUnit.Text)).ToString();
        }
    }
}
