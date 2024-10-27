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
    public partial class FormEvento2 : Form
    {
        public FormEvento2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEventos eventos = new FormEventos();
            eventos.Show();
            this.Hide();
        }

        private void PainelEvento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormEvento2_Load(object sender, EventArgs e)
        {

        }
    }
}
