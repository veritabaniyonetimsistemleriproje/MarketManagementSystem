﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        private void BtnMusteriBorcOdeme_Click(object sender, EventArgs e)
        {
            label3.Visible = true; TBOdemeMiktar.Visible = true; BtnOnayla.Visible= true;
        }
    }
}
