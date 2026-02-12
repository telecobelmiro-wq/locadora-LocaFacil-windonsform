using System.ComponentModel;
using LocadoraDeCarros.Modelo;
using System.ComponentModel;
using System.Linq;
using LocadoraDeCarros.Repositories;


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
    }
}
