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
    public partial class frmExtraIslemler : Form
    {
        public frmExtraIslemler()
        {
            InitializeComponent();
        }
        RoomRepository Rr = new RoomRepository();
        SaleRepository Sr = new SaleRepository();
        ExtraRepository Er = new ExtraRepository();
        ExtraType ET = new ExtraType();
        int RId,GId,ExtraTypeId;
        private void frmExtraIslemler_Load(object sender, EventArgs e)
        {
            dgvOdalar.Visible = false;
            cbEkstra.DataSource = Er.GetExtraTypes();
            txtDate.Text = DateTime.Now.ToShortDateString();         
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnit.Text))
            {
                txtSum.Text = (Convert.ToInt32(txtUnit.Text) * Convert.ToDecimal(txtPrice.Text)).ToString();
            }
            else
            {
                txtSum.Clear();
            }
        }

        private void cbEkstra_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExtraTypeId = (cbEkstra.SelectedItem as ExtraType).Id;
            if (cbEkstra.SelectedIndex != -1)
            {
                txtPrice.Text = (cbEkstra.SelectedItem as ExtraType).Price.ToString();
            }
        }
        List<Sale> SatisListe = new List<Sale>();
        private void btnAdminn_Click(object sender, EventArgs e)
        {
            dgvOdalar.Visible = true;
            SatisListe = Sr.GetSaleforFullRoom(DateTime.Now);
            dgvOdalar.DataSource = Rr.GetFullRooms(SatisListe);
            //pnlExtraa.Controls.Clear();
            //frmExtraa frm = new frmExtraa();
            //frm.TopLevel = false;
            //pnlExtraa.Controls.Add(frm);
            //frm.Show();
            //frm.Dock = DockStyle.Fill;
        }

        private void nudAdet_ValueChanged(object sender, EventArgs e)
        {
            txtUnit.Text = nudAdet.Value.ToString();
            txtSum.Text = (Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtUnit.Text)).ToString();
        }
        private void Temizle()
        {
            txtDate.Clear();
            txtPrice.Clear();
            txtSum.Clear();
            txtUnit.Clear();
            dgvOdalar.Visible = false;
        }

        private void btnOda_Click(object sender, EventArgs e)
        {
            if (txtOdaNo.Text.Trim() != "")
            {
                ExtraTransactions ex = new ExtraTransactions();
                ex.TypeId = ExtraTypeId;
                ex.RoomId = RId;
                try
                {
                    ex.Unit = Convert.ToInt32(txtUnit.Text);

                }
                catch (Exception)
                {

                    throw;
                }
                try
                {
                    ex.Sum = Convert.ToDecimal(txtSum.Text);

                }
                catch (Exception)
                {

                    throw;
                }
                ex.TransactionDate = DateTime.Now;
                ex.Status = true;
                ex.Deleted = false;

                if (Er.AddExtraAndGTrans(ex, GId))
                {
                    MessageBox.Show("Extra harcaması yapıldı.");
                    Temizle();
                }
                else MessageBox.Show("İşlem gerçekleşmedi.");

            }
            else MessageBox.Show("Lütfen Oda Bilgilerini seçiniz.");
        }

        private void dgvOdalar_DoubleClick(object sender, EventArgs e)
        {
            RId = Convert.ToInt32(dgvOdalar.SelectedRows[0].Cells[0].Value);
            txtOdaNo.Text = dgvOdalar.SelectedRows[0].Cells[1].Value.ToString();
            foreach (Sale item in SatisListe)
            {
                if (item.RoomId == RId) GId = item.GuestId;
            }
        }
    }
}
