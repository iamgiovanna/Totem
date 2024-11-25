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
    public partial class FormEvento4 : Form
    {
        public FormEvento4()
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
        private void button1_Click(object sender, EventArgs e)
        {
            FormEventos formEventos = new FormEventos();
            formEventos.Show();
            this.Hide();
        }

        private void FormEvento4_Load(object sender, EventArgs e)
        {
            CentralizarPainel(flowPainelEvento);
        }

        private void FlowPainelEvento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TituloEvento_Click(object sender, EventArgs e)
        {

        }
    }
}
