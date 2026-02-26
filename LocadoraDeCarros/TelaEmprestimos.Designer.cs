namespace LocadoraDeCarros
{
    partial class TelaEmprestimos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEmprestimos));
            pictureBox1 = new PictureBox();
            lblClienteEmprestimos = new Label();
            lblVeiculosEmprestimos = new Label();
            txtIdClienteEmprestimos = new TextBox();
            txtIdVeiculosEmprestimos = new TextBox();
            btnSalvarEmprestimos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(215, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 109);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblClienteEmprestimos
            // 
            lblClienteEmprestimos.AutoSize = true;
            lblClienteEmprestimos.Location = new Point(361, 178);
            lblClienteEmprestimos.Name = "lblClienteEmprestimos";
            lblClienteEmprestimos.Size = new Size(52, 15);
            lblClienteEmprestimos.TabIndex = 14;
            lblClienteEmprestimos.Text = "CLIENTE";
            // 
            // lblVeiculosEmprestimos
            // 
            lblVeiculosEmprestimos.AutoSize = true;
            lblVeiculosEmprestimos.Location = new Point(353, 261);
            lblVeiculosEmprestimos.Name = "lblVeiculosEmprestimos";
            lblVeiculosEmprestimos.Size = new Size(60, 15);
            lblVeiculosEmprestimos.TabIndex = 15;
            lblVeiculosEmprestimos.Text = "VEÍCULOS";
            // 
            // txtIdClienteEmprestimos
            // 
            txtIdClienteEmprestimos.Location = new Point(333, 212);
            txtIdClienteEmprestimos.Name = "txtIdClienteEmprestimos";
            txtIdClienteEmprestimos.PlaceholderText = "Id Cliente";
            txtIdClienteEmprestimos.Size = new Size(100, 23);
            txtIdClienteEmprestimos.TabIndex = 20;
            // 
            // txtIdVeiculosEmprestimos
            // 
            txtIdVeiculosEmprestimos.Location = new Point(323, 288);
            txtIdVeiculosEmprestimos.Name = "txtIdVeiculosEmprestimos";
            txtIdVeiculosEmprestimos.PlaceholderText = "Id Veículos";
            txtIdVeiculosEmprestimos.Size = new Size(100, 23);
            txtIdVeiculosEmprestimos.TabIndex = 21;
            // 
            // btnSalvarEmprestimos
            // 
            btnSalvarEmprestimos.BackColor = Color.Black;
            btnSalvarEmprestimos.FlatStyle = FlatStyle.Popup;
            btnSalvarEmprestimos.ForeColor = Color.Cornsilk;
            btnSalvarEmprestimos.Location = new Point(680, 397);
            btnSalvarEmprestimos.Name = "btnSalvarEmprestimos";
            btnSalvarEmprestimos.Size = new Size(93, 36);
            btnSalvarEmprestimos.TabIndex = 26;
            btnSalvarEmprestimos.Text = "SALVAR";
            btnSalvarEmprestimos.UseVisualStyleBackColor = false;
            btnSalvarEmprestimos.Click += btnSalvarEmprestimos_Click;
            // 
            // TelaEmprestimos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvarEmprestimos);
            Controls.Add(txtIdVeiculosEmprestimos);
            Controls.Add(txtIdClienteEmprestimos);
            Controls.Add(lblVeiculosEmprestimos);
            Controls.Add(lblClienteEmprestimos);
            Controls.Add(pictureBox1);
            Name = "TelaEmprestimos";
            Text = "TelaEmprestimos";
            WindowState = FormWindowState.Maximized;
            Load += TelaEmprestimos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblClienteEmprestimos;
        private Label lblVeiculosEmprestimos;
        private TextBox txtIdClienteEmprestimos;
        private TextBox txtIdVeiculosEmprestimos;
        private Button btnSalvarEmprestimos;
    }
}