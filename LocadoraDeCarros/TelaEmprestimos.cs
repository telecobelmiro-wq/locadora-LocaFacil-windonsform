using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            cmbStatusEmprestimos.DataSource = Enum.GetValues(typeof(StatusEmprestimo));
        }




        private void txtStatusEmprestimos_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatusEmprestimos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarEmprestimos_Click(object sender, EventArgs e)
        {
            
        }
    }
}
