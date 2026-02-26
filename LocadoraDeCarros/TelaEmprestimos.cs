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
        public enum StatusEmprestimo
        {
            Ativo,
            Inativo,
            Finalizado
        }

        public TelaEmprestimos()
        {
            InitializeComponent();
        }

        private void TelaEmprestimos_Load(object sender, EventArgs e)
        {
           
        }




        private void txtStatusEmprestimos_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatusEmprestimos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnSalvarEmprestimos_Click(object sender, EventArgs e)
        {
            var emprestimo = new Emprestimos();

            emprestimo.IdCliente = int.Parse(txtIdClienteEmprestimos.Text);
            emprestimo.IdCarro = int.Parse(txtIdVeiculosEmprestimos.Text);
           

            await EmprestimosRepository.Adicionar(emprestimo);

            MessageBox.Show("Salvo!");
            this.Close();
        }


    }
}


