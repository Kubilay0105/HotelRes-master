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
    public partial class frmMisafir : Form
    {
        public frmMisafir()
        {
            InitializeComponent();
        }
        Guest g = new Guest();
        RoomRepository rr = new RoomRepository();
        GuestRepository gr = new GuestRepository();
        SaleRepository sr = new SaleRepository();
        private void frmMisafir_Load(object sender, EventArgs e)
        {

            cbTum.Checked = true;
            cbAktif.Checked = false;
            dgvMisafirSorgu.DataSource = gr.GetAllGuest();
            this.dgwMisafirListesi.Columns["Id"].Visible = false;
            this.dgwMisafirListesi.Columns["RoomId"].Visible = false;
            this.dgwMisafirListesi.Columns["Email"].Visible = false;
            this.dgvMisafirSorgu.Columns["Id"].Visible = false;


        }

        private void tbAd_TextChanged(object sender, EventArgs e)
        {
            dgvMisafirSorgu.DataSource = gr.GetGuestBySearch(tbAd.Text, tbSoyad.Text, tbTC.Text);
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        { g.FirstName = txtMisafirAdi.Text;
            g.LastName = txtMisafirSoyadi.Text;
            g.IdentificationNo = txtMisafirTC.Text;
            g.ContactNo = txtTelefon.Text;
            g.Birthday = dtpMisafirDogumTarihi.Value;
            g.Gender = cbMisafirCinsiyet.SelectedItem.ToString();
            g.Adress = richTextBox1.Text;
            g.Email = txtMail.Text;
            g.Status = true;
            g.Deleted = false;
            g.RoomId = rr.GetRoomId(txtOdaNo.Text);
            gr.AddGuest(g);
            dgwMisafirListesi.DataSource = gr.GetGuestByRoomId(g.RoomId);

        }

        private void btnOnay_Click_1(object sender, EventArgs e)
        { int NOG = gr.NOG(g.RoomId);
            if (sr.UpdateSales(g.RoomId, NOG))
            { MessageBox.Show("İşlem Onaylandı");
                Temizle();
            }

            else MessageBox.Show("İşlem Onaylanmadı");

        }
        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                TextBox tbox = (TextBox)item;
                tbox.Clear();
            }
        }

        private void cbTum_Click(object sender, EventArgs e)
        {
            cbAktif.Checked = false;
            dgvMisafirSorgu.DataSource = gr.GetAllGuest();
        }

        private void cbAktif_Click(object sender, EventArgs e)
        {
            cbTum.Checked = false;
            dgvMisafirSorgu.DataSource = gr.GetAllGuestByS();
        }

        private void dgvMisafirSorgu_DoubleClick(object sender, EventArgs e)
        {
            tbAd.Text = dgvMisafirSorgu.SelectedRows[0].Cells[1].Value.ToString();
            tbSoyad.Text = dgvMisafirSorgu.SelectedRows[0].Cells[2].Value.ToString();
            tbTC.Text = dgvMisafirSorgu.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (gr.DeleteGuest(tbTC.Text))
                {
                    MessageBox.Show("Kategori bilgileri silindi.", "Silme gerçekleşti.");
                    dgvMisafirSorgu.DataSource = gr.GetAllGuest();

                    Temizle();
                }
            }
        }

            private void btnIptal_Click(object sender, EventArgs e)
            {
                this.Close();
                Temizle();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gr.UpdateGuest())
            {
                MessageBox.Show("Kategori bilgileri değiştirildi.");
                dgvMisafirSorgu.DataSource=gr.GetAllGuest();
                Temizle();
            }
        }
    }
    }

