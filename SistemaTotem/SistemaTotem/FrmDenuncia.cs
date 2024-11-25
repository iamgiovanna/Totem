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
            this.WindowState = FormWindowState.Maximized;
        }
        private void CentralizarPainel(Panel painel)
        {
            int x = (this.ClientSize.Width - painel.Width) / 2;
            int y = (this.ClientSize.Height - painel.Height) / 2;

            painel.Location = new Point(x, y);
        }

        private void BtnTelaInicial_Click(object sender, EventArgs e)
        {
            FormTelaInicial formTelaInicial = new FormTelaInicial();
            formTelaInicial.Show();
            this.Hide();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmDenuncia_Load(object sender, EventArgs e)
        {
            CentralizarPainel(flowLayoutPanel2);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
