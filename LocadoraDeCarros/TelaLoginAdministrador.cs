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
    public partial class TelaLoginAdministrador : Form
    {
        public TelaLoginAdministrador()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "1234")
            {
                var telaPrincipal = new TelaPrincipal();
                this.Hide();
                telaPrincipal.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Erro ao realizar login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
