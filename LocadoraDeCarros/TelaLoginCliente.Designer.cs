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
            pictureBox1 = new PictureBox();
            lblLoginCliente = new Label();
            txtNomeCliente = new TextBox();
            btnEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(220, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 115);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lblLoginCliente
            // 
            lblLoginCliente.Font = new Font("Segoe UI", 15F);
            lblLoginCliente.Location = new Point(343, 192);
            lblLoginCliente.Name = "lblLoginCliente";
            lblLoginCliente.Size = new Size(74, 33);
            lblLoginCliente.TabIndex = 13;
            lblLoginCliente.Text = "LOGIN";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(312, 235);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = "Insira seu nome aqui ";
            txtNomeCliente.Size = new Size(124, 23);
            txtNomeCliente.TabIndex = 14;
            txtNomeCliente.TextChanged += txtNomeCliente_TextChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ControlText;
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Segoe UI", 12F);
            btnEntrar.ForeColor = Color.Cornsilk;
            btnEntrar.Location = new Point(319, 278);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(111, 45);
            btnEntrar.TabIndex = 15;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += button1_Click;
            // 
            // TelaLoginCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrar);
            Controls.Add(txtNomeCliente);
            Controls.Add(lblLoginCliente);
            Controls.Add(pictureBox1);
            Name = "TelaLoginCliente";
            Text = "TelaCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLoginCliente;
        private TextBox txtNomeCliente;
        private Button btnEntrar;
    }
}