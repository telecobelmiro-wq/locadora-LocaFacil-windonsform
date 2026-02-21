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
    public partial class TelaLoginCliente : Form
    {
        public TelaLoginCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtNomeCliente.Text == "")
            {
                MessageBox.Show("Digite seu nome!");
                return;
            }
            this.Hide();
            new TelaPrincipal(false).ShowDialog() ;
            

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
