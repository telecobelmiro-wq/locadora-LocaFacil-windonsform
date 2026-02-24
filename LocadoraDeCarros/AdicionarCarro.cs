using LocadoraDeCarros.Modelo;
using LocadoraDeCarros.Repositories;

namespace LocadoraDeCarros
{
    public partial class AdicionarCarro : Form
    {
        private TelaPrincipal telaPrincipal;

        public AdicionarCarro(TelaPrincipal tela)
        {
            InitializeComponent();
            telaPrincipal = tela;
        }

        private async void button1_Click(object sender, EventArgs e)
        {


        }

        private async void btnAdicionarCarro_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtModelo.Text) ||
                    string.IsNullOrWhiteSpace(txtMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtCor.Text) ||
                    string.IsNullOrWhiteSpace(txtPreco.Text) ||
                    string.IsNullOrWhiteSpace(txtAno.Text))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }

                if (!int.TryParse(txtAno.Text, out int ano))
                {
                    MessageBox.Show("Ano inválido.");
                    return;
                }

                if (!decimal.TryParse(txtPreco.Text, out decimal preco))
                {
                    MessageBox.Show("Preço inválido.");
                    return;
                }

                if (ano < 1900 || ano > DateTime.Now.Year + 1)
                {
                    MessageBox.Show("Ano fora do intervalo válido.");
                    return;
                }

                if (preco <= 0)
                {
                    MessageBox.Show("Preço deve ser maior que zero.");
                    return;
                }

                Carro carro = new Carro
                {
                    Modelo = txtModelo.Text,
                    Marca = txtMarca.Text,
                    Cor = txtCor.Text,
                    Ano = ano,
                    Preco = preco
                };

                await CarroRepository.Adicionar(carro);

                MessageBox.Show("Carro cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdicionarCarro_Resize(object sender, EventArgs e)
        {
            pnlAdicionarCarro.Left = (ClientSize.Width - pnlAdicionarCarro.Width) / 2;
            pnlAdicionarCarro.Top = (ClientSize.Height - pnlAdicionarCarro.Height) / 2;
        }
    }
}