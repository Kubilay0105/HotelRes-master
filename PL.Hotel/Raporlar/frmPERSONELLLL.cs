﻿using System;
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
    public partial class frmPERSONELLLL : Form
    {
        public frmPERSONELLLL()
        {
            InitializeComponent();
        }

        private void frmPERSONELLLL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HotelResaDataSet.sp_PersonelSatıs' table. You can move, or remove it, as needed.
            this.sp_PersonelSatısTableAdapter.Fill(this.HotelResaDataSet.sp_PersonelSatıs);

            this.reportViewer1.RefreshReport();
        }
    }
}