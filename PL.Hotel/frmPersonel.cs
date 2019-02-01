
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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        PersonnelRepository pr = new PersonnelRepository();
        Personnel per = new Personnel();
        int ID;
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
            dgvPersonel.DataSource = pr.GetPersonnels();
        }

        private void tsEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPersonelAd.Text))
            {

                Personnel yeni = new Personnel();
                //Özellikleri girilir.
                yeni.PersonName = txtPersonelAd.Text;

                if (pr.PersonnelControl(yeni))
                {
                    MessageBox.Show("Bu personel kayıtlı!", " Tekrar kayıt yapılamaz!");
                }
                else
                {
                    yeni.PersonSurname = txtPersonelSoyad.Text;
                    yeni.Phone = txtTel.Text;
                    yeni.Adress = txtAdres.Text;
                    yeni.Uname = txtUsername.Text;
                    yeni.Upwd = txtPasword.Text;
                    yeni.JobName = txtUnvan.Text;
                    yeni.Salary = Convert.ToDecimal(txtMaas.Text);
                    if (pr.AddPersonnel(yeni))
                    {
                        MessageBox.Show("Yeni personel eklendi.", "Kayıt gerçekleşti.");
                        dgvPersonel.DataSource = pr.GetPersonnels();

                        //Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Personel bilgileri girilmelidir!", "Dikkat! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtPersonelAd.Focus();
        }

        private void tsGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPersonelAd.Text))
            {
                Personnel degisen = pr.GetPersonnelById(ID);
                degisen.PersonName = txtPersonelAd.Text;
                degisen.PersonSurname = txtPersonelSoyad.Text;
                degisen.IdentificationNo = txtTC.Text;
                degisen.Phone = txtTel.Text;
                degisen.Adress = txtAdres.Text;
                degisen.Uname = txtUsername.Text;
                degisen.Upwd = txtPasword.Text;
                degisen.JobName = txtUnvan.Text;
                degisen.Salary = Convert.ToDecimal(txtMaas.Text);
                if (pr.PersonnelControlFromUpdate(degisen))
                {
                    MessageBox.Show("Bu personel kayıtlı!", "Tekrar kayıt yapılamaz !");
                }
                else
                {
                    if (pr.UpdatePersonnel(degisen))
                    {
                        MessageBox.Show("Personel bilgileri değiştirildi.", "Update gerçekleşti.");
                        dgvPersonel.DataSource = pr.GetPersonnels();
                        //Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Extra tür ismi girilmelidir!", "Dikkat! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtPersonelAd.Focus();
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pr.DeletePersonnel(ID))
                {
                    MessageBox.Show("Personel bilgileri silindi.", "Silme gerçekleşti.");
                    dgvPersonel.DataSource = pr.GetPersonnels();
                    //Temizle();
                }
            }
        }
        private void dgvPersonel_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dgvPersonel.SelectedRows[0].Cells[0].Value);
            txtPersonelAd.Text = dgvPersonel.SelectedRows[0].Cells[1].Value.ToString();
            txtPersonelSoyad.Text = dgvPersonel.SelectedRows[0].Cells[2].Value.ToString();
            txtTC.Text= dgvPersonel.SelectedRows[0].Cells[4].Value.ToString();
            txtTel.Text = dgvPersonel.SelectedRows[0].Cells[5].Value.ToString();
            txtAdres.Text = dgvPersonel.SelectedRows[0].Cells[6].Value.ToString();
            txtUsername.Text = dgvPersonel.SelectedRows[0].Cells[7].Value.ToString();
            txtPasword.Text = dgvPersonel.SelectedRows[0].Cells[8].Value.ToString();
            txtUnvan.Text = dgvPersonel.SelectedRows[0].Cells[9].Value.ToString();
            txtMaas.Text = dgvPersonel.SelectedRows[0].Cells[10].Value.ToString();

            txtPersonelAd.Focus();
        }
    }
}
