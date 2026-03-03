using System.ComponentModel;
using LocadoraDeCarros.Modelo;
using System.Linq;
using LocadoraDeCarros.Repositories;
using System.Windows.Forms;

namespace LocadoraDeCarros
{
    public partial class TelaPrincipal : Form
    {
        private string entidadeAtual = "Cliente";
        private string tipoUsuario;
        private readonly bool isAdmin;
        private Cliente cliente;
        private Cliente clienteLogado;

        public TelaPrincipal(Cliente cliente)
        {
            InitializeComponent();

            clienteLogado = cliente;
            lblUsuario.Text = "Bem-vindo, " + clienteLogado.Nome;
        }


        public TelaPrincipal(bool isAdmin)
        {
            InitializeComponent();

            this.isAdmin = isAdmin;
            this.Enabled = true;

            btnNovo.Enabled = isAdmin;
            btnEditar.Enabled = isAdmin;
            btnExcluir.Enabled = isAdmin;

            Load += TelaPrincipal_Load;
        }

        private async void TelaPrincipal_Load(object sender, EventArgs e)
        {
            await AtualizarTabela();
        }

        public async Task AtualizarTabela()
        {
            if (entidadeAtual == "Cliente")
            {
                var clientes = await ClienteRepository.ObterTodos();
                dgvTabela.DataSource = new BindingList<Cliente>(clientes.ToList());
            }
            else if (entidadeAtual == "Carro")
            {
                var carros = await CarroRepository.ObterTodos();
                dgvTabela.DataSource = new BindingList<Carro>(carros.ToList());
            }
            // se entidade for emprestimo, busca do emprestimo repository
            else if (entidadeAtual == "Emprestimo")
            {
                var emprestimos = await EmprestimosRepository.ObterTodos();
                dgvTabela.DataSource = new BindingList<Emprestimos>(emprestimos.ToList());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private async void btnCarros_Click(object sender, EventArgs e)
        {
            entidadeAtual = "Carro";
            btnEmprestimos.Enabled = true;
            await AtualizarTabela();

            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
            btnNovo.Enabled = true;

        }


        private async void button2_Click(object sender, EventArgs e)
        {
            if (dgvTabela.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para editar.");
                return;
            }

            if (entidadeAtual == "Cliente")
            {
                var cliente = dgvTabela.SelectedRows[0].DataBoundItem as Cliente;

                if (cliente != null)
                {
                    new TelaEditarCliente(cliente.Id).ShowDialog();
                }
            }
            else if (entidadeAtual == "Carro")
            {
                var carro = dgvTabela.SelectedRows[0].DataBoundItem as Carro;

                if (carro != null)
                {
                    new TelaEditarCarro(carro.Id).ShowDialog();
                }
            }

            await AtualizarTabela();
        }


        private async void button1_Click(object sender, EventArgs e)
        {

            if (entidadeAtual == "Cliente")
            {
                var tela = new AdicionarCliente(this);
                tela.ShowDialog();
            }
            else
            {
                var tela = new AdicionarCarro(this);
                tela.ShowDialog();
            }
            await AtualizarTabela();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvTabela.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para excluir.");
                return;
            }

            int id = Convert.ToInt32(dgvTabela.SelectedRows[0].Cells[0].Value);
            string nome = dgvTabela.SelectedRows[0].Cells[1].Value.ToString();

            var confirmacao = MessageBox.Show(
                $"Tem certeza que deseja excluir {nome}?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                if (entidadeAtual == "Cliente")
                {
                    await ClienteRepository.Deletar(id);
                    MessageBox.Show("Cliente excluído com sucesso!");
                }
                else
                {
                    await CarroRepository.Deletar(id);
                    MessageBox.Show("Carro excluído com sucesso!");
                }

                await AtualizarTabela();
            }
        }

        private async void btnEmprestimos_Click(object sender, EventArgs e)
        {


            if (dgvTabela.CurrentRow != null)
            {
                int idCarro = Convert.ToInt32(dgvTabela.CurrentRow.Cells["Id"].Value);

                TelaEmprestimos tela = new TelaEmprestimos(idCarro);
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um carro primeiro!");
            }

            entidadeAtual = "Emprestimo";

            btnEmprestimos.Enabled = false;

            await AtualizarTabela();

        }


        private async void btnClientes_Click_1(object sender, EventArgs e)
        {
            entidadeAtual = "Cliente";
            btnEmprestimos.Enabled = false;
            await AtualizarTabela();

            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
            btnNovo.Enabled = true;
        }

        private void pnlTelaPrincipal_Paint(object sender, PaintEventArgs e)
        {
            lblUsuario.Enabled = true;
        }

        private async void btnTelaEmprestimos_Click(object sender, EventArgs e)
        {
            entidadeAtual = "Emprestimo";
            await AtualizarTabela();

            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnNovo.Enabled = false;
        }

        private async void btnDevolverEmpre_Click(object sender, EventArgs e)
        {
            if (dgvTabela.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um empréstimo.");
                return;
            }


            int id = Convert.ToInt32(dgvTabela.SelectedRows[0].Cells["Id"].Value);

            var emprestimo = await EmprestimosRepository.ObterPorId(id);

            if (emprestimo == null)
            {
                MessageBox.Show("Empréstimo não encontrado.");
                return;
            }

            emprestimo.Status = "Finalizado";
            emprestimo.DataDevolucao = DateTime.Now;

            await EmprestimosRepository.Atualizar(emprestimo);

            MessageBox.Show("Devolvido com sucesso!");

            await AtualizarTabela();
        }
    }
}
