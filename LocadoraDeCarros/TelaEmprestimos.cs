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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LocadoraDeCarros
{
    public partial class TelaEmprestimos : Form
    {

        private Carro carroSelecionado;
        private int idCarroSelecionado;


        public TelaEmprestimos(int idCarro)
        {
            InitializeComponent();
            idCarroSelecionado = idCarro;

           txtIdVeiculosEmprestimos.Text = idCarroSelecionado.ToString();

            Load += TelaEmprestimos_Load;
        }

        public enum StatusEmprestimo
        {
            Ativo,
            Inativo,
            Finalizado
        }

        private async void TelaEmprestimos_Load(object sender, EventArgs e)
        {
            carroSelecionado = await CarroRepository.ObterPorId(idCarroSelecionado);
        }




        private void txtStatusEmprestimos_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatusEmprestimos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnSalvarEmprestimos_Click(object sender, EventArgs e)
        {
            Emprestimos emp = new Emprestimos
            {
                IdCliente = Convert.ToInt32(txtIdClienteEmprestimos.Text),
                IdCarro = Convert.ToInt32(txtIdVeiculosEmprestimos.Text),
                Status = "Ativo",
                DataRetirada = DateTime.Now
            };

            
            emp.CalcularDataDevolucao("Ouro"); 

            await EmprestimosRepository.Adicionar(emp);
            this.Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


