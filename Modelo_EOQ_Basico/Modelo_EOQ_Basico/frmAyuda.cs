﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo_EOQ_Basico
{
    public partial class frmAyuda : MaterialForm
    {
        public frmAyuda()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            Form1 frmForm1 = new Form1();
            frmForm1.Show();
            this.Close();
        }

        private void frmAyuda_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
