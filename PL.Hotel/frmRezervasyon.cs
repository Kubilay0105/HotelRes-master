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
        private void dtpGiris_ValueChanged(object sender, EventArgs e)
        {
            Rezlist = sr.GetSales(dtpGiris.Value);
            dgvRezervasyon.DataSource = Rezlist;

        }

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            Rezlist= sr.GetSales(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            dgvRezervasyon.DataSource = Rezlist;
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            dgvRezervasyon.DataSource=Rezlist.Where(x => x.GuestIdtf.StartsWith(txtTc.Text)).ToList();
        }
    }
}
