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
            var carro = new Carro
            {
                Cor = txtCor.Text,
                Preco = decimal.Parse(txtPreco.Text),
                Modelo = txtModelo.Text,
                Marca = txtMarca.Text,
                Ano = Convert.ToInt32(txtAno.Text)
            };

            await CarroRepository.Adicionar(carro);

            MessageBox.Show("Carro adicionado com sucesso!");
            await telaPrincipal.AtualizarTabela();
            this.Close();
        }

        private void AdicionarCarro_Load(object sender, EventArgs e)
        {

        }
    }
}