﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmPesquisa : Form
    {
        private string _texto;
        public FrmPesquisa()
        {
            InitializeComponent();
            Texto = "";
        }

        
      

        public string Texto { get => _texto; set => _texto = value; }

      

        private void btnOff_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTexto.Text))
            {
                Texto = txtTexto.Text;
            }
            this.Close();
        }
    }
}
