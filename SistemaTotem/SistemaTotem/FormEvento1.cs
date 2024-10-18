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
    public partial class FormEvento1 : Form
    {
        public FormEvento1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEventos evento = new FormEventos();
            evento.Show();
            this.Hide();
        }

        private void InfoEvento_Click(object sender, EventArgs e)
        {

        }
    }
}
