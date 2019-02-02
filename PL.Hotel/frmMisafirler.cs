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
    public partial class frmMisafirler : Form
    {
        public frmMisafirler()
        {
            InitializeComponent();
        }
        RoomRepository Rr = new RoomRepository();
        GuestRepository Gr = new GuestRepository();
        SaleRepository Sr = new SaleRepository();
        int OdaId;
        private void frmMisafirler_Load(object sender, EventArgs e)
        {

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtOdaAra.Text.Trim() != "")
            {
                OdaId = Rr.GetRoomId(txtOdaAra.Text);
                dgvMisafirListesi.DataSource = Gr.GetGuestsInRoom(OdaId);
            }
            else MessageBox.Show("Eksik bilgi girdiniz.");
        }

        private void dgvMisafirListesi_DoubleClick(object sender, EventArgs e)
        {
            int SId = Convert.ToInt32(dgvMisafirListesi.SelectedRows[0].Cells[0].Value);
            Sale sa = Sr.GetSaleById(SId);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMisafirAdi.Text.Trim() != "" && txtMisafirSoyadi.Text.Trim() != "" && txtMisafirTC.Text.Trim() != "")
            {
                Guest gst = new Guest();
                gst.FirstName = txtMisafirAdi.Text;
                gst.LastName = txtMisafirSoyadi.Text;
                gst.IdentificationNo = txtMisafirTC.Text;
                gst.RoomId = OdaId;
                gst.ContactNo = txtTelefon.Text;
                gst.Email = txtMail.Text;
                gst.Gender = cbMisafirCinsiyet.SelectedItem.ToString();
                gst.Status = true;
                gst.Adress = txtAdres.Text;
                gst.Birthday = dtpMisafirDogumTarihi.Value;

                if (Gr.AddGuest(gst))
                {
                    dgvMisafirListesi.DataSource = Gr.GetGuestsInRoom(OdaId);
                    Temizle();
                }
            }
            else MessageBox.Show("Eksik bilgi girdiniz.");
        }
        private void Temizle()
        {
            txtOdaAra.Clear();
            txtMisafirAdi.Clear();
            txtMisafirSoyadi.Clear();
            txtMisafirTC.Clear();
            txtTelefon.Clear();
            txtMail.Clear();
            txtAdres.Clear();
            txtMisafirAdi.Focus();
        }
    }
}
