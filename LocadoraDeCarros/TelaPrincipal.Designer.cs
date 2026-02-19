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
            pictureBox1 = new PictureBox();
            btnClientes = new Button();
            btnCarros = new Button();
            btnEmprestimos = new Button();
            dgvTabela = new DataGridView();
            btnNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-63, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 109);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.InactiveCaptionText;
            btnClientes.FlatStyle = FlatStyle.Popup;
            btnClientes.ForeColor = SystemColors.ControlLightLight;
            btnClientes.Location = new Point(62, 152);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(120, 45);
            btnClientes.TabIndex = 13;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCarros
            // 
            btnCarros.BackColor = SystemColors.InactiveCaptionText;
            btnCarros.FlatStyle = FlatStyle.Popup;
            btnCarros.ForeColor = SystemColors.ControlLightLight;
            btnCarros.Location = new Point(62, 238);
            btnCarros.Name = "btnCarros";
            btnCarros.Size = new Size(120, 45);
            btnCarros.TabIndex = 14;
            btnCarros.Text = "CARROS";
            btnCarros.UseVisualStyleBackColor = false;
            btnCarros.Click += btnCarros_Click;
            // 
            // btnEmprestimos
            // 
            btnEmprestimos.BackColor = SystemColors.InactiveCaptionText;
            btnEmprestimos.FlatStyle = FlatStyle.Popup;
            btnEmprestimos.ForeColor = SystemColors.ControlLightLight;
            btnEmprestimos.Location = new Point(62, 322);
            btnEmprestimos.Name = "btnEmprestimos";
            btnEmprestimos.Size = new Size(120, 45);
            btnEmprestimos.TabIndex = 15;
            btnEmprestimos.Text = "EMPRESTIMOS";
            btnEmprestimos.UseVisualStyleBackColor = false;
            btnEmprestimos.Click += btnEmprestimos_Click;
            // 
            // dgvTabela
            // 
            dgvTabela.AllowUserToAddRows = false;
            dgvTabela.AllowUserToDeleteRows = false;
            dgvTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabela.Location = new Point(251, 12);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTabela.Size = new Size(843, 487);
            dgvTabela.TabIndex = 0;
            dgvTabela.CellContentClick += dgvTabela_CellContentClick;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(703, 515);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(120, 45);
            btnNovo.TabIndex = 17;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += button1_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(838, 515);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 45);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button2_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(974, 515);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 45);
            btnExcluir.TabIndex = 19;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
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
            Controls.Add(btnEmprestimos);
            Controls.Add(btnCarros);
            Controls.Add(btnClientes);
            Controls.Add(pictureBox1);
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            Load += TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnClientes;
        private Button btnCarros;
        private Button btnEmprestimos;
        private DataGridView dgvTabela;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
    }
}