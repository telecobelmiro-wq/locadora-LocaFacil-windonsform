using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            await CarroRepository.Adicionar(carro);

            MessageBox.Show("Carro adicionado com sucesso!");
            await telaPrincipal.AtualizarTabela();
            this.Close();
        }

        private void AdicionarCarro_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}