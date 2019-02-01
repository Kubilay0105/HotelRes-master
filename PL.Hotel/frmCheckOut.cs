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
