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
            lblSexoEdiatrCli = new Label();
            txtSexoEditarCli = new TextBox();
            lblCpfEdiatrCli = new Label();
            txtCpfEditarCli = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
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
            lblEmailEditarCLi.Location = new Point(196, 255);
            lblEmailEditarCLi.Name = "lblEmailEditarCLi";
            lblEmailEditarCLi.Size = new Size(41, 15);
            lblEmailEditarCLi.TabIndex = 2;
            lblEmailEditarCLi.Text = "EMAIL";
            // 
            // txtEmailEditarCli
            // 
            txtEmailEditarCli.Location = new Point(196, 273);
            txtEmailEditarCli.Name = "txtEmailEditarCli";
            txtEmailEditarCli.Size = new Size(100, 23);
            txtEmailEditarCli.TabIndex = 3;
            // 
            // btnSalvarEditarCli
            // 
            btnSalvarEditarCli.BackColor = SystemColors.InactiveCaptionText;
            btnSalvarEditarCli.FlatStyle = FlatStyle.Popup;
            btnSalvarEditarCli.ForeColor = SystemColors.ControlLight;
            btnSalvarEditarCli.Location = new Point(673, 379);
            btnSalvarEditarCli.Name = "btnSalvarEditarCli";
            btnSalvarEditarCli.Size = new Size(98, 49);
            btnSalvarEditarCli.TabIndex = 8;
            btnSalvarEditarCli.Text = "SALVAR";
            btnSalvarEditarCli.UseVisualStyleBackColor = false;
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
            // lblSexoEdiatrCli
            // 
            lblSexoEdiatrCli.AutoSize = true;
            lblSexoEdiatrCli.Location = new Point(503, 186);
            lblSexoEdiatrCli.Name = "lblSexoEdiatrCli";
            lblSexoEdiatrCli.Size = new Size(35, 15);
            lblSexoEdiatrCli.TabIndex = 6;
            lblSexoEdiatrCli.Text = "SEXO";
            // 
            // txtSexoEditarCli
            // 
            txtSexoEditarCli.Location = new Point(503, 204);
            txtSexoEditarCli.Name = "txtSexoEditarCli";
            txtSexoEditarCli.Size = new Size(100, 23);
            txtSexoEditarCli.TabIndex = 7;
            // 
            // lblCpfEdiatrCli
            // 
            lblCpfEdiatrCli.AutoSize = true;
            lblCpfEdiatrCli.Location = new Point(503, 255);
            lblCpfEdiatrCli.Name = "lblCpfEdiatrCli";
            lblCpfEdiatrCli.Size = new Size(28, 15);
            lblCpfEdiatrCli.TabIndex = 4;
            lblCpfEdiatrCli.Text = "CPF";
            // 
            // txtCpfEditarCli
            // 
            txtCpfEditarCli.Location = new Point(503, 273);
            txtCpfEditarCli.Name = "txtCpfEditarCli";
            txtCpfEditarCli.Size = new Size(100, 23);
            txtCpfEditarCli.TabIndex = 5;
            // 
            // TelaEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalvarEditarCli);
            Controls.Add(txtSexoEditarCli);
            Controls.Add(lblSexoEdiatrCli);
            Controls.Add(txtCpfEditarCli);
            Controls.Add(lblCpfEdiatrCli);
            Controls.Add(txtEmailEditarCli);
            Controls.Add(lblEmailEditarCLi);
            Controls.Add(lblNomEditarCli);
            Controls.Add(txtNome);
            Name = "TelaEditarCliente";
            Text = "TelaEditarCliente";
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
        private Label lblSexoEdiatrCli;
        private TextBox txtSexoEditarCli;
        private Label lblCpfEdiatrCli;
        private TextBox txtCpfEditarCli;
    }
}