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
    public partial class FormVestibulares : Form
    {
        public FormVestibulares()
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

        private void FormVestibulares_Load(object sender, EventArgs e)
        {
            CentralizarPainel(flowLayoutPanel1);

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnVest4_Click(object sender, EventArgs e)
        {
            //fuvest
            FormVest4 Fuvest = new FormVest4();
            Fuvest.Show();
            this.Hide();

        }

        private void BtnVest3_Click(object sender, EventArgs e)
        {
            //provão paulista
            FormVest3 ProvaoPaulista= new FormVest3();
            ProvaoPaulista.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EVENTO para voltar a tela inicial
            FormTelaInicial formTelaInicial = new FormTelaInicial();
            formTelaInicial.Show();
            this.Hide();
        }

        private void BtnVest1_Click(object sender, EventArgs e)
        {
            //enem
            FormVest1 Enem = new FormVest1();
            Enem.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
