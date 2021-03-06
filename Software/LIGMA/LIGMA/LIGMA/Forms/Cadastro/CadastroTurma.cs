﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptcc1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEnviar_MouseUp(object sender, MouseEventArgs e)
        {
            btnEnviar.BackColor = Color.RoyalBlue;
            btnEnviar.ForeColor = Color.White;
        }

        private void btnEnviar_MouseDown(object sender, MouseEventArgs e)
        {
            btnEnviar.BackColor = Color.Transparent;
            btnEnviar.ForeColor = Color.RoyalBlue;
        }
    }
}
