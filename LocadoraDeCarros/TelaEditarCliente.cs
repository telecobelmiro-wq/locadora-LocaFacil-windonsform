using LocadoraDeCarros.Modelo;
using LocadoraDeCarros.Repositories;

namespace LocadoraDeCarros
{
    public partial class TelaEditarCliente : Form
    {
        private int idCliente;
        private Cliente cliente;

        public TelaEditarCliente(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
        }

        private async void TelaEditarCliente_Load(object sender, EventArgs e)
        {
            cliente = await ClienteRepository.ObterPorId(idCliente);

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.");
                this.Close();
                return;
            }

            txtNome.Text = cliente.Nome;
            txtEmailEditarCli.Text = cliente.Email;
            txtCpfEditarCli.Text = cliente.Cpf;

            if (cliente.Sexo == "M")
            {
                rbMaculinoEditarCli.Checked = true;
            }
            else if (cliente.Sexo == "F")
            {
                rbFemininoEditarCli.Checked = true;
            }
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
                string sexo = null;

                if (rbMaculinoEditarCli.Checked)
                    sexo = "M";
                else if (rbFemininoEditarCli.Checked)
                    sexo = "F";

                if (sexo == null)
                {
                    MessageBox.Show("Selecione o sexo.");
                    return;
                }

                // 🔥 ATUALIZA O OBJETO QUE JÁ EXISTE
                cliente.Nome = txtNome.Text;
                cliente.Email = txtEmailEditarCli.Text;
                cliente.Cpf = txtCpfEditarCli.Text;
                cliente.Sexo = sexo;

                await ClienteRepository.Atualizar(cliente);

                MessageBox.Show("Atualizado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void txtEmailEditarCli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}