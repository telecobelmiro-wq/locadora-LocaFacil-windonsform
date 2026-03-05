namespace LocadoraDeCarros
{
    partial class TelaEditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarCliente));
            txtNome = new TextBox();
            lblNomEditarCli = new Label();
            lblEmailEditarCLi = new Label();
            txtEmailEditarCli = new TextBox();
            btnSalvarEditarCli = new Button();
            pictureBox1 = new PictureBox();
            lblCpfEdiatrCli = new Label();
            txtCpfEditarCli = new TextBox();
            rbMaculinoEditarCli = new RadioButton();
            rbFemininoEditarCli = new RadioButton();
            lblSexoEditarCli = new Label();
            btnCancelarEditarCli = new Button();
            pnlEditarCliente = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlEditarCliente.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new Point(365, 290);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(390, 23);
            txtNome.TabIndex = 0;
            // 
            // lblNomEditarCli
            // 
            lblNomEditarCli.AutoSize = true;
            lblNomEditarCli.Location = new Point(365, 272);
            lblNomEditarCli.Name = "lblNomEditarCli";
            lblNomEditarCli.Size = new Size(42, 15);
            lblNomEditarCli.TabIndex = 1;
            lblNomEditarCli.Text = "NOME";
            // 
            // lblEmailEditarCLi
            // 
            lblEmailEditarCLi.AutoSize = true;
            lblEmailEditarCLi.Location = new Point(365, 325);
            lblEmailEditarCLi.Name = "lblEmailEditarCLi";
            lblEmailEditarCLi.Size = new Size(41, 15);
            lblEmailEditarCLi.TabIndex = 2;
            lblEmailEditarCLi.Text = "EMAIL";
            // 
            // txtEmailEditarCli
            // 
            txtEmailEditarCli.Location = new Point(365, 343);
            txtEmailEditarCli.Name = "txtEmailEditarCli";
            txtEmailEditarCli.Size = new Size(390, 23);
            txtEmailEditarCli.TabIndex = 3;
            txtEmailEditarCli.TextChanged += txtEmailEditarCli_TextChanged;
            // 
            // btnSalvarEditarCli
            // 
            btnSalvarEditarCli.BackColor = Color.Black;
            btnSalvarEditarCli.FlatStyle = FlatStyle.Popup;
            btnSalvarEditarCli.ForeColor = SystemColors.ControlLight;
            btnSalvarEditarCli.Location = new Point(439, 539);
            btnSalvarEditarCli.Name = "btnSalvarEditarCli";
            btnSalvarEditarCli.Size = new Size(120, 26);
            btnSalvarEditarCli.TabIndex = 8;
            btnSalvarEditarCli.Text = "SALVAR";
            btnSalvarEditarCli.UseVisualStyleBackColor = false;
            btnSalvarEditarCli.Click += btnSalvarEditarCli_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(365, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 109);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblCpfEdiatrCli
            // 
            lblCpfEdiatrCli.AutoSize = true;
            lblCpfEdiatrCli.Enabled = false;
            lblCpfEdiatrCli.Location = new Point(365, 379);
            lblCpfEdiatrCli.Name = "lblCpfEdiatrCli";
            lblCpfEdiatrCli.Size = new Size(28, 15);
            lblCpfEdiatrCli.TabIndex = 4;
            lblCpfEdiatrCli.Text = "CPF";
            // 
            // txtCpfEditarCli
            // 
            txtCpfEditarCli.Enabled = false;
            txtCpfEditarCli.Location = new Point(365, 397);
            txtCpfEditarCli.Name = "txtCpfEditarCli";
            txtCpfEditarCli.Size = new Size(390, 23);
            txtCpfEditarCli.TabIndex = 5;
            // 
            // rbMaculinoEditarCli
            // 
            rbMaculinoEditarCli.AutoSize = true;
            rbMaculinoEditarCli.Enabled = false;
            rbMaculinoEditarCli.Location = new Point(365, 459);
            rbMaculinoEditarCli.Name = "rbMaculinoEditarCli";
            rbMaculinoEditarCli.Size = new Size(93, 19);
            rbMaculinoEditarCli.TabIndex = 14;
            rbMaculinoEditarCli.TabStop = true;
            rbMaculinoEditarCli.Text = "MASCULINO";
            rbMaculinoEditarCli.UseVisualStyleBackColor = true;
            // 
            // rbFemininoEditarCli
            // 
            rbFemininoEditarCli.AutoSize = true;
            rbFemininoEditarCli.Enabled = false;
            rbFemininoEditarCli.Location = new Point(365, 484);
            rbFemininoEditarCli.Name = "rbFemininoEditarCli";
            rbFemininoEditarCli.Size = new Size(81, 19);
            rbFemininoEditarCli.TabIndex = 15;
            rbFemininoEditarCli.TabStop = true;
            rbFemininoEditarCli.Text = "FEMININO";
            rbFemininoEditarCli.UseVisualStyleBackColor = true;
            rbFemininoEditarCli.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // lblSexoEditarCli
            // 
            lblSexoEditarCli.AutoSize = true;
            lblSexoEditarCli.Enabled = false;
            lblSexoEditarCli.Location = new Point(365, 441);
            lblSexoEditarCli.Name = "lblSexoEditarCli";
            lblSexoEditarCli.Size = new Size(35, 15);
            lblSexoEditarCli.TabIndex = 16;
            lblSexoEditarCli.Text = "SEXO";
            // 
            // btnCancelarEditarCli
            // 
            btnCancelarEditarCli.BackColor = Color.Black;
            btnCancelarEditarCli.FlatStyle = FlatStyle.Popup;
            btnCancelarEditarCli.ForeColor = SystemColors.ControlLight;
            btnCancelarEditarCli.Location = new Point(574, 539);
            btnCancelarEditarCli.Name = "btnCancelarEditarCli";
            btnCancelarEditarCli.Size = new Size(120, 26);
            btnCancelarEditarCli.TabIndex = 17;
            btnCancelarEditarCli.Text = "CANCELAR";
            btnCancelarEditarCli.UseVisualStyleBackColor = false;
            btnCancelarEditarCli.Click += btnCancelarEditarCli_Click;
            // 
            // pnlEditarCliente
            // 
            pnlEditarCliente.Anchor = AnchorStyles.None;
            pnlEditarCliente.Controls.Add(btnCancelarEditarCli);
            pnlEditarCliente.Controls.Add(pictureBox1);
            pnlEditarCliente.Controls.Add(lblSexoEditarCli);
            pnlEditarCliente.Controls.Add(txtCpfEditarCli);
            pnlEditarCliente.Controls.Add(rbFemininoEditarCli);
            pnlEditarCliente.Controls.Add(lblCpfEdiatrCli);
            pnlEditarCliente.Controls.Add(btnSalvarEditarCli);
            pnlEditarCliente.Controls.Add(txtEmailEditarCli);
            pnlEditarCliente.Controls.Add(rbMaculinoEditarCli);
            pnlEditarCliente.Controls.Add(lblEmailEditarCLi);
            pnlEditarCliente.Controls.Add(lblNomEditarCli);
            pnlEditarCliente.Controls.Add(txtNome);
            pnlEditarCliente.Location = new Point(25, 49);
            pnlEditarCliente.Name = "pnlEditarCliente";
            pnlEditarCliente.Size = new Size(1100, 700);
            pnlEditarCliente.TabIndex = 18;
            // 
            // TelaEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1184, 761);
            Controls.Add(pnlEditarCliente);
            Name = "TelaEditarCliente";
            Text = "TelaEditarCliente";
            WindowState = FormWindowState.Maximized;
            Load += TelaEditarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlEditarCliente.ResumeLayout(false);
            pnlEditarCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private Label lblNomEditarCli;
        private Label lblEmailEditarCLi;
        private TextBox txtEmailEditarCli;
        private Button btnSalvarEditarCli;
        private PictureBox pictureBox1;
        private Label lblCpfEdiatrCli;
        private TextBox txtCpfEditarCli;
        private RadioButton rbMaculinoEditarCli;
        private RadioButton rbFemininoEditarCli;
        private Label lblSexoEditarCli;
        private Button btnCancelarEditarCli;
        private Panel pnlEditarCliente;
    }
}