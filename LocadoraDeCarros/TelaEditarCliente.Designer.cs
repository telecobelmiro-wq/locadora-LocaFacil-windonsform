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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new Point(196, 204);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // lblNomEditarCli
            // 
            lblNomEditarCli.AutoSize = true;
            lblNomEditarCli.Location = new Point(196, 186);
            lblNomEditarCli.Name = "lblNomEditarCli";
            lblNomEditarCli.Size = new Size(42, 15);
            lblNomEditarCli.TabIndex = 1;
            lblNomEditarCli.Text = "NOME";
            // 
            // lblEmailEditarCLi
            // 
            lblEmailEditarCLi.AutoSize = true;
            lblEmailEditarCLi.Location = new Point(196, 273);
            lblEmailEditarCLi.Name = "lblEmailEditarCLi";
            lblEmailEditarCLi.Size = new Size(41, 15);
            lblEmailEditarCLi.TabIndex = 2;
            lblEmailEditarCLi.Text = "EMAIL";
            // 
            // txtEmailEditarCli
            // 
            txtEmailEditarCli.Location = new Point(196, 291);
            txtEmailEditarCli.Name = "txtEmailEditarCli";
            txtEmailEditarCli.Size = new Size(100, 23);
            txtEmailEditarCli.TabIndex = 3;
            txtEmailEditarCli.TextChanged += txtEmailEditarCli_TextChanged;
            // 
            // btnSalvarEditarCli
            // 
            btnSalvarEditarCli.BackColor = Color.Black;
            btnSalvarEditarCli.FlatStyle = FlatStyle.Popup;
            btnSalvarEditarCli.ForeColor = SystemColors.ControlLight;
            btnSalvarEditarCli.Location = new Point(673, 379);
            btnSalvarEditarCli.Name = "btnSalvarEditarCli";
            btnSalvarEditarCli.Size = new Size(89, 49);
            btnSalvarEditarCli.TabIndex = 8;
            btnSalvarEditarCli.Text = "SALVAR";
            btnSalvarEditarCli.UseVisualStyleBackColor = false;
            btnSalvarEditarCli.Click += btnSalvarEditarCli_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(230, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 109);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblCpfEdiatrCli
            // 
            lblCpfEdiatrCli.AutoSize = true;
            lblCpfEdiatrCli.Enabled = false;
            lblCpfEdiatrCli.Location = new Point(503, 273);
            lblCpfEdiatrCli.Name = "lblCpfEdiatrCli";
            lblCpfEdiatrCli.Size = new Size(28, 15);
            lblCpfEdiatrCli.TabIndex = 4;
            lblCpfEdiatrCli.Text = "CPF";
            // 
            // txtCpfEditarCli
            // 
            txtCpfEditarCli.Enabled = false;
            txtCpfEditarCli.Location = new Point(503, 291);
            txtCpfEditarCli.Name = "txtCpfEditarCli";
            txtCpfEditarCli.Size = new Size(100, 23);
            txtCpfEditarCli.TabIndex = 5;
            // 
            // rbMaculinoEditarCli
            // 
            rbMaculinoEditarCli.AutoSize = true;
            rbMaculinoEditarCli.Enabled = false;
            rbMaculinoEditarCli.Location = new Point(503, 204);
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
            rbFemininoEditarCli.Location = new Point(503, 229);
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
            lblSexoEditarCli.Location = new Point(503, 186);
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
            btnCancelarEditarCli.Location = new Point(559, 379);
            btnCancelarEditarCli.Name = "btnCancelarEditarCli";
            btnCancelarEditarCli.Size = new Size(89, 49);
            btnCancelarEditarCli.TabIndex = 17;
            btnCancelarEditarCli.Text = "CANCELAR";
            btnCancelarEditarCli.UseVisualStyleBackColor = false;
            btnCancelarEditarCli.Click += btnCancelarEditarCli_Click;
            // 
            // TelaEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarEditarCli);
            Controls.Add(lblSexoEditarCli);
            Controls.Add(rbFemininoEditarCli);
            Controls.Add(rbMaculinoEditarCli);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalvarEditarCli);
            Controls.Add(txtCpfEditarCli);
            Controls.Add(lblCpfEdiatrCli);
            Controls.Add(txtEmailEditarCli);
            Controls.Add(lblEmailEditarCLi);
            Controls.Add(lblNomEditarCli);
            Controls.Add(txtNome);
            Name = "TelaEditarCliente";
            Text = "TelaEditarCliente";
            WindowState = FormWindowState.Maximized;
            Load += TelaEditarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}