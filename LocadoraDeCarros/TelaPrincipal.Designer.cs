namespace LocadoraDeCarros
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            pictureBox1 = new PictureBox();
            btnClientes = new Button();
            btnCarros = new Button();
            btnEmprestimos = new Button();
            dgvTabela = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-64, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 109);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.InactiveCaptionText;
            btnClientes.FlatStyle = FlatStyle.Popup;
            btnClientes.ForeColor = SystemColors.ControlLightLight;
            btnClientes.Location = new Point(40, 177);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(120, 45);
            btnClientes.TabIndex = 13;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnCarros
            // 
            btnCarros.BackColor = SystemColors.InactiveCaptionText;
            btnCarros.FlatStyle = FlatStyle.Popup;
            btnCarros.ForeColor = SystemColors.ControlLightLight;
            btnCarros.Location = new Point(40, 269);
            btnCarros.Name = "btnCarros";
            btnCarros.Size = new Size(120, 45);
            btnCarros.TabIndex = 14;
            btnCarros.Text = "CARROS";
            btnCarros.UseVisualStyleBackColor = false;
            // 
            // btnEmprestimos
            // 
            btnEmprestimos.BackColor = SystemColors.InactiveCaptionText;
            btnEmprestimos.FlatStyle = FlatStyle.Popup;
            btnEmprestimos.ForeColor = SystemColors.ControlLightLight;
            btnEmprestimos.Location = new Point(40, 356);
            btnEmprestimos.Name = "btnEmprestimos";
            btnEmprestimos.Size = new Size(120, 45);
            btnEmprestimos.TabIndex = 15;
            btnEmprestimos.Text = "EMPRESTIMOS";
            btnEmprestimos.UseVisualStyleBackColor = false;
            // 
            // dgvTabela
            // 
            dgvTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabela.Location = new Point(318, 36);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.Size = new Size(751, 436);
            dgvTabela.TabIndex = 16;
            dgvTabela.CellContentClick += dgvTabela_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(703, 515);
            button1.Name = "button1";
            button1.Size = new Size(120, 45);
            button1.TabIndex = 17;
            button1.Text = "NOVO";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(838, 515);
            button2.Name = "button2";
            button2.Size = new Size(120, 45);
            button2.TabIndex = 18;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(974, 515);
            button3.Name = "button3";
            button3.Size = new Size(120, 45);
            button3.TabIndex = 19;
            button3.Text = "EXCLUIR";
            button3.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1106, 577);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvTabela);
            Controls.Add(btnEmprestimos);
            Controls.Add(btnCarros);
            Controls.Add(btnClientes);
            Controls.Add(pictureBox1);
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            Load += TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnClientes;
        private Button btnCarros;
        private Button btnEmprestimos;
        private DataGridView dgvTabela;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}