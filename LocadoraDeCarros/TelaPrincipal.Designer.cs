namespace LocadoraDeCarros
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            btnExcluir = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            dgvTabela = new DataGridView();
            btnCarros = new Button();
            btnClientes = new Button();
            pictureBox1 = new PictureBox();
            btnEmprestimos = new Button();
            pnlTelaPrincipal = new Panel();
            btnDevolverEmpre = new Button();
            btnTelaEmprestimos = new Button();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTelaPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Black;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.ForeColor = SystemColors.ControlLight;
            btnExcluir.Location = new Point(977, 509);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 40);
            btnExcluir.TabIndex = 19;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.ForeColor = SystemColors.ControlLight;
            btnEditar.Location = new Point(851, 509);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += button2_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Black;
            btnNovo.FlatStyle = FlatStyle.Popup;
            btnNovo.ForeColor = SystemColors.ControlLight;
            btnNovo.Location = new Point(725, 509);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(120, 40);
            btnNovo.TabIndex = 17;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += button1_Click;
            // 
            // dgvTabela
            // 
            dgvTabela.AllowUserToAddRows = false;
            dgvTabela.AllowUserToDeleteRows = false;
            dgvTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabela.Location = new Point(262, 16);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTabela.Size = new Size(835, 472);
            dgvTabela.TabIndex = 0;
            dgvTabela.CellContentClick += dgvTabela_CellContentClick;
            // 
            // btnCarros
            // 
            btnCarros.BackColor = SystemColors.InactiveCaptionText;
            btnCarros.FlatStyle = FlatStyle.Popup;
            btnCarros.ForeColor = SystemColors.ControlLightLight;
            btnCarros.Location = new Point(28, 293);
            btnCarros.Name = "btnCarros";
            btnCarros.Size = new Size(181, 44);
            btnCarros.TabIndex = 14;
            btnCarros.Text = "Carros";
            btnCarros.UseVisualStyleBackColor = false;
            btnCarros.Click += btnCarros_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Black;
            btnClientes.FlatStyle = FlatStyle.Popup;
            btnClientes.ForeColor = SystemColors.ControlLightLight;
            btnClientes.Location = new Point(28, 206);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(181, 44);
            btnClientes.TabIndex = 20;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-65, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 109);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnEmprestimos
            // 
            btnEmprestimos.BackColor = Color.Black;
            btnEmprestimos.Enabled = false;
            btnEmprestimos.FlatStyle = FlatStyle.System;
            btnEmprestimos.ForeColor = SystemColors.ActiveCaptionText;
            btnEmprestimos.Location = new Point(473, 509);
            btnEmprestimos.Name = "btnEmprestimos";
            btnEmprestimos.Size = new Size(120, 40);
            btnEmprestimos.TabIndex = 15;
            btnEmprestimos.Text = "EMPRESTIMO";
            btnEmprestimos.UseVisualStyleBackColor = false;
            btnEmprestimos.Click += btnEmprestimos_Click;
            // 
            // pnlTelaPrincipal
            // 
            pnlTelaPrincipal.Controls.Add(btnDevolverEmpre);
            pnlTelaPrincipal.Controls.Add(btnTelaEmprestimos);
            pnlTelaPrincipal.Controls.Add(lblUsuario);
            pnlTelaPrincipal.Controls.Add(btnExcluir);
            pnlTelaPrincipal.Controls.Add(btnClientes);
            pnlTelaPrincipal.Controls.Add(btnEditar);
            pnlTelaPrincipal.Controls.Add(btnEmprestimos);
            pnlTelaPrincipal.Controls.Add(btnNovo);
            pnlTelaPrincipal.Controls.Add(pictureBox1);
            pnlTelaPrincipal.Controls.Add(btnCarros);
            pnlTelaPrincipal.Controls.Add(dgvTabela);
            pnlTelaPrincipal.Location = new Point(42, 27);
            pnlTelaPrincipal.Name = "pnlTelaPrincipal";
            pnlTelaPrincipal.Size = new Size(1100, 700);
            pnlTelaPrincipal.TabIndex = 0;
            pnlTelaPrincipal.Paint += pnlTelaPrincipal_Paint;
            // 
            // btnDevolverEmpre
            // 
            btnDevolverEmpre.BackColor = Color.Black;
            btnDevolverEmpre.FlatStyle = FlatStyle.Popup;
            btnDevolverEmpre.ForeColor = SystemColors.ControlLight;
            btnDevolverEmpre.Location = new Point(599, 509);
            btnDevolverEmpre.Name = "btnDevolverEmpre";
            btnDevolverEmpre.Size = new Size(120, 40);
            btnDevolverEmpre.TabIndex = 23;
            btnDevolverEmpre.Text = "DEVOLVER";
            btnDevolverEmpre.UseVisualStyleBackColor = false;
            btnDevolverEmpre.Click += btnDevolverEmpre_Click;
            // 
            // btnTelaEmprestimos
            // 
            btnTelaEmprestimos.BackColor = SystemColors.InactiveCaptionText;
            btnTelaEmprestimos.FlatStyle = FlatStyle.Popup;
            btnTelaEmprestimos.ForeColor = SystemColors.ControlLightLight;
            btnTelaEmprestimos.Location = new Point(28, 382);
            btnTelaEmprestimos.Name = "btnTelaEmprestimos";
            btnTelaEmprestimos.Size = new Size(181, 44);
            btnTelaEmprestimos.TabIndex = 22;
            btnTelaEmprestimos.Text = "Visualizar Emprestimos";
            btnTelaEmprestimos.UseVisualStyleBackColor = false;
            btnTelaEmprestimos.Click += btnTelaEmprestimos_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(77, 159);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 21;
            lblUsuario.Text = "label1";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1184, 761);
            Controls.Add(pnlTelaPrincipal);
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabela).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTelaPrincipal.ResumeLayout(false);
            pnlTelaPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnClientes;
        private Button btnCarros;
        private DataGridView dgvTabela;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnEmprestimos;
        private Panel pnlTelaPrincipal;
        private Label lblUsuario;
        private Button btnTelaEmprestimos;
        private Button btnDevolverEmpre;
    }
}