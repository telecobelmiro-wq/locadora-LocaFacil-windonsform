namespace LocadoraDeCarros
{
    partial class AdicionarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarCliente));
            lblModelo = new Label();
            lblMarca = new Label();
            lblPreco = new Label();
            lblSexo = new Label();
            btnAdicionarNovoCliente = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            rbMasculino = new RadioButton();
            rbFeminino = new RadioButton();
            lblDataNascimento = new Label();
            dtpDataNascimento = new DateTimePicker();
            lblErro = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(208, 194);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(42, 15);
            lblModelo.TabIndex = 14;
            lblModelo.Text = "NOME";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(209, 254);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(41, 15);
            lblMarca.TabIndex = 15;
            lblMarca.Text = "EMAIL";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(482, 194);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(28, 15);
            lblPreco.TabIndex = 16;
            lblPreco.Text = "CPF";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(482, 254);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 15);
            lblSexo.TabIndex = 17;
            lblSexo.Text = "SEXO";
            // 
            // btnAdicionarNovoCliente
            // 
            btnAdicionarNovoCliente.BackColor = Color.Black;
            btnAdicionarNovoCliente.FlatStyle = FlatStyle.Popup;
            btnAdicionarNovoCliente.ForeColor = SystemColors.ControlLight;
            btnAdicionarNovoCliente.Location = new Point(604, 395);
            btnAdicionarNovoCliente.Name = "btnAdicionarNovoCliente";
            btnAdicionarNovoCliente.Size = new Size(177, 40);
            btnAdicionarNovoCliente.TabIndex = 19;
            btnAdicionarNovoCliente.Text = "ADICIONAR NOVO CLIENTE";
            btnAdicionarNovoCliente.UseVisualStyleBackColor = false;
            btnAdicionarNovoCliente.Click += btnAdicionarNovoCliente_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(198, 212);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Dioclésio Santos";
            txtNome.Size = new Size(125, 23);
            txtNome.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(198, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "exemplo@gmail.com";
            txtEmail.Size = new Size(125, 23);
            txtEmail.TabIndex = 21;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(479, 212);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "000.000.000-00";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 22;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(479, 276);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(93, 19);
            rbMasculino.TabIndex = 23;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "MASCULINO";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(479, 301);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(81, 19);
            rbFeminino.TabIndex = 24;
            rbFeminino.TabStop = true;
            rbFeminino.Text = "FEMININO";
            rbFeminino.UseVisualStyleBackColor = true;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(198, 314);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(131, 15);
            lblDataNascimento.TabIndex = 25;
            lblDataNascimento.Text = "DATA DE NASCIMENTO";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(198, 332);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(200, 23);
            dtpDataNascimento.TabIndex = 26;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(307, 160);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 15);
            lblErro.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(235, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 109);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // AdicionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblErro);
            Controls.Add(dtpDataNascimento);
            Controls.Add(lblDataNascimento);
            Controls.Add(rbFeminino);
            Controls.Add(rbMasculino);
            Controls.Add(txtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(btnAdicionarNovoCliente);
            Controls.Add(lblSexo);
            Controls.Add(lblPreco);
            Controls.Add(lblMarca);
            Controls.Add(lblModelo);
            Name = "AdicionarCliente";
            Text = "AdicionarCliente";
            WindowState = FormWindowState.Maximized;
            Load += AdicionarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblModelo;
        private Label lblMarca;
        private Label lblPreco;
        private Label lblSexo;
        private Label lblAno;
        private Button btnAdicionarNovoCliente;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private RadioButton rbMasculino;
        private RadioButton rbFeminino;
        private TextBox txtAno;
        private Label lblDataNascimento;
        private DateTimePicker dtpDataNascimento;
        private Label lblErro;
        private PictureBox pictureBox1;
    }
}