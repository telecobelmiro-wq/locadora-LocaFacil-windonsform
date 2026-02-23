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
            pnlTelaPrincipal = new Panel();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            dgvTabela = new DataGridView();
            btnEmprestimos = new Button();
            btnCarros = new Button();
            btnClientes = new Button();
            pictureBox1 = new PictureBox();
            pnlTelaPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTelaPrincipal
            // 
            pnlTelaPrincipal.Controls.Add(btnExcluir);
            pnlTelaPrincipal.Controls.Add(btnEditar);
            pnlTelaPrincipal.Controls.Add(btnNovo);
            pnlTelaPrincipal.Controls.Add(dgvTabela);
            pnlTelaPrincipal.Controls.Add(btnEmprestimos);
            pnlTelaPrincipal.Controls.Add(btnCarros);
            pnlTelaPrincipal.Controls.Add(btnClientes);
            pnlTelaPrincipal.Controls.Add(pictureBox1);
            pnlTelaPrincipal.Location = new Point(46, 49);
            pnlTelaPrincipal.Name = "pnlTelaPrincipal";
            pnlTelaPrincipal.Size = new Size(1100, 700);
            pnlTelaPrincipal.TabIndex = 0;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(790, 560);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 45);
            btnExcluir.TabIndex = 27;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(654, 560);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 45);
            btnEditar.TabIndex = 26;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(519, 560);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(120, 45);
            btnNovo.TabIndex = 25;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // dgvTabela
            // 
            dgvTabela.AllowUserToAddRows = false;
            dgvTabela.AllowUserToDeleteRows = false;
            dgvTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabela.Location = new Point(235, 180);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTabela.Size = new Size(676, 346);
            dgvTabela.TabIndex = 20;
            // 
            // btnEmprestimos
            // 
            btnEmprestimos.BackColor = Color.Gray;
            btnEmprestimos.FlatStyle = FlatStyle.System;
            btnEmprestimos.ForeColor = SystemColors.ActiveCaptionText;
            btnEmprestimos.Location = new Point(384, 560);
            btnEmprestimos.Name = "btnEmprestimos";
            btnEmprestimos.Size = new Size(120, 45);
            btnEmprestimos.TabIndex = 24;
            btnEmprestimos.Text = "NOVO EMPRESTIMO";
            btnEmprestimos.UseVisualStyleBackColor = false;
            // 
            // btnCarros
            // 
            btnCarros.BackColor = SystemColors.InactiveCaptionText;
            btnCarros.FlatStyle = FlatStyle.Popup;
            btnCarros.ForeColor = SystemColors.ControlLightLight;
            btnCarros.Location = new Point(61, 370);
            btnCarros.Name = "btnCarros";
            btnCarros.Size = new Size(120, 45);
            btnCarros.TabIndex = 23;
            btnCarros.Text = "CARROS";
            btnCarros.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.InactiveCaptionText;
            btnClientes.FlatStyle = FlatStyle.Popup;
            btnClientes.ForeColor = SystemColors.ControlLightLight;
            btnClientes.Location = new Point(61, 277);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(120, 45);
            btnClientes.TabIndex = 22;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(401, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 109);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1184, 761);
            Controls.Add(pnlTelaPrincipal);
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += TelaPrincipal_Load;
            Resize += Form1_Load;
            pnlTelaPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTabela).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTelaPrincipal;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnNovo;
        private DataGridView dgvTabela;
        private Button btnEmprestimos;
        private Button btnCarros;
        private Button btnClientes;
        private PictureBox pictureBox1;
    }
}