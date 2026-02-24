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
            lblRetiradaEmprestimos = new Label();
            lblDevolucaoEmprestimos = new Label();
            lblValorTotalEmprestimos = new Label();
            lblStatusEmprestimos = new Label();
            txtIdClienteEmprestimos = new TextBox();
            txtIdVeiculosEmprestimos = new TextBox();
            dtpRetiradaVeiculo = new DateTimePicker();
            dtpDevolucaoVeiculo = new DateTimePicker();
            txtValorTotalEmprestimos = new TextBox();
            btnSalvarEmprestimos = new Button();
            cmbStatusEmprestimos = new ComboBox();
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
            lblClienteEmprestimos.Location = new Point(188, 177);
            lblClienteEmprestimos.Name = "lblClienteEmprestimos";
            lblClienteEmprestimos.Size = new Size(52, 15);
            lblClienteEmprestimos.TabIndex = 14;
            lblClienteEmprestimos.Text = "CLIENTE";
            // 
            // lblVeiculosEmprestimos
            // 
            lblVeiculosEmprestimos.AutoSize = true;
            lblVeiculosEmprestimos.Location = new Point(188, 244);
            lblVeiculosEmprestimos.Name = "lblVeiculosEmprestimos";
            lblVeiculosEmprestimos.Size = new Size(60, 15);
            lblVeiculosEmprestimos.TabIndex = 15;
            lblVeiculosEmprestimos.Text = "VEÍCULOS";
            // 
            // lblRetiradaEmprestimos
            // 
            lblRetiradaEmprestimos.AutoSize = true;
            lblRetiradaEmprestimos.Location = new Point(188, 323);
            lblRetiradaEmprestimos.Name = "lblRetiradaEmprestimos";
            lblRetiradaEmprestimos.Size = new Size(93, 15);
            lblRetiradaEmprestimos.TabIndex = 16;
            lblRetiradaEmprestimos.Text = "DATA RETIRADA";
            // 
            // lblDevolucaoEmprestimos
            // 
            lblDevolucaoEmprestimos.AutoSize = true;
            lblDevolucaoEmprestimos.Location = new Point(509, 323);
            lblDevolucaoEmprestimos.Name = "lblDevolucaoEmprestimos";
            lblDevolucaoEmprestimos.Size = new Size(76, 15);
            lblDevolucaoEmprestimos.TabIndex = 17;
            lblDevolucaoEmprestimos.Text = "DEVOLUÇÃO";
            // 
            // lblValorTotalEmprestimos
            // 
            lblValorTotalEmprestimos.AutoSize = true;
            lblValorTotalEmprestimos.Location = new Point(499, 244);
            lblValorTotalEmprestimos.Name = "lblValorTotalEmprestimos";
            lblValorTotalEmprestimos.Size = new Size(80, 15);
            lblValorTotalEmprestimos.TabIndex = 18;
            lblValorTotalEmprestimos.Text = "VALOR TOTAL";
            // 
            // lblStatusEmprestimos
            // 
            lblStatusEmprestimos.AutoSize = true;
            lblStatusEmprestimos.Location = new Point(509, 177);
            lblStatusEmprestimos.Name = "lblStatusEmprestimos";
            lblStatusEmprestimos.Size = new Size(47, 15);
            lblStatusEmprestimos.TabIndex = 19;
            lblStatusEmprestimos.Text = "STATUS";
            // 
            // txtIdClienteEmprestimos
            // 
            txtIdClienteEmprestimos.Location = new Point(188, 205);
            txtIdClienteEmprestimos.Name = "txtIdClienteEmprestimos";
            txtIdClienteEmprestimos.PlaceholderText = "Id Cliente";
            txtIdClienteEmprestimos.Size = new Size(100, 23);
            txtIdClienteEmprestimos.TabIndex = 20;
            // 
            // txtIdVeiculosEmprestimos
            // 
            txtIdVeiculosEmprestimos.Location = new Point(188, 276);
            txtIdVeiculosEmprestimos.Name = "txtIdVeiculosEmprestimos";
            txtIdVeiculosEmprestimos.PlaceholderText = "Id Veículos";
            txtIdVeiculosEmprestimos.Size = new Size(100, 23);
            txtIdVeiculosEmprestimos.TabIndex = 21;
            // 
            // dtpRetiradaVeiculo
            // 
            dtpRetiradaVeiculo.Location = new Point(188, 344);
            dtpRetiradaVeiculo.Name = "dtpRetiradaVeiculo";
            dtpRetiradaVeiculo.Size = new Size(230, 23);
            dtpRetiradaVeiculo.TabIndex = 22;
            // 
            // dtpDevolucaoVeiculo
            // 
            dtpDevolucaoVeiculo.Location = new Point(499, 344);
            dtpDevolucaoVeiculo.Name = "dtpDevolucaoVeiculo";
            dtpDevolucaoVeiculo.Size = new Size(231, 23);
            dtpDevolucaoVeiculo.TabIndex = 23;
            // 
            // txtValorTotalEmprestimos
            // 
            txtValorTotalEmprestimos.Location = new Point(499, 276);
            txtValorTotalEmprestimos.Name = "txtValorTotalEmprestimos";
            txtValorTotalEmprestimos.PlaceholderText = "R$ 1234,00";
            txtValorTotalEmprestimos.Size = new Size(144, 23);
            txtValorTotalEmprestimos.TabIndex = 24;
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
            // cmbStatusEmprestimos
            // 
            cmbStatusEmprestimos.BackColor = SystemColors.Window;
            cmbStatusEmprestimos.ForeColor = Color.Gray;
            cmbStatusEmprestimos.FormattingEnabled = true;
            cmbStatusEmprestimos.Location = new Point(499, 205);
            cmbStatusEmprestimos.Name = "cmbStatusEmprestimos";
            cmbStatusEmprestimos.Size = new Size(160, 23);
            cmbStatusEmprestimos.TabIndex = 27;
            cmbStatusEmprestimos.Text = "Ativo, Inativo e Finalizado";
            cmbStatusEmprestimos.SelectedIndexChanged += cmbStatusEmprestimos_SelectedIndexChanged;
            // 
            // TelaEmprestimos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbStatusEmprestimos);
            Controls.Add(btnSalvarEmprestimos);
            Controls.Add(txtValorTotalEmprestimos);
            Controls.Add(dtpDevolucaoVeiculo);
            Controls.Add(dtpRetiradaVeiculo);
            Controls.Add(txtIdVeiculosEmprestimos);
            Controls.Add(txtIdClienteEmprestimos);
            Controls.Add(lblStatusEmprestimos);
            Controls.Add(lblValorTotalEmprestimos);
            Controls.Add(lblDevolucaoEmprestimos);
            Controls.Add(lblRetiradaEmprestimos);
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
        private Label lblRetiradaEmprestimos;
        private Label lblDevolucaoEmprestimos;
        private Label lblValorTotalEmprestimos;
        private Label lblStatusEmprestimos;
        private TextBox txtIdClienteEmprestimos;
        private TextBox txtIdVeiculosEmprestimos;
        private DateTimePicker dtpRetiradaVeiculo;
        private DateTimePicker dtpDevolucaoVeiculo;
        private TextBox txtValorTotalEmprestimos;
        private Button btnSalvarEmprestimos;
        private ComboBox cmbStatusEmprestimos;
    }
}