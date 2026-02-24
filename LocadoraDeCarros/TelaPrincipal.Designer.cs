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
            btnExcluir.Location = new Point(974, 534);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 26);
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
            btnEditar.Location = new Point(838, 534);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 26);
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
            btnNovo.Location = new Point(703, 534);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(120, 26);
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
            dgvTabela.Location = new Point(214, 138);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTabela.Size = new Size(676, 346);
            dgvTabela.TabIndex = 0;
            dgvTabela.CellContentClick += dgvTabela_CellContentClick;
            // 
            // btnCarros
            // 
            btnCarros.BackColor = SystemColors.InactiveCaptionText;
            btnCarros.FlatStyle = FlatStyle.Popup;
            btnCarros.ForeColor = SystemColors.ControlLightLight;
            btnCarros.Location = new Point(40, 328);
            btnCarros.Name = "btnCarros";
            btnCarros.Size = new Size(109, 41);
            btnCarros.TabIndex = 14;
            btnCarros.Text = "CARROS";
            btnCarros.UseVisualStyleBackColor = false;
            btnCarros.Click += btnCarros_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.InactiveCaptionText;
            btnClientes.FlatStyle = FlatStyle.Popup;
            btnClientes.ForeColor = SystemColors.ControlLightLight;
            btnClientes.Location = new Point(40, 235);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(109, 41);
            btnClientes.TabIndex = 13;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(380, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 109);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnEmprestimos
            // 
            btnEmprestimos.BackColor = Color.Black;
            btnEmprestimos.FlatStyle = FlatStyle.System;
            btnEmprestimos.ForeColor = SystemColors.ActiveCaptionText;
            btnEmprestimos.Location = new Point(515, 485);
            btnEmprestimos.Name = "btnEmprestimos";
            btnEmprestimos.Size = new Size(127, 26);
            btnEmprestimos.TabIndex = 15;
            btnEmprestimos.Text = "NOVO EMPRESTIMO";
            btnEmprestimos.UseVisualStyleBackColor = false;
            btnEmprestimos.Click += btnEmprestimos_Click;
            // 
            // pnlTelaPrincipal
            // 
            pnlTelaPrincipal.Controls.Add(btnEmprestimos);
            pnlTelaPrincipal.Location = new Point(12, 40);
            pnlTelaPrincipal.Name = "pnlTelaPrincipal";
            pnlTelaPrincipal.Size = new Size(1057, 525);
            pnlTelaPrincipal.TabIndex = 0;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1106, 577);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(dgvTabela);
            Controls.Add(btnCarros);
            Controls.Add(btnClientes);
            Controls.Add(pictureBox1);
            Controls.Add(pnlTelaPrincipal);
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabela).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTelaPrincipal.ResumeLayout(false);
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
    }
}