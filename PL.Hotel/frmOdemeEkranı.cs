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
    public partial class frmOdemeEkranı : Form
    {
        public frmOdemeEkranı()
        {
            InitializeComponent();
        }
        PaymentsRepository pr = new PaymentsRepository();
        GuestRepository gr = new GuestRepository();
        RoomRepository Rp = new RoomRepository();
        SaleRepository sr = new SaleRepository();
        PersonnelRepository Pp = new PersonnelRepository();
        int SId, GId;

        private void frmOdemeEkranı_Load(object sender, EventArgs e)
        {
            //dgvPayments.DataSource = pr.PaymentsByDate(dtpTarih.Value);
            //cbIslemTurleri.SelectedIndex = 0;
            //GunlukToplamlariGoster();
            //dtpTarih.Value = DateTime.Now;
            //dgvPayments.DataSource = pr.GetPaymentsByGuest(sr.GetSales(),txtTcKimlikNo.Text);

        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            //dgvPayments.DataSource = pr.PaymentsByDate(dtpTarih.Value);
            //cbIslemTurleri.SelectedIndex = 0;
            //GunlukToplamlariGoster();
        }

        private void dgvPayments_DoubleClick(object sender, EventArgs e)
        {
            //List<decimal> liste = pr.PaymentTransBySalesId((Convert.ToInt32(dgvPayments.SelectedRows[0].Cells[5].Value)));

            //txtBorc.Text = string.Format("{0:#,##0}", liste[0]);
            //txtKazanc.Text = string.Format("{0:#,##0}", liste[1]);
            //txtKalanBorc.Text = string.Format("{0:#,##0}", liste[2]);

            //SId = Convert.ToInt32(dgvPayments.SelectedRows[0].Cells[5].Value);
            //Sale ss = sr.GetSaleById(SId);
            //txtOdaNo.Text = Rp.GetRoomNo(ss.RoomId).ToString();
        }
        private void GunlukToplamlariGoster()
        {
            //decimal GirenToplam = 0;
            //decimal CikanToplam = 0;
            //foreach (DataGridViewRow dr in dgvPayments.Rows)
            //{
            //    GirenToplam += Convert.ToDecimal(dr.Cells[4].Value);
            //    CikanToplam += Convert.ToDecimal(dr.Cells[3].Value);
            //    //dr.Cells[6].Value = Convert.ToDecimal(string.Format("{0:#,##0}", Convert.ToDecimal(dr.Cells[6].Value)));
            //    //dr.Cells[7].Value = Convert.ToDecimal(string.Format("{0:#,##0}", Convert.ToDecimal(dr.Cells[7].Value)));
            //}
            //txtGirenToplam.Text = string.Format("{0:#,##0}", GirenToplam);
            //txtCikanToplam.Text = string.Format("{0:#,##0}", CikanToplam);
            //txtBakiye.Text = string.Format("{0:#,##0}", GirenToplam - CikanToplam);
            //Temizle();

        }

        private void cbIslemTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbIslemTurleri.SelectedItem.ToString() == "Tümü")
            //{
            //    dgvPayments.DataSource = pr.PaymentsByDate(dtpTarih.Value);
            //    GunlukToplamlariGoster();

            //}
            //else if (cbIslemTurleri.SelectedItem.ToString() == "Konaklama Ücreti")
            //{
            //    dgvPayments.DataSource = pr.PaymentsByDate(dtpTarih.Value, "Konaklama Ücreti");
            //    GunlukToplamlariGoster();

            //}
            //else if (cbIslemTurleri.SelectedItem.ToString() == "Tahsilat")
            //{
            //    dgvPayments.DataSource = pr.PaymentsByDate(dtpTarih.Value, "Tahsilat");
            //    GunlukToplamlariGoster();

            //}
            //else
            //{
            //    dgvPayments.DataSource = pr.PaymentsByDate(dtpTarih.Value, "Extra");
            //    GunlukToplamlariGoster();

            //}
        }
        private void FormAc(Form AF)
        {
            foreach (Control F in this.pnlContent1.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    MF.Close();
                }
            }
            AF.TopLevel = false;
            this.pnlContent1.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
        }

        private void tsOtelOdemeleri_Click(object sender, EventArgs e)
        {
            if (Pp.AdminControl(General.PersonelId))
            {
                frmOtelOdemeleri frm = new frmOtelOdemeleri();
                FormAc(frm);
            }
            else MessageBox.Show("Buraya Giriş Yetkiniz Bulunmamaktadır.");
        }

        private void tsMusteriOdemeleri_Click(object sender, EventArgs e)
        {
            frmMusteriOdemeleri frm = new frmMusteriOdemeleri();
            FormAc(frm);
        }

        
    }
}
