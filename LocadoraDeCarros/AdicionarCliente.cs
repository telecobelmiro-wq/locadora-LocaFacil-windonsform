using System.ComponentModel.DataAnnotations;
using System.Text;
using LocadoraDeCarros.Modelo;
using LocadoraDeCarros.Repositories;

namespace LocadoraDeCarros
{
    public partial class AdicionarCliente : Form
    {
        private readonly TelaPrincipal telaPrincipal;

        public AdicionarCliente(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();

            this.telaPrincipal = telaPrincipal;

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }



        private void AdicionarCliente_Load(object sender, EventArgs e)
        {

        }

        private void AdicionarCliente_Resize(object sender, EventArgs e)
        {
            pnlAdicionarCliente.Left =
                (this.ClientSize.Width - pnlAdicionarCliente.Width) / 2;

            pnlAdicionarCliente.Top =
                (this.ClientSize.Height - pnlAdicionarCliente.Height) / 2;
        }

        private async void btnAdicionarNovoCliente_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Digite o nome.");
                txtNome.Focus();
                return;
            }

            if (!txtNome.Text.All(char.IsLetter) && txtNome.Text.Contains(" ") == false)
            {
                MessageBox.Show("Nome deve conter apenas letras.");
                txtNome.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Digite o email.");
                txtEmail.Focus();
                return;
            }

            {
                if (txtCpf.Text.Length != 11)
                {
                    MessageBox.Show("CPF deve ter exatamente 11 dígitos (somente números).");
                    return;
                }


                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                }
                catch
                {
                    MessageBox.Show("Email inválido.");
                    txtEmail.Focus();
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtCpf.Text))
                {
                    MessageBox.Show("Digite o CPF.");
                    txtCpf.Focus();
                    return;
                }

                if (txtCpf.Text.Length < 11)
                {
                    MessageBox.Show("CPF inválido.");
                    txtCpf.Focus();
                    return;
                }


                if (dtpDataNascimento.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("Data de nascimento inválida.");
                    return;
                }


                if (!rbMasculino.Checked && !rbFeminino.Checked)
                {
                    MessageBox.Show("Selecione o sexo.");
                    return;
                }

                Cliente cliente = new Cliente()
                {
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Email = txtEmail.Text,
                    Sexo = rbMasculino.Checked ? "M" : "F",
                    DataNascimento = dtpDataNascimento.Value,
                };

                await ClienteRepository.Adicionar(cliente);

                MessageBox.Show("Cliente cadastrado com sucesso!");

                await this.telaPrincipal.AtualizarTabela();

                this.Close();
            }
        }

        private void btnCancelarAdcCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlAdicionarCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


    
    

