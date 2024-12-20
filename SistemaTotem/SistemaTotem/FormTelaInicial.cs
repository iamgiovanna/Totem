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
    public partial class FormTelaInicial : Form
    {
        public FormTelaInicial()
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
        private void FormTelaInicial_Load(object sender, EventArgs e)
        {
            CentralizarPainel(panel1);
        
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            //EVENTO DA PÁGINAS EVENTOS SKSKSKSKS

            FormEventos formEventos = new FormEventos();
            formEventos.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //EVENTO DENUNCIA
            FrmDenuncia  formDenuncia = new FrmDenuncia();
            formDenuncia.Show();
            this.Hide();

        }

        private void BtnMapa_Click(object sender, EventArgs e)
        {
            //evento mapa 
            FrmMapaEtec FormME = new FrmMapaEtec();
            FormME.Show();
            this.Hide();
        }

        private void BtnVestibular_Click(object sender, EventArgs e)
        {
            //evento vestibular
            FormVestibulares FormVE = new FormVestibulares();   
            FormVE.Show();
            this.Hide();
        }

        private void BtnSecretaria_Click(object sender, EventArgs e)
        {
            //evento secretária
            FormSecretaria formSecretaria = new FormSecretaria();
            formSecretaria.Show();
            this.Hide();
        }

        private void BtnGremio_Click(object sender, EventArgs e)
        {
            FormMembrosGremio formMembrosGremio = new FormMembrosGremio();
            formMembrosGremio.Show();
            this.Hide();

        }

        private void PainelTelaInicial_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
