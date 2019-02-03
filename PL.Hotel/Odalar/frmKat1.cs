﻿using BLL.Hotel.Repositories;
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
    public partial class frmKat1 : Form
    {
        public frmKat1()
        {
            InitializeComponent();
        }
        SaleRepository ss = new SaleRepository();
        RoomRepository rr = new RoomRepository();
        DateTime Gara;
        DateTime Cara;
        private void frmKat1_Load(object sender, EventArgs e)
        {
            //foreach (Control item in pnlKat1.Controls)
            //{
            //    if (item is Panel)
            //    {
            //        foreach (Room rm in rr.GetRoomsByFloor(1))
            //                {
            //                    RoomType rt = rr.GetType(rm.RoomTypeId);
            //                    if (rm.RoomNumber == item.Name.Substring(3))
            //                    {
            //                        (lb+"101") = rt.RoomName;
            //                    }
            //                }      
            //    }
            //}
            Gara = dtpGirisAra.Value;
            dtpCikisAra.Value=dtpGirisAra.Value.AddDays(1);
            Cara = dtpCikisAra.Value;
            OdalarıGetir(Gara.Date, Cara.Date);
        }

        private void dtpGirisAra_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCikisAra.Value < dtpGirisAra.Value || dtpGirisAra.Value<DateTime.Now.Date)
            {
                MessageBox.Show("Tarih seçimine dikkat ediniz.");
                dtpGirisAra.Value = DateTime.Now.Date;
                dtpCikisAra.Value = dtpGirisAra.Value.AddDays(1);
            }
            else
            {
                Gara = dtpGirisAra.Value;
                Cara = dtpCikisAra.Value;
                OdalarıGetir(Gara.Date, Cara.Date);
            }
            
        }

        private void dtpCikisAra_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCikisAra.Value < dtpGirisAra.Value || dtpGirisAra.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Tarih seçimine dikkat ediniz.");
                dtpGirisAra.Value = DateTime.Now.Date;
                dtpCikisAra.Value = dtpGirisAra.Value.AddDays(1);
            }
            else
            {
                Gara = dtpGirisAra.Value;
                Cara = dtpCikisAra.Value;
                OdalarıGetir(Gara.Date, Cara.Date);
            }
        }
        private void OdalarıGetir(DateTime g, DateTime c)
        {
            List<DateTime> Gunler = new List<DateTime>();
            DateTime q = g.Date;
            for (int j = 0; j <= (c.Date - g.Date).TotalDays; j++)
            {
                Gunler.Add(q);
                q = q.Date.AddDays(1);
            }

            foreach (Room item in rr.GetRooms())
            {
                item.State = false;
            }
            //List<int> Dolular = new List<int>();
            foreach (Sale S in ss.GetSales())
            {
                foreach (DateTime dt in Gunler)
                {
                    if (dt.Date >= S.CheckIn.Date && dt.Date <= S.CheckOut.Date)
                    {
                        foreach (Room item in rr.GetRoomsByFloor(1))
                        {
                            if (S.RoomId == item.Id) { item.State = true; }
                        }
                        //Dolular.Add(S.RoomId);
                    }
                }
            }
            foreach (Control item in pnlKat1.Controls)
            {
                if (item is Label)
                {
                    foreach (Room rm in rr.GetRoomsByFloor(1))
                    {
                        if (rm.RoomNumber == item.Name.Substring(1))
                        {
                            if (rm.State) item.BackColor = Color.FromArgb(255, 255, 73, 0);
                            else item.BackColor = Color.GreenYellow;
                        }
                    }
                }
            }
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            string odano = (sender as Button).Name.Substring(3);
            frmOdaOzellikleri frm = new frmOdaOzellikleri();
            frm.Odano = odano;

            frm.ShowDialog();
        }
    }
}
