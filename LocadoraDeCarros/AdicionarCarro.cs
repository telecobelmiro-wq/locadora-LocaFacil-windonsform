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

                if (cbCategoriaAddCar.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione uma categoria.");
                    return;
                }
                Carro carro = new Carro
                {
                    Modelo = txtModelo.Text,
                    Marca = txtMarca.Text,
                    Cor = txtCor.Text,
                    Ano = ano,
                    Preco = preco,
                    Categoria = cbCategoriaAddCar.SelectedItem.ToString()
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

        private void cbCategoriaAddCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlAdicionarCarro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdicionarCarro_Load(object sender, EventArgs e)
        {
         
        }

        public AdicionarCarro()
        {
            InitializeComponent();
            this.Load += Centralizar;
            this.Resize += Centralizar;
        }

        private void Centralizar(object sender, EventArgs e)
        {
            pnlAdicionarCarro.Left = (this.ClientSize.Width - pnlAdicionarCarro.Width) / 2;
            pnlAdicionarCarro.Top = (this.ClientSize.Height - pnlAdicionarCarro.Height) / 2;
        }
    }
   
}
