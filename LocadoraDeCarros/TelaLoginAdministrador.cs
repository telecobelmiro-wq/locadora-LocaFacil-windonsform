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

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "00")
            {
                var telaPrincipal = new TelaPrincipal(true);
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

        private void Form1_Resize(object sender, EventArgs e)
        {
            pnlLoginAdmin.Left = (this.ClientSize.Width - pnlLoginAdmin.Width) / 2;
            pnlLoginAdmin.Top = (this.ClientSize.Height - pnlLoginAdmin.Height) / 2;
        }
    }
}
