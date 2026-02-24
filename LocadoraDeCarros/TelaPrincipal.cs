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
        }

        private void btnAdicionarCarro_Click(object sender, EventArgs e)
        {

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
            await AtualizarTabela();
        }

        private async void btnClientes_Click(object sender, EventArgs e)
        {
            entidadeAtual = "Cliente";
            await AtualizarTabela();
        }

        private async void button2_Click(object sender, EventArgs e) // EDITAR
        {
            if (dgvTabela.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para editar.");
                return;
            }

            int idRegistro = Convert.ToInt32(dgvTabela.SelectedRows[0].Cells[0].Value);

            if (entidadeAtual == "Carro")
            {
                new TelaEditarCarro(idRegistro).ShowDialog();
            }
            else
            {
                new TelaEditarCliente(idRegistro).ShowDialog();
            }

            await AtualizarTabela();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            TelaEmprestimos tela = new TelaEmprestimos();
            tela.ShowDialog();
        }

        public TelaPrincipal(string tipo)
        {
            InitializeComponent();
            tipoUsuario = tipo;
        }

        private void CentralizarPainel()
        {
            pnlTelaPrincipal.Left = (this.Width - pnlTelaPrincipal.Width) / 2;
            pnlTelaPrincipal.Top = (this.Height - pnlTelaPrincipal.Height) / 2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CentralizarPainel();
        }
    }
}