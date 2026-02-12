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
