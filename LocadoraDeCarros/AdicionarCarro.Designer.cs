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
            pnlAdicionarCarro = new Panel();
            label1 = new Label();
            cbCategoriaAddCar = new ComboBox();
            btnCancelar = new Button();
            btnAdicionarCarro = new Button();
            txtCor = new TextBox();
            txtPreco = new TextBox();
            txtMarca = new TextBox();
            txtAno = new TextBox();
            txtModelo = new TextBox();
            lblAno = new Label();
            lblPreco = new Label();
            lblCor = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            pictureBox1 = new PictureBox();
            pnlAdicionarCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlAdicionarCarro
            // 
            pnlAdicionarCarro.Anchor = AnchorStyles.None;
            pnlAdicionarCarro.Controls.Add(label1);
            pnlAdicionarCarro.Controls.Add(cbCategoriaAddCar);
            pnlAdicionarCarro.Controls.Add(btnCancelar);
            pnlAdicionarCarro.Controls.Add(btnAdicionarCarro);
            pnlAdicionarCarro.Controls.Add(txtCor);
            pnlAdicionarCarro.Controls.Add(txtPreco);
            pnlAdicionarCarro.Controls.Add(txtMarca);
            pnlAdicionarCarro.Controls.Add(txtAno);
            pnlAdicionarCarro.Controls.Add(txtModelo);
            pnlAdicionarCarro.Controls.Add(lblAno);
            pnlAdicionarCarro.Controls.Add(lblPreco);
            pnlAdicionarCarro.Controls.Add(lblCor);
            pnlAdicionarCarro.Controls.Add(lblMarca);
            pnlAdicionarCarro.Controls.Add(lblModelo);
            pnlAdicionarCarro.Controls.Add(pictureBox1);
            pnlAdicionarCarro.Location = new Point(36, 36);
            pnlAdicionarCarro.Name = "pnlAdicionarCarro";
            pnlAdicionarCarro.Size = new Size(1100, 700);
            pnlAdicionarCarro.TabIndex = 25;
            pnlAdicionarCarro.Paint += pnlAdicionarCarro_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(363, 502);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 39;
            label1.Text = "Categoria";
            label1.Click += label1_Click;
            // 
            // cbCategoriaAddCar
            // 
            cbCategoriaAddCar.FormattingEnabled = true;
            cbCategoriaAddCar.Items.AddRange(new object[] { "Ouro", "Prata", "Bronze" });
            cbCategoriaAddCar.Location = new Point(361, 526);
            cbCategoriaAddCar.Name = "cbCategoriaAddCar";
            cbCategoriaAddCar.Size = new Size(378, 23);
            cbCategoriaAddCar.TabIndex = 38;
            cbCategoriaAddCar.SelectedIndexChanged += cbCategoriaAddCar_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Black;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(584, 578);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 26);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdicionarCarro
            // 
            btnAdicionarCarro.BackColor = Color.Black;
            btnAdicionarCarro.FlatStyle = FlatStyle.Popup;
            btnAdicionarCarro.ForeColor = SystemColors.ControlLight;
            btnAdicionarCarro.Location = new Point(439, 578);
            btnAdicionarCarro.Name = "btnAdicionarCarro";
            btnAdicionarCarro.Size = new Size(120, 26);
            btnAdicionarCarro.TabIndex = 36;
            btnAdicionarCarro.Text = "ADICIONAR CARRO";
            btnAdicionarCarro.UseVisualStyleBackColor = false;
            btnAdicionarCarro.Click += btnAdicionarCarro_Click;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(363, 403);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(376, 23);
            txtCor.TabIndex = 35;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(363, 468);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(376, 23);
            txtPreco.TabIndex = 34;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(363, 281);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(376, 23);
            txtMarca.TabIndex = 33;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(363, 346);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(376, 23);
            txtAno.TabIndex = 32;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(363, 221);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(376, 23);
            txtModelo.TabIndex = 31;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI", 12F);
            lblAno.Location = new Point(363, 322);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(38, 21);
            lblAno.TabIndex = 30;
            lblAno.Text = "Ano";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 12F);
            lblPreco.Location = new Point(363, 444);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(49, 21);
            lblPreco.TabIndex = 29;
            lblPreco.Text = "Preço";
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Font = new Font("Segoe UI", 12F);
            lblCor.Location = new Point(363, 379);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(35, 21);
            lblCor.TabIndex = 28;
            lblCor.Text = "Cor";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 12F);
            lblMarca.Location = new Point(363, 257);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 21);
            lblMarca.TabIndex = 27;
            lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 12F);
            lblModelo.Location = new Point(363, 197);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(63, 21);
            lblModelo.TabIndex = 26;
            lblModelo.Text = "Modelo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 115);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // AdicionarCarro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1184, 761);
            Controls.Add(pnlAdicionarCarro);
            Name = "AdicionarCarro";
            Text = "AdicionarCarro";
            WindowState = FormWindowState.Maximized;
            Load += AdicionarCarro_Load;
            pnlAdicionarCarro.ResumeLayout(false);
            pnlAdicionarCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdicionarCarro;
        private Button btnCancelar;
        private Button btnAdicionarCarro;
        private TextBox txtCor;
        private TextBox txtPreco;
        private TextBox txtMarca;
        private TextBox txtAno;
        private TextBox txtModelo;
        private Label lblAno;
        private Label lblPreco;
        private Label lblCor;
        private Label lblMarca;
        private Label lblModelo;
        private PictureBox pictureBox1;
        private ComboBox cbCategoriaAddCar;
        private Label label1;
    }
}