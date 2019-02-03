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
    public partial class frmMisafirSorgulama : Form
    {
        public frmMisafirSorgulama()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        GuestRepository GR = new GuestRepository();
        RoomRepository RR = new RoomRepository();
        private void frmMisafirSorgulama_Load(object sender, EventArgs e)
        {
            GridDuzenle(GR.GetAllGuest());
        }
        private void GridDuzenle(List<Guest> list)
        {
            dgvMisafirler.DataSource = list;
            dgvMisafirler.Columns[0].Visible = false;
            dgvMisafirler.Columns[5].Visible = false;

            dgvMisafirler.Columns[6].Visible = false;
            dgvMisafirler.Columns[11].Visible = false;

        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            GridDuzenle(GR.GetGuestBySearch(txtAdi.Text,txtSoyad.Text,txtTc.Text));

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            GridDuzenle(GR.GetGuestBySearch(txtAdi.Text, txtSoyad.Text, txtTc.Text));

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            GridDuzenle(GR.GetGuestBySearch(txtAdi.Text, txtSoyad.Text, txtTc.Text));

        }

        private void dgvMisafirler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int RId=Convert.ToInt32(dgvMisafirler.SelectedRows[0].Cells[6].Value);
            txtOda.Text = RR.GetRoomNo(RId);
        }
    }
}
