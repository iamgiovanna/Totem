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
    public partial class FormEvento4 : Form
    {
        public FormEvento4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEventos formEventos = new FormEventos();
            formEventos.Show();
            this.Hide();
        }

        private void FormEvento4_Load(object sender, EventArgs e)
        {

        }

        private void FlowPainelEvento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TituloEvento_Click(object sender, EventArgs e)
        {

        }
    }
}
