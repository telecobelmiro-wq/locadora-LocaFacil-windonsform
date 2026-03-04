using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraDeCarros.Repositories;

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

            if (txtLogin.Text == "")
            {
                MessageBox.Show("Digite seu nome!");
                return;
            }
            this.Hide();
            new TelaPrincipal(false).ShowDialog();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CentralizarPainel();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CentralizarPainel();
        }

        private void CentralizarPainel()
        {
            pnlLoginCliente.Left = (this.Width - pnlLoginCliente.Width) / 2;
            pnlLoginCliente.Top = (this.Height - pnlLoginCliente.Height) / 2;
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLogin.Text, out int id))
            {
                MessageBox.Show("Digite um ID válido!");
                return;
            }

            var cliente = await ClienteRepository.ObterPorId(id);

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado!");
                return;
            }

            MessageBox.Show("Login realizado com sucesso!");
            this.Hide();
            TelaPrincipal tela = new TelaPrincipal(cliente);
            tela.ShowDialog();
            this.Show();

        }

        private void lblLoginCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
