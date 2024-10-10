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
    public partial class FormTelaInicial : Form
    {
        public FormTelaInicial()
        {
            InitializeComponent();
        }

        private void FormTelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {

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

        }

        private void BtnMapa_Click(object sender, EventArgs e)
        {
            //evento mapa 
            FormMapaEtec FormME = new FormMapaEtec();
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
    }
}
