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
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var telaAdministrador = new TelaLoginAdministrador();
            this.Hide();
            telaAdministrador.ShowDialog();
            this.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var telaCliente = new TelaLoginCliente();
            this.Hide();
            telaCliente.ShowDialog();
            this.Show();
        }

        
    }
}
