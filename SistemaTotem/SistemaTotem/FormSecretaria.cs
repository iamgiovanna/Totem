﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTotem
{
    public partial class FormSecretaria : Form
    {
        public FormSecretaria()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void CentralizarPainel(Panel painel)
        {
            int x = (this.ClientSize.Width - painel.Width) / 2;
            int y = (this.ClientSize.Height - painel.Height) / 2;

            painel.Location = new Point(x, y);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormSecretaria_Load(object sender, EventArgs e)
        {
            CentralizarPainel(flowLayoutPanel1);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            //EVENTO para voltar a tela inicial
            FormTelaInicial formTelaInicial = new FormTelaInicial();
            formTelaInicial.Show();
            this.Hide();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
