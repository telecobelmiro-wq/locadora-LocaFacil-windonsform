using LocadoraDeCarros.Modelo;
using LocadoraDeCarros.Repositories;

namespace LocadoraDeCarros
{
    public partial class TelaEditarCliente : Form
    {
        private int idCliente;






        public TelaEditarCliente(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
        }

        private async void TelaEditarCliente_Load(object sender, EventArgs e)
        {
            var cliente = await ClienteRepository.ObterPorId(idCliente);

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.");
                this.Close();
                return;
            }

            txtNome.Text = cliente.Nome;
            txtEmailEditarCli.Text = cliente.Email;
            txtCpfEditarCli.Text = cliente.Cpf;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Id = idCliente,
                Nome = txtNome.Text,
                Email = txtEmailEditarCli.Text,
                Cpf = txtCpfEditarCli.Text,

            };

            await ClienteRepository.Atualizar(cliente);

            MessageBox.Show("Cliente atualizado com sucesso!");

            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarEditarCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSalvarEditarCli_Click(object sender, EventArgs e)
        {
            try
            {
                string sexo;

                if (rbMaculinoEditarCli.Checked)
                {
                    sexo = "Masculino";
                }
                else if (rbFemininoEditarCli.Checked)
                {
                    sexo = "Feminino";
                }


                Cliente cliente = new Cliente
                {
                    Id = idCliente,
                    Nome = txtNome.Text,
                    Email = txtEmailEditarCli.Text,
                    Cpf = txtCpfEditarCli.Text,

                };

                await ClienteRepository.Atualizar(cliente);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            this.Close();
        }

        private void txtEmailEditarCli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}