using BLL.Hotel.Repositories;
using DAL.Hotel.Model;
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
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }
        SaleRepository sr = new SaleRepository();
        Reservations Res = new Reservations();
        List<ReservationsModel> Rezlist;
        int SId,GId;
        private void dtpGiris_ValueChanged(object sender, EventArgs e)
        {
            Rezlist = sr.GetSales(dtpGiris.Value);
            dgvRezervasyon.DataSource = Rezlist;

        }

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            Rezlist= sr.GetSales(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            GridDuzenle(Rezlist);
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            GridDuzenle(Rezlist.Where(x => x.GuestIdtf.StartsWith(txtTc.Text)).ToList());
        }

        private void dgvRezervasyon_DoubleClick(object sender, EventArgs e)
        {
            GId= Convert.ToInt32(dgvRezervasyon.SelectedRows[0].Cells[1].Value);
            SId = Convert.ToInt32(dgvRezervasyon.SelectedRows[0].Cells[0].Value);
            txtMisafirAdi.Text  = dgvRezervasyon.SelectedRows[0].Cells[2].Value.ToString();
            txtMisafirSoyadi.Text = dgvRezervasyon.SelectedRows[0].Cells[3].Value.ToString();
            txtMisafirTC.Text = dgvRezervasyon.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnRezIptal_Click(object sender, EventArgs e)
        {
            if (Res.CancelReservations(GId))
            {
                MessageBox.Show("İptal işlemi gerçekleşti.");
                GridDuzenle(Rezlist);

            }
            else MessageBox.Show("iptal işlemi gerçekleşmedi.");
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            if (Res.UpdateResarvation(GId))
            {
                MessageBox.Show("Check-In işlemi gerçekleşti.");
                GridDuzenle(Rezlist);

            }
            else MessageBox.Show("Check-In işlemi gerçekleşmedi.");

        }
        private void GridDuzenle(List<ReservationsModel> list)
        {
            dgvRezervasyon.DataSource = list;
            dgvRezervasyon.Columns[0].Visible = false;
            dgvRezervasyon.Columns[1].Visible = false;
            dgvRezervasyon.Columns[2].HeaderText = "Name";
            dgvRezervasyon.Columns[3].HeaderText = "Surname";
            dgvRezervasyon.Columns[4].HeaderText = "Identification No";
            dgvRezervasyon.Columns[5].HeaderText = "Phone";
            dgvRezervasyon.Columns[6].HeaderText = "Mail";

        }
    }
}
