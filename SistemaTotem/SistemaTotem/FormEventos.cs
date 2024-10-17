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
            //Evento 1
            FormEvento1 formEvento1 = new FormEvento1();
            formEvento1.Show();
            this.Hide();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            //Evento 2
            FormEvento2 formEvento2 = new FormEvento2();
            formEvento2.Show();
            this.Hide();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            //Evento 3
            FormEvento3 formEvento3 = new FormEvento3();
            formEvento3.Show();
            this.Hide();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            //Evento 4
            FormEvento4 formEvento4 = new FormEvento4();
            formEvento4.Show();
            this.Hide();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            //Evento 5
            FormEvento5 formEvento5 = new FormEvento5();
            formEvento5.Show();
            this.Hide();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            //Evento 6
            FormEvento6 formEvento6 = new FormEvento6();
            formEvento6.Show();
            this.Hide();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            //Evento 7
            FormEvento7 formEvento7 = new FormEvento7();
            formEvento7.Show();
            this.Hide();
        }
    }
}
