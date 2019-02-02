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
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }
        PaymentsRepository pr = new PaymentsRepository();
        GuestRepository gr = new GuestRepository();
        SaleRepository sr = new SaleRepository();
        RoomRepository rr = new RoomRepository();
        GuestTransRepository gtr = new GuestTransRepository();
        Font fntBaslik = new Font("Times New Roman", 16, FontStyle.Bold);
        Font fntIcerik = new Font("Times New Roman", 12, FontStyle.Regular);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void frmCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void btnBorcSorgula_Click(object sender, EventArgs e)
        {
            Guest gst = gr.GetGuestByTC(txtTKCNO.Text);
            List<Decimal> pay = gtr.PaymentsByGuest(gst.Id);
            // List<Decimal> pay = pr.PaymentTransBySalesId(sr.GetSaleIdByGuest(gr.GetGuestIdByTC(txtTKCNO.Text)));
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTKCNO.Text.Trim() != "" && txtOdaNo.Text.Trim() != "")
            {
                txtBorc.Text = pay[0].ToString();
                txtKazanc.Text = pay[1].ToString();
                txtKalanBorc.Text = pay[2].ToString();
            }
            else
                MessageBox.Show("Eksik Bilgi Girdiniz");
        }

        private void btnCikisOnayla_Click(object sender, EventArgs e)
        {Guest gst = gr.GetGuestByTC(txtTKCNO.Text);
            if (Convert.ToDecimal(txtKalanBorc.Text) == 0)
            {sr.UpdateSalesByGuestId(gst.Id);
                gr.UpdateGuestByTC(txtTKCNO.Text);
                rr.UpdateRoomByRoomId(gst.RoomId);
                //pr.UpdatePaymentBySalesId(sr.GetSaleIdByGuest(gr.GetGuestIdByTC(txtTKCNO.Text)));
                sr.UpdateSalesByGuestId(gst.Id);
                gr.UpdateGuestStatusForCheckOutByRoomId(gst.RoomId);

                MessageBox.Show("Çıkış işlemi tamamlandı");

            }
            else
                MessageBox.Show("Sistemde kayıtlı borç görünmekte");
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        { 
            frmOdemeEkranı frm = new frmOdemeEkranı();
            frm.Show();
            //    FormAcikmi(frm);

        }

        private void pdocFatura_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<GuestTransaction> liste = new List<GuestTransaction>(); 
               liste= gtr.GetGTrans();
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(txtAdi.Text + " " +txtSoyadi.Text + "Ödeme Bilgileri ",fntBaslik,sb,400,150 );
            e.Graphics.DrawString("TC            Tarih        İşlem Tipi         Borç      Ödenen     Acıklama", fntBaslik, sb, 50,200);
            e.Graphics.DrawString("__________________________________________________________________________", fntBaslik, sb, 50, 250);
            for(int i=0;i<liste.Count;i++)
            {
                e.Graphics.DrawString(txtTKCNO.Text, fntIcerik,sb,50,300+(30*i));
                e.Graphics.DrawString(liste[i].Date.ToShortDateString(), fntIcerik, sb, 170, 300+(30 * i));
                e.Graphics.DrawString(liste[i].TransType.ToString(), fntIcerik, sb, 290,300 +(30 * i));
                e.Graphics.DrawString(liste[i].Debt.ToString(), fntIcerik, sb, 400,300 + (30 * i));
                e.Graphics.DrawString(liste[i].Credit.ToString(), fntIcerik, sb, 500,300+(30 * i));
                e.Graphics.DrawString(liste[i].Description.ToString(), fntIcerik, sb, 600,300+(30 * i));
            }

        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            ppdiaFatura.ShowDialog();
        }


        //private void FormAcikmi(Form AcilacakForm)
        //{
        //    bool Varmi = false;
        //    for (int i = 0; i < this.MdiChildren.Length; i++)
        //    {
        //        if (AcilacakForm.Name == MdiChildren[i].Name)
        //        {
        //            MdiChildren[i].Focus();
        //            Varmi = true;
        //        }
        //    }
        //    if (Varmi == false)
        //    {
        //        AcilacakForm.MdiParent = this;
        //        AcilacakForm.Show();
        //    }
        //    else
        //    {
        //        AcilacakForm.Dispose();
        //    }
        //}
    }
}
