using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraDeCarros.Modelo;
using LocadoraDeCarros.Repositories;

namespace LocadoraDeCarros
{
    public partial class TelaEditarCarro : Form
    {
        private int idCarro;
        private string entidadeAtual = "Carro";


        public TelaEditarCarro(int id)
        {
            InitializeComponent();
            idCarro = id;
            CarregarDados();
        }

        private async void CarregarDados()
        {
            var carro = await CarroRepository.ObterPorId(idCarro);

            txtModelo.Text = carro.Modelo;
            txtMarca.Text = carro.Marca;
            txtCor.Text = carro.Cor;
            txtAno.Text = carro.Ano.ToString();
            txtPreco.Text = carro.Preco.ToString();
        }

        private async void txtSalvar_Click(object sender, EventArgs e)
        {
            var carro = new Carro
            {
                Id = idCarro,
                Modelo = txtModelo.Text,
                Marca = txtMarca.Text,
                Cor = txtCor.Text,
                Ano = int.Parse(txtAno.Text),
                Preco = decimal.Parse(txtPreco.Text)
            };

            await CarroRepository.Atualizar(carro);

            MessageBox.Show("Carro atualizado!");
            this.Close();
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public TelaEditarCarro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TelaEditarCarro_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarEditarCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSalvarEditarCar_Click(object sender, EventArgs e)
        {
            if (
                //se algum campo estiver vazio, execute o que está dentro do if.
                string.IsNullOrWhiteSpace(txtCor.Text) || 
                string.IsNullOrWhiteSpace(txtPreco.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtAno.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Preço inválido!");
                return;
            }

            if (!int.TryParse(txtAno.Text, out int ano))
            {
                MessageBox.Show("Ano inválido!");
                return;
            }

            var carro = new Carro
            {
                Cor = txtCor.Text,
                Preco = preco,
                Modelo = txtModelo.Text,
                Marca = txtMarca.Text,
                Ano = ano
            };

            await CarroRepository.Adicionar(carro);

            MessageBox.Show("Carro adicionado com sucesso!");
            try
            {
              

                await CarroRepository.Atualizar(carro);
                MessageBox.Show("Carro atualizado com sucesso!");
                this.Close();
                
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
                }

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
