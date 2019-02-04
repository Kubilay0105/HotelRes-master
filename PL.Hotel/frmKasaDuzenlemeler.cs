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
    public partial class frmKasaDuzenlemeler : Form
    {
        public frmKasaDuzenlemeler()
        {
            InitializeComponent();
        }
        TransTypeRepository Ttr = new TransTypeRepository();
        PaymentsRepository Pr = new PaymentsRepository();
        int TtId;
        DateTime Tarih;
        string def;
        
        private void frmKasaDuzenlemeler_Load(object sender, EventArgs e)
        {
            cbIslemTurleri.DataSource = Ttr.GetAllTransType();
            dgvKasaHareketler.DataSource = Pr.GetAllPayments();
            cbIslemTurleri.SelectedIndex = 0;
        }

        private void cbIslemTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TransactionType Trans = (TransactionType)cbIslemTurleri.SelectedItem;
            //TtId = Trans.Id;
            //def = Trans.Defin;
            dgvKasaHareketler.DataSource = Pr.GetAllPaymentsModelByTypeName(dtpTarih.Value, cbIslemTurleri.SelectedItem.ToString());
            dgvKasaHareketler.Columns[0].Visible = false;

        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            dgvKasaHareketler.DataSource = Pr.GetAllPaymentsModelByTypeName(dtpTarih.Value, cbIslemTurleri.SelectedItem.ToString());
            dgvKasaHareketler.Columns[0].Visible = false;
        }
        
    }
}
