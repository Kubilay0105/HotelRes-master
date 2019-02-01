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
    public partial class frmExtraa : Form
    {
        public frmExtraa()
        {
            InitializeComponent();
        }
        ExtraTypeRepository ex = new ExtraTypeRepository();
        ExtraType ET = new ExtraType();
        int ID;
        
        private void frmExtraa_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
            dgvExtralar.DataSource = ex.GetExtraTypes();
        }
        private void Temizle()
        {
            txtExtraTur.Clear();
            txtFiyat.Clear();
            txtDate.Clear();
        }

        private void tsEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtExtraTur.Text))
            {
                //Yeni bir nesne oluşturulur.
                ExtraType yeni = new ExtraType();
                //Özellikleri girilir.
                yeni.Type = txtExtraTur.Text;

                if (ex.ExtraControl(yeni))
                {
                    MessageBox.Show("Bu extra kayıtlı!", "Aynı extra zaten var!");
                }
                else
                {
                    yeni.Price = Convert.ToDecimal(txtFiyat.Text);
                    if (ex.AddExtra(yeni))
                    {
                        MessageBox.Show("Yeni extra eklendi.", "Kayıt gerçekleşti.");
                        dgvExtralar.DataSource = ex.GetExtraTypes();
                        Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Extra türü girilmelidir!", "Dikkat! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtExtraTur.Focus();
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ex.DeleteExtra(ID))
                {
                    MessageBox.Show("Extra tür bilgileri silindi.", "Silme gerçekleşti.");
                    dgvExtralar.DataSource = ex.GetExtraTypes();
                    Temizle();
                }
            }
        }

        private void tsGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtExtraTur.Text))
            {
                ExtraType degisen = ex.GetExtraById(ID);
                //Özellikleri değiştirilir.
                degisen.Type = txtExtraTur.Text;
                degisen.Price = Convert.ToDecimal(txtFiyat.Text);
                if (ex.ExtraControlFromUpdate(degisen))
                {
                    MessageBox.Show("Bu extra kayıtlı!", "Aynı extradan zaten var!");
                }
                else
                {
                    if (ex.UpdateExtra())
                    {
                        MessageBox.Show("Extra bilgileri değiştirildi.", "Update gerçekleşti.");
                        dgvExtralar.DataSource = ex.GetExtraTypes();
                        Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Extra tür ismi girilmelidir!", "Dikkat! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtExtraTur.Focus();
        }

        private void dgvExtralar_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dgvExtralar.SelectedRows[0].Cells[0].Value);
            txtExtraTur.Text = dgvExtralar.SelectedRows[0].Cells[1].Value.ToString();
            txtFiyat.Text = dgvExtralar.SelectedRows[0].Cells[2].Value.ToString();
            txtExtraTur.Focus();
        }
    }
}
