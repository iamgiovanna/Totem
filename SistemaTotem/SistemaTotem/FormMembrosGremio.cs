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
    public partial class FormMembrosGremio : Form
    {
        public FormMembrosGremio()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            //EVENTO para voltar a tela inicial
            FormTelaInicial formTelaInicial = new FormTelaInicial();
            formTelaInicial.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void LabelTituloChapa_Click(object sender, EventArgs e)
        {

        }

        private void LabelFuncao5_Click(object sender, EventArgs e)
        {

        }

        private void LabelTituloChapa_Click_1(object sender, EventArgs e)
        {

        }

        private void Foto8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void FormMembrosGremio_Load(object sender, EventArgs e)
        {
            CentralizarPainel(panel2);
        }

        private void PainelGremio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
