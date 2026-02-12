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
            btnAdicionarCarro = new Button();
            this.txtCPF = new TextBox();
            this.txtEmail = new TextBox();
            this.txtNome = new TextBox();
            this.lblCPF = new Label();
            this.lblSexo = new Label();
            this.lblEmail = new Label();
            lblNome = new Label();
            pictureBox1 = new PictureBox();
            rdbMasculino = new RadioButton();
            rdbFeminino = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionarCarro
            // 
            btnAdicionarCarro.BackColor = Color.Transparent;
            btnAdicionarCarro.Location = new Point(330, 357);
            btnAdicionarCarro.Name = "btnAdicionarCarro";
            btnAdicionarCarro.Size = new Size(130, 38);
            btnAdicionarCarro.TabIndex = 35;
            btnAdicionarCarro.Text = "Adicionar Carro";
            btnAdicionarCarro.UseVisualStyleBackColor = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new Point(281, 282);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new Size(100, 23);
            this.txtCPF.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(417, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(100, 23);
            this.txtEmail.TabIndex = 32;
            // 
            // txtNome
            // 
            this.txtNome.Location = new Point(281, 215);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new Size(100, 23);
            this.txtNome.TabIndex = 30;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new Font("Segoe UI", 12F);
            this.lblCPF.Location = new Point(316, 258);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new Size(37, 21);
            this.lblCPF.TabIndex = 28;
            this.lblCPF.Text = "CPF";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new Font("Segoe UI", 12F);
            this.lblSexo.Location = new Point(446, 258);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new Size(48, 21);
            this.lblSexo.TabIndex = 27;
            this.lblSexo.Text = "SEXO";
            this.lblSexo.Click += this.lblCor_Click;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Segoe UI", 12F);
            this.lblEmail.Location = new Point(440, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(54, 21);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "EMAIL";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(307, 191);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 25;
            lblNome.Text = "NOME";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 115);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(418, 286);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 36;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            rdbFeminino.AutoSize = true;
            rdbFeminino.Location = new Point(418, 311);
            rdbFeminino.Name = "rdbFeminino";
            rdbFeminino.Size = new Size(75, 19);
            rdbFeminino.TabIndex = 37;
            rdbFeminino.TabStop = true;
            rdbFeminino.Text = "Feminino";
            rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // AdicionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(rdbFeminino);
            Controls.Add(rdbMasculino);
            Controls.Add(btnAdicionarCarro);
            Controls.Add(this.txtCPF);
            Controls.Add(this.txtEmail);
            Controls.Add(this.txtNome);
            Controls.Add(this.lblCPF);
            Controls.Add(this.lblSexo);
            Controls.Add(this.lblEmail);
            Controls.Add(lblNome);
            Controls.Add(pictureBox1);
            Name = "AdicionarCliente";
            Text = "AdicionarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionarCarro;
        private TextBox txtCor;
        private TextBox txtPreco;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private Label lblPreco;
        private Label lblCor;
        private Label lblMarca;
        private Label lblNome;
        private PictureBox pictureBox1;
        private RadioButton rdbMasculino;
        private RadioButton rdbFeminino;
    }
}