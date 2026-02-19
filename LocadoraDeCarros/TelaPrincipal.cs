using System.ComponentModel;
using LocadoraDeCarros.Modelo;
using System.ComponentModel;
using System.Linq;
using LocadoraDeCarros.Repositories;
using System.Data.SqlClient;


namespace LocadoraDeCarros
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();

            Load += TelaPrincipal_Load;
        }

        


        private async void TelaPrincipal_Load(object sender, EventArgs e)
        {
            await AtualizarTabela();
        }

        public async Task AtualizarTabela()
        {
            var clientes = await ClienteRepository.ObterTodos();
            dgvTabela.DataSource = new BindingList<Cliente>(clientes.ToList());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
          
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            var adicionarCliente = new AdicionarCliente(this);
            adicionarCliente.Show();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dgvTabela.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente para excluir.");
                return;
            }

            string nomeCliente = dgvTabela.SelectedRows[0].Cells[1].Value.ToString();

            var retorno = MessageBox.Show(
                $"Tem certeza que deseja excluir o cliente {nomeCliente}?",
                "Exclusão cliente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                int idCliente = Convert.ToInt32(dgvTabela.SelectedRows[0].Cells[0].Value);

                await ClienteRepository.Deletar(idCliente);

                MessageBox.Show(
                    $"O cliente {nomeCliente} foi deletado com sucesso!",
                    "Exclusão cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await AtualizarTabela();
            }
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            TelaEmprestimos tela = new TelaEmprestimos();
            tela.ShowDialog();
        }
    }
}
