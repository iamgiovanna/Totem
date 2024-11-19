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
    public partial class FormEvento6 : Form
    {
        private EventosBD Evento6;

        public FormEvento6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEventos formEventos = new FormEventos();
            formEventos.Show();
            this.Hide();
        }

        private void FormEvento6_Load(object sender, EventArgs e)
        {

        }

        private void TituloEvento6_Click(object sender, EventArgs e)
        {
         
            
        }
    }
}
