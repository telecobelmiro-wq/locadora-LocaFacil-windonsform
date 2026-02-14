namespace LocadoraDeCarros
{
    partial class TelaLoginAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLoginAdministrador));
            btnEntrar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtLogin = new TextBox();
            lblLogin = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Black;
            btnEntrar.FlatAppearance.BorderColor = Color.Black;
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.ForeColor = Color.Cornsilk;
            btnEntrar.Location = new Point(185, 298);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(114, 40);
            btnEntrar.TabIndex = 18;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 15F);
            txtSenha.Location = new Point(170, 238);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(144, 27);
            txtSenha.TabIndex = 17;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F);
            lblSenha.Location = new Point(207, 214);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 21);
            lblSenha.TabIndex = 16;
            lblSenha.Text = "SENHA";
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Segoe UI", 15F);
            txtLogin.Location = new Point(170, 175);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(144, 27);
            txtLogin.TabIndex = 15;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 12F);
            lblLogin.Location = new Point(207, 151);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(56, 21);
            lblLogin.TabIndex = 14;
            lblLogin.Text = "LOGIN";
            lblLogin.Click += lblLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 115);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // TelaLoginAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(484, 361);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "TelaLoginAdministrador";
            Text = "TelaAdministrador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtLogin;
        private Label lblLogin;
        private PictureBox pictureBox1;
    }
}