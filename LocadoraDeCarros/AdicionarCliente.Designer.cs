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
            pnlAdicionarCliente = new Panel();
            pictureBox1 = new PictureBox();
            lblErro = new Label();
            dtpDataNascimento = new DateTimePicker();
            lblDataNascimento = new Label();
            rbFeminino = new RadioButton();
            rbMasculino = new RadioButton();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            btnAdicionarNovoCliente = new Button();
            lblSexo = new Label();
            lblPreco = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            pnlAdicionarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlAdicionarCliente
            // 
            pnlAdicionarCliente.Anchor = AnchorStyles.None;
            pnlAdicionarCliente.Controls.Add(pictureBox1);
            pnlAdicionarCliente.Controls.Add(lblErro);
            pnlAdicionarCliente.Controls.Add(dtpDataNascimento);
            pnlAdicionarCliente.Controls.Add(lblDataNascimento);
            pnlAdicionarCliente.Controls.Add(rbFeminino);
            pnlAdicionarCliente.Controls.Add(rbMasculino);
            pnlAdicionarCliente.Controls.Add(txtCpf);
            pnlAdicionarCliente.Controls.Add(txtEmail);
            pnlAdicionarCliente.Controls.Add(txtNome);
            pnlAdicionarCliente.Controls.Add(btnAdicionarNovoCliente);
            pnlAdicionarCliente.Controls.Add(lblSexo);
            pnlAdicionarCliente.Controls.Add(lblPreco);
            pnlAdicionarCliente.Controls.Add(lblMarca);
            pnlAdicionarCliente.Controls.Add(lblModelo);
            pnlAdicionarCliente.Location = new Point(43, 35);
            pnlAdicionarCliente.Name = "pnlAdicionarCliente";
            pnlAdicionarCliente.Size = new Size(1100, 700);
            pnlAdicionarCliente.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(368, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 109);
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(405, 253);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 15);
            lblErro.TabIndex = 41;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(368, 392);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(383, 23);
            dtpDataNascimento.TabIndex = 40;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(368, 374);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(131, 15);
            lblDataNascimento.TabIndex = 39;
            lblDataNascimento.Text = "DATA DE NASCIMENTO";
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(466, 464);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(81, 19);
            rbFeminino.TabIndex = 38;
            rbFeminino.TabStop = true;
            rbFeminino.Text = "FEMININO";
            rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(367, 464);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(93, 19);
            rbMasculino.TabIndex = 37;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "MASCULINO";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(367, 328);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "000.000.000-00";
            txtCpf.Size = new Size(384, 23);
            txtCpf.TabIndex = 36;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(367, 271);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "exemplo@gmail.com";
            txtEmail.Size = new Size(384, 23);
            txtEmail.TabIndex = 35;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(368, 216);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Dioclésio Santos";
            txtNome.Size = new Size(383, 23);
            txtNome.TabIndex = 34;
            // 
            // btnAdicionarNovoCliente
            // 
            btnAdicionarNovoCliente.BackColor = Color.Black;
            btnAdicionarNovoCliente.FlatStyle = FlatStyle.Popup;
            btnAdicionarNovoCliente.ForeColor = SystemColors.ControlLight;
            btnAdicionarNovoCliente.Location = new Point(453, 544);
            btnAdicionarNovoCliente.Name = "btnAdicionarNovoCliente";
            btnAdicionarNovoCliente.Size = new Size(238, 40);
            btnAdicionarNovoCliente.TabIndex = 33;
            btnAdicionarNovoCliente.Text = "ADICIONAR NOVO CLIENTE";
            btnAdicionarNovoCliente.UseVisualStyleBackColor = false;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(367, 446);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 15);
            lblSexo.TabIndex = 32;
            lblSexo.Text = "SEXO";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(367, 310);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(28, 15);
            lblPreco.TabIndex = 31;
            lblPreco.Text = "CPF";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(368, 253);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(41, 15);
            lblMarca.TabIndex = 30;
            lblMarca.Text = "EMAIL";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(368, 198);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(42, 15);
            lblModelo.TabIndex = 29;
            lblModelo.Text = "NOME";
            // 
            // AdicionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1184, 761);
            Controls.Add(pnlAdicionarCliente);
            Name = "AdicionarCliente";
            Text = "AdicionarCliente";
            WindowState = FormWindowState.Maximized;
            Load += AdicionarCliente_Load;
            pnlAdicionarCliente.ResumeLayout(false);
            pnlAdicionarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblAno;
        private TextBox txtAno;
        private Panel pnlAdicionarCliente;
        private PictureBox pictureBox1;
        private Label lblErro;
        private DateTimePicker dtpDataNascimento;
        private Label lblDataNascimento;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Button btnAdicionarNovoCliente;
        private Label lblSexo;
        private Label lblPreco;
        private Label lblMarca;
        private Label lblModelo;
    }
}