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

            //List<Decimal> pay = pr.PaymentTransBySalesId(sr.GetSaleIdByGuest(gr.GetGuestIdByTC(txtTKCNO.Text)));
            //if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTKCNO.Text.Trim() != "" && txtOdaNo.Text.Trim() != "")
            //{
            //    txtBorc.Text = pay[0].ToString();
            //    txtKazanc.Text = pay[1].ToString();
            //    txtKalanBorc.Text = pay[2].ToString();
            //}
            //else
            //    MessageBox.Show("Eksik Bilgi Girdiniz");


        }

        private void btnCikisOnayla_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtKalanBorc.Text) == 0)
            {
                gr.UpdateGuestByTC(txtTKCNO.Text);
                rr.UpdateRoomByRoomNo(txtOdaNo.Text);
                //pr.UpdatePaymentBySalesId(sr.GetSaleIdByGuest(gr.GetGuestIdByTC(txtTKCNO.Text)));
                sr.UpdateSalesByGuestId(gr.GetGuestIdByTC(txtTKCNO.Text));

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
        #region FaturaYazdır
        int x = 0;
        

        private void pdocFatura_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int gID = gr.GetGuestIdByTC(txtTKCNO.Text);
            List<GuestTransaction> list = new List<GuestTransaction>();
            list = gtr.GetGTransById(gID);
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            //e.Graphics.DrawString("Hesap Hareketleri", new Font("Times New Roman", 16, FontStyle.Bold), new SolidBrush(Color.Black), 300, 150);
            e.Graphics.DrawString("Hesap Hareketleri", fntBaslik, sb, 300, 150);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fntBaslik, sb, 600, 100);
            e.Graphics.DrawString("Adı ", fntBaslik, sb, 100, 200);
            e.Graphics.DrawString(": " + txtAdi.Text, fntBaslik, sb, 200, 200);
            e.Graphics.DrawString("Soyadı ", fntBaslik, sb, 100, 220);
            e.Graphics.DrawString(": " + txtSoyadi.Text, fntBaslik, sb, 200, 220);
            e.Graphics.DrawString("TC       İşlem Tarihi     İşlem Tipi      Borç      Ödeme", fntBaslik, sb, 100, 260);
            e.Graphics.DrawString("__________________________________________________________", fntBaslik, sb, 100, 270);
            int y = 0;
            for (int i = x; i < list.Capacity; i++)
            {
                e.Graphics.DrawString(txtTKCNO.Text, fntIcerik, sb, 100, 320 + y);
                e.Graphics.DrawString(list[1].ToString(), fntIcerik, sb, 170, 320 + y);
                e.Graphics.DrawString(list[2].ToString(), fntIcerik, sb, 290, 320 + y);
                fmt.Alignment = StringAlignment.Far;
                //e.Graphics.DrawString(list[3].ToString(), fntIcerik, sb, 500, 320 + y, fmt);
                fmt.Alignment = StringAlignment.Near;
                //e.Graphics.DrawString(list[4].ToString(), fntIcerik, sb, 600, 320 + y);
                y += 25;
                x++;
                if (i % 26 == 0 && i != 0)
                {
                    e.HasMorePages = true; //yeni sayfaya geçer.
                    return;
                }
                else { e.HasMorePages = false; }
            }
            e.Graphics.DrawString("__________________________________________________________", fntBaslik, sb, 100, 320 + y);
            y += 30;
            e.Graphics.DrawString("Toplam Yatan ", fntBaslik, sb, 290, 320 + y);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(": " + txtBorc.Text, fntBaslik, sb, 530, 320 + y, fmt);
            fmt.Alignment = StringAlignment.Near;
            y += 25;
            e.Graphics.DrawString("Toplam Çekilen ", fntBaslik, sb, 290, 320 + y);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(": " + txtKazanc.Text, fntBaslik, sb, 530, 320 + y, fmt);
            fmt.Alignment = StringAlignment.Near;
            y += 25;
            e.Graphics.DrawString("Bakiye ", fntBaslik, sb, 290, 320 + y);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(": " + txtKalanBorc.Text, fntBaslik, sb, 530, 320 + y, fmt);
            fmt.Alignment = StringAlignment.Near;
        }
        private void btnYazdır_Click(object sender, EventArgs e)
        {
            ppdiaFatura.ShowDialog();
            x = 0;
        }
        #endregion


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
