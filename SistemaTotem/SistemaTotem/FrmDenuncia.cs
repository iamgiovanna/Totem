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
    public partial class FrmDenuncia : Form
    {
        public FrmDenuncia()
        {
            InitializeComponent();
        }

        private void BtnTelaInicial_Click(object sender, EventArgs e)
        {
            FormTelaInicial formTelaInicial = new FormTelaInicial();
            formTelaInicial.Show();
            this.Hide();
        }
    }
}
