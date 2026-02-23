namespace LocadoraDeCarros
{
    partial class AdicionarCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarCarro));
            pictureBox1 = new PictureBox();
            lblModelo = new Label();
            lblMarca = new Label();
            lblCor = new Label();
            lblPreco = new Label();
            lblAno = new Label();
            txtModelo = new TextBox();
            txtAno = new TextBox();
            txtMarca = new TextBox();
            txtPreco = new TextBox();
            txtCor = new TextBox();
            btnAdicionarCarro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 115);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 12F);
            lblModelo.Location = new Point(69, 151);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(74, 21);
            lblModelo.TabIndex = 13;
            lblModelo.Text = "MODELO";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 12F);
            lblMarca.Location = new Point(210, 151);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(64, 21);
            lblMarca.TabIndex = 14;
            lblMarca.Text = "MARCA";
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Font = new Font("Segoe UI", 12F);
            lblCor.Location = new Point(353, 151);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(42, 21);
            lblCor.TabIndex = 15;
            lblCor.Text = "COR";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 12F);
            lblPreco.Location = new Point(138, 215);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(59, 21);
            lblPreco.TabIndex = 16;
            lblPreco.Text = "PREÇO";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI", 12F);
            lblAno.Location = new Point(286, 215);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(44, 21);
            lblAno.TabIndex = 17;
            lblAno.Text = "ANO";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(54, 175);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 18;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(256, 239);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 19;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(190, 175);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 20;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(120, 239);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 21;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(322, 175);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(100, 23);
            txtCor.TabIndex = 22;
            // 
            // btnAdicionarCarro
            // 
            btnAdicionarCarro.BackColor = Color.Transparent;
            btnAdicionarCarro.Location = new Point(172, 296);
            btnAdicionarCarro.Name = "btnAdicionarCarro";
            btnAdicionarCarro.Size = new Size(130, 38);
            btnAdicionarCarro.TabIndex = 23;
            btnAdicionarCarro.Text = "Adicionar Carro";
            btnAdicionarCarro.UseVisualStyleBackColor = false;
            btnAdicionarCarro.Click += btnAdicionarCarro_Click;
            // 
            // AdicionarCarro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(484, 361);
            Controls.Add(btnAdicionarCarro);
            Controls.Add(txtCor);
            Controls.Add(txtPreco);
            Controls.Add(txtMarca);
            Controls.Add(txtAno);
            Controls.Add(txtModelo);
            Controls.Add(lblAno);
            Controls.Add(lblPreco);
            Controls.Add(lblCor);
            Controls.Add(lblMarca);
            Controls.Add(lblModelo);
            Controls.Add(pictureBox1);
            Name = "AdicionarCarro";
            Text = "AdicionarCarro";
            WindowState = FormWindowState.Maximized;
            Load += AdicionarCarro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblModelo;
        private Label lblMarca;
        private Label lblCor;
        private Label lblPreco;
        private Label lblAno;
        private TextBox txtModelo;
        private TextBox txtAno;
        private TextBox txtMarca;
        private TextBox txtPreco;
        private TextBox txtCor;
        private Button btnAdicionarCarro;
    }
}