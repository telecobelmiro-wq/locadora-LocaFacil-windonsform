using System;
using System.Windows.Forms;
using LocadoraDeCarros.Repositories;
using LocadoraDeCarros.Modelo;

namespace LocadoraDeCarros
{
    public partial class TelaDetalheEmprestimos : Form
    {
        private int idUsuario;

        public TelaDetalheEmprestimos(int id)
        {
            InitializeComponent();
            idUsuario = id;
        }


        private async void TelaDetalheEmprestimos_Load(object sender, EventArgs e)
        {
            var emp = await EmprestimosRepository.ObterPorUsuario(idUsuario);

            if (emp == null)
            {
                MessageBox.Show("Nenhum empréstimo.");
                Close();
                return;
            }

            lblInfo.Text = $"Cliente: {emp.IdCliente} | Carro: {emp.IdCarro}";

            lblEntrega.Text = emp.DataDevolucao.ToString("dd/MM/yyyy");

            lblStatus.Text =
                emp.DataDevolucao.Date < DateTime.Now.Date
                ? "Em atraso"
                : "Em dia";
        }
    }
}