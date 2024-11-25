using System;
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
    public partial class FormEventos : Form
    {
        public FormEventos()
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

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            //EVENTO para voltar a tela inicial
            FormTelaInicial formTelaInicial = new FormTelaInicial();
            formTelaInicial.Show();
            this.Hide();
        }



        private void Btn1_Click(object sender, EventArgs e)
        {
            // Feira tecnológica
            FormEvento1 formEvento1 = new FormEvento1();
            formEvento1.Show();
            this.Hide();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            //Baile de primavera
            FormEvento2 formEvento2 = new FormEvento2();
            formEvento2.Show();
            this.Hide();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            //Provão paulista
            FormEvento5 formEvento5 = new FormEvento5();
            formEvento5.Show();
            this.Hide();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            //Feira do empreendedor
            FormEvento3 formEvento3 = new FormEvento3();
            formEvento3.Show();
            this.Hide();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            //Semana paulo freire
            FormEvento4 formEvento4 = new FormEvento4();
            formEvento4.Show();
            this.Hide();
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            CentralizarPainel(flowLayoutPanel1);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
