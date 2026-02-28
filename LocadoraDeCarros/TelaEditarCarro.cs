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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LocadoraDeCarros
{
    public partial class TelaEditarCarro : Form
    {
        private int idCarro;
        private string entidadeAtual = "Carro";
        private Carro carro;

        public TelaEditarCarro(int id)
        {
            InitializeComponent();
            idCarro = id;
            CarregarDados();
        }

        private async void CarregarDados()
        {
            var carro = await CarroRepository.ObterPorId(idCarro);
            this.carro = carro;

            txtModelo.Text = carro.Modelo;
            txtMarca.Text = carro.Marca;
            txtCor.Text = carro.Cor;
            txtAno.Text = carro.Ano.ToString();
            txtPreco.Text = carro.Preco.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TelaEditarCarro_Load(object sender, EventArgs e)
        {
            cbCategoria.SelectedIndex = 0;
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
            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria!");
                return;
            }

            carro.Cor = txtCor.Text;
            carro.Preco = preco;
            carro.Modelo = txtModelo.Text;
            carro.Marca = txtMarca.Text;
            carro.Ano = ano;
            carro.Categoria = cbCategoria.SelectedItem.ToString();

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

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
