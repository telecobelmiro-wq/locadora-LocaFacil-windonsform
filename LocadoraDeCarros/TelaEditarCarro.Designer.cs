namespace LocadoraDeCarros
{
    partial class TelaEditarCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarCarro));
            pictureBox1 = new PictureBox();
            lblModeloEditarCar = new Label();
            lblMarcaEditarCar = new Label();
            lblAnoEditarCar = new Label();
            lblPrecoEditarCar = new Label();
            lblCorEditarCar = new Label();
            btnSalvarEditarCar = new Button();
            btnCancelarEditarCar = new Button();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtAno = new TextBox();
            txtPreco = new TextBox();
            txtCor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(245, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 109);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblModeloEditarCar
            // 
            lblModeloEditarCar.AutoSize = true;
            lblModeloEditarCar.Location = new Point(197, 216);
            lblModeloEditarCar.Name = "lblModeloEditarCar";
            lblModeloEditarCar.Size = new Size(56, 15);
            lblModeloEditarCar.TabIndex = 15;
            lblModeloEditarCar.Text = "MODELO";
            lblModeloEditarCar.Click += label1_Click;
            // 
            // lblMarcaEditarCar
            // 
            lblMarcaEditarCar.AutoSize = true;
            lblMarcaEditarCar.Location = new Point(197, 288);
            lblMarcaEditarCar.Name = "lblMarcaEditarCar";
            lblMarcaEditarCar.Size = new Size(49, 15);
            lblMarcaEditarCar.TabIndex = 16;
            lblMarcaEditarCar.Text = "MARCA";
            // 
            // lblAnoEditarCar
            // 
            lblAnoEditarCar.AutoSize = true;
            lblAnoEditarCar.Location = new Point(386, 216);
            lblAnoEditarCar.Name = "lblAnoEditarCar";
            lblAnoEditarCar.Size = new Size(33, 15);
            lblAnoEditarCar.TabIndex = 17;
            lblAnoEditarCar.Text = "ANO";
            // 
            // lblPrecoEditarCar
            // 
            lblPrecoEditarCar.AutoSize = true;
            lblPrecoEditarCar.Location = new Point(386, 288);
            lblPrecoEditarCar.Name = "lblPrecoEditarCar";
            lblPrecoEditarCar.Size = new Size(44, 15);
            lblPrecoEditarCar.TabIndex = 18;
            lblPrecoEditarCar.Text = "PREÇO";
            // 
            // lblCorEditarCar
            // 
            lblCorEditarCar.AutoSize = true;
            lblCorEditarCar.Location = new Point(547, 216);
            lblCorEditarCar.Name = "lblCorEditarCar";
            lblCorEditarCar.Size = new Size(31, 15);
            lblCorEditarCar.TabIndex = 19;
            lblCorEditarCar.Text = "COR";
            lblCorEditarCar.Click += label5_Click;
            // 
            // btnSalvarEditarCar
            // 
            btnSalvarEditarCar.BackColor = Color.Black;
            btnSalvarEditarCar.FlatStyle = FlatStyle.Popup;
            btnSalvarEditarCar.ForeColor = SystemColors.ControlLight;
            btnSalvarEditarCar.Location = new Point(668, 407);
            btnSalvarEditarCar.Name = "btnSalvarEditarCar";
            btnSalvarEditarCar.Size = new Size(120, 26);
            btnSalvarEditarCar.TabIndex = 20;
            btnSalvarEditarCar.Text = "SALVAR";
            btnSalvarEditarCar.UseVisualStyleBackColor = false;
            btnSalvarEditarCar.Click += btnSalvarEditarCar_Click;
            // 
            // btnCancelarEditarCar
            // 
            btnCancelarEditarCar.BackColor = Color.Black;
            btnCancelarEditarCar.FlatStyle = FlatStyle.Popup;
            btnCancelarEditarCar.ForeColor = SystemColors.ControlLight;
            btnCancelarEditarCar.Location = new Point(527, 407);
            btnCancelarEditarCar.Name = "btnCancelarEditarCar";
            btnCancelarEditarCar.Size = new Size(120, 26);
            btnCancelarEditarCar.TabIndex = 21;
            btnCancelarEditarCar.Text = "CANCELAR";
            btnCancelarEditarCar.UseVisualStyleBackColor = false;
            btnCancelarEditarCar.Click += btnCancelarEditarCar_Click;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(197, 234);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 22;
            txtModelo.TextChanged += txtModelo_TextChanged;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(197, 306);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 23;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(386, 234);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 24;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(386, 306);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 25;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(547, 234);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(100, 23);
            txtCor.TabIndex = 26;
            // 
            // TelaEditarCarro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCor);
            Controls.Add(txtPreco);
            Controls.Add(txtAno);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(btnCancelarEditarCar);
            Controls.Add(btnSalvarEditarCar);
            Controls.Add(lblCorEditarCar);
            Controls.Add(lblPrecoEditarCar);
            Controls.Add(lblAnoEditarCar);
            Controls.Add(lblMarcaEditarCar);
            Controls.Add(lblModeloEditarCar);
            Controls.Add(pictureBox1);
            Name = "TelaEditarCarro";
            Text = "TelaEditarCarro";
            Load += TelaEditarCarro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblModeloEditarCar;
        private Label lblMarcaEditarCar;
        private Label lblAnoEditarCar;
        private Label lblPrecoEditarCar;
        private Label lblCorEditarCar;
        private Button btnSalvarEditarCar;
        private Button btnCancelarEditarCar;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtAno;
        private TextBox txtPreco;
        private TextBox txtCor;
    }
}