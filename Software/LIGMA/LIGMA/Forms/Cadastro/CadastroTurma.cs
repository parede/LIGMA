﻿using LIGMA.Classes;
using LIGMA.Forms.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIGMA.Forms.Cadastro
{
    public partial class CadastroTurma : Form
    {
        public CadastroTurma()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            CodigosIguais fechar = new CodigosIguais();
            fechar.Fechar();
        }

        private void lblMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form turma = new ConsultaTurma();
            turma.Show();
            this.Hide();
        }

        private void CadastroTurma_Load(object sender, EventArgs e)
        {

        }
    }
}
