namespace LocadoraDeCarros
{
    partial class TelaLoginCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLoginCliente));
            pnlLoginCliente = new Panel();
            btnEntrar = new Button();
            txtLogin = new TextBox();
            lblLoginCliente = new Label();
            pictureBox1 = new PictureBox();
            pnlLoginCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlLoginCliente
            // 
            pnlLoginCliente.Controls.Add(btnEntrar);
            pnlLoginCliente.Controls.Add(txtLogin);
            pnlLoginCliente.Controls.Add(lblLoginCliente);
            pnlLoginCliente.Controls.Add(pictureBox1);
            pnlLoginCliente.Location = new Point(29, 26);
            pnlLoginCliente.Name = "pnlLoginCliente";
            pnlLoginCliente.Size = new Size(800, 800);
            pnlLoginCliente.TabIndex = 16;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ControlText;
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Segoe UI", 12F);
            btnEntrar.ForeColor = Color.Cornsilk;
            btnEntrar.Location = new Point(342, 471);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(120, 40);
            btnEntrar.TabIndex = 19;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(361, 429);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Insira seu id";
            txtLogin.Size = new Size(81, 23);
            txtLogin.TabIndex = 18;
            // 
            // lblLoginCliente
            // 
            lblLoginCliente.Font = new Font("Segoe UI", 12F);
            lblLoginCliente.Location = new Point(373, 398);
            lblLoginCliente.Name = "lblLoginCliente";
            lblLoginCliente.Size = new Size(57, 22);
            lblLoginCliente.TabIndex = 17;
            lblLoginCliente.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(217, 261);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 115);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // TelaLoginCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(884, 861);
            Controls.Add(pnlLoginCliente);
            Name = "TelaLoginCliente";
            Text = "TelaCliente";
            WindowState = FormWindowState.Maximized;
            Resize += Form1_Resize;
            pnlLoginCliente.ResumeLayout(false);
            pnlLoginCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlLoginCliente;
        private Button btnEntrar;
        private TextBox txtLogin;
        private Label lblLoginCliente;
        private PictureBox pictureBox1;
    }
}