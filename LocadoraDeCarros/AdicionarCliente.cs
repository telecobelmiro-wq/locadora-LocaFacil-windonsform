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

        private async void btnAdicionarNovoCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                Email = txtEmail.Text,
                Sexo = rbMasculino.Checked ? 'M' : 'F',
                DataNascimento = dtpDataNascimento.Value,
            };

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            var contexto = new ValidationContext(cliente);
            Validator.TryValidateObject(cliente, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                }

                lblErro.Text = stringBuilder.ToString();
            }
            else
            {
                await ClienteRepository.Adicionar(cliente);
                MessageBox.Show("Cliente cadastrado com sucesso!");

                this.telaPrincipal.AtualizarTabela();
                this.Close();
            }
        }

        private void AdicionarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

    
    

