using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeCarros
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            this.Load += Centralizar;
            this.Resize += Centralizar;
        }

        private void Centralizar(object sender, EventArgs e)
        {
            pnlTelaInicial.Left = (this.ClientSize.Width - pnlTelaInicial.Width) / 2;
            pnlTelaInicial.Top = (this.ClientSize.Height - pnlTelaInicial.Height) / 2;
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            var telaAdministrador = new TelaLoginAdministrador();
            this.Hide();
            telaAdministrador.ShowDialog();
            this.Show();
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            var telaCliente = new TelaLoginCliente();
            this.Hide();
            telaCliente.ShowDialog();
            this.Show();
        }
    }
}
