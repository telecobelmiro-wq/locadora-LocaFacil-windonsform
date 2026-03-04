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
        private  bool isAdmin;
        private Cliente cliente;
        private Cliente clienteLogado;


        public TelaPrincipal(Cliente cliente)
        {
            InitializeComponent();
            clienteLogado = cliente;
            isAdmin = false;
        }


        public TelaPrincipal(bool isAdmin)
        {
            InitializeComponent();

            this.isAdmin = isAdmin;
            this.Enabled = true;
            
            btnExcluir.Enabled = isAdmin;
            btnEditar.Enabled = isAdmin;
            btnNovo.Enabled = isAdmin;
            
            Load += TelaPrincipal_Load;
        }

        private async void TelaPrincipal_Load(object sender, EventArgs e)
        {
         
            
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

            else if (entidadeAtual == "Emprestimo")
            {
                var emprestimos = await EmprestimosRepository.ObterTodos();
                dgvTabela.DataSource = new BindingList<EmprestimoView>(emprestimos.ToList());
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

            btnNovo.Enabled = isAdmin;
            btnEditar.Enabled = isAdmin;
            btnExcluir.Enabled = isAdmin;
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

            btnNovo.Enabled = isAdmin;
            btnEditar.Enabled = isAdmin;
            btnExcluir.Enabled = isAdmin;
        }



        private async void btnTelaEmprestimos_Click(object sender, EventArgs e)
        {
            entidadeAtual = "Emprestimo";
            await AtualizarTabela();

            btnNovo.Enabled = isAdmin;
            btnEditar.Enabled = isAdmin;
            btnExcluir.Enabled = isAdmin;

        }

        private async void btnVisualizarEmprestimos_Click(object sender, EventArgs e)
        {
            var lista = await EmprestimosRepository.ObterTodos();
            dgvTabela.DataSource = lista.ToList();
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

        private void pnlTelaPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        
        public TelaPrincipal()
        {
            InitializeComponent();
            this.Load += Centralizar;
            this.Resize += Centralizar;
        }

        private void Centralizar(object sender, EventArgs e)
        {
            pnlTelaPrincipal.Left = (this.ClientSize.Width - pnlTelaPrincipal.Width) / 2;
            pnlTelaPrincipal.Top = (this.ClientSize.Height - pnlTelaPrincipal.Height) / 2;
        }
    }
}
