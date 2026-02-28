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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(397, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 109);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblClienteEmprestimos
            // 
            lblClienteEmprestimos.AutoSize = true;
            lblClienteEmprestimos.Location = new Point(560, 335);
            lblClienteEmprestimos.Name = "lblClienteEmprestimos";
            lblClienteEmprestimos.Size = new Size(52, 15);
            lblClienteEmprestimos.TabIndex = 14;
            lblClienteEmprestimos.Text = "CLIENTE";
            // 
            // lblVeiculosEmprestimos
            // 
            lblVeiculosEmprestimos.AutoSize = true;
            lblVeiculosEmprestimos.Location = new Point(560, 395);
            lblVeiculosEmprestimos.Name = "lblVeiculosEmprestimos";
            lblVeiculosEmprestimos.Size = new Size(60, 15);
            lblVeiculosEmprestimos.TabIndex = 15;
            lblVeiculosEmprestimos.Text = "VEÍCULOS";
            // 
            // txtIdClienteEmprestimos
            // 
            txtIdClienteEmprestimos.Location = new Point(540, 353);
            txtIdClienteEmprestimos.Name = "txtIdClienteEmprestimos";
            txtIdClienteEmprestimos.PlaceholderText = "Id Cliente";
            txtIdClienteEmprestimos.Size = new Size(100, 23);
            txtIdClienteEmprestimos.TabIndex = 20;
            // 
            // txtIdVeiculosEmprestimos
            // 
            txtIdVeiculosEmprestimos.Enabled = false;
            txtIdVeiculosEmprestimos.Location = new Point(540, 413);
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
            btnSalvarEmprestimos.Location = new Point(540, 471);
            btnSalvarEmprestimos.Name = "btnSalvarEmprestimos";
            btnSalvarEmprestimos.Size = new Size(100, 36);
            btnSalvarEmprestimos.TabIndex = 26;
            btnSalvarEmprestimos.Text = "SALVAR";
            btnSalvarEmprestimos.UseVisualStyleBackColor = false;
            btnSalvarEmprestimos.Click += btnSalvarEmprestimos_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalvarEmprestimos);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblClienteEmprestimos);
            panel1.Controls.Add(txtIdClienteEmprestimos);
            panel1.Controls.Add(txtIdVeiculosEmprestimos);
            panel1.Controls.Add(lblVeiculosEmprestimos);
            panel1.Location = new Point(33, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 700);
            panel1.TabIndex = 27;
            // 
            // TelaEmprestimos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1184, 761);
            Controls.Add(panel1);
            Name = "TelaEmprestimos";
            Text = "TelaEmprestimos";
            WindowState = FormWindowState.Maximized;
            Load += TelaEmprestimos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblClienteEmprestimos;
        private Label lblVeiculosEmprestimos;
        private TextBox txtIdClienteEmprestimos;
        private TextBox txtIdVeiculosEmprestimos;
        private Button btnSalvarEmprestimos;
        private Panel panel1;
    }
}