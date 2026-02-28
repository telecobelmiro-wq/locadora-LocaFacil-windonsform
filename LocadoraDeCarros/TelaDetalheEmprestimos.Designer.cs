namespace LocadoraDeCarros
{
    partial class TelaDetalheEmprestimos
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
            lblCliente = new Label();
            lblEntrega = new Label();
            lblStatus = new Label();
            lblInfo = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(302, 155);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // lblEntrega
            // 
            lblEntrega.AutoSize = true;
            lblEntrega.Location = new Point(302, 209);
            lblEntrega.Name = "lblEntrega";
            lblEntrega.Size = new Size(47, 15);
            lblEntrega.TabIndex = 1;
            lblEntrega.Text = "Entrega";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(302, 106);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(302, 60);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(73, 15);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Informações";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(696, 405);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "DEVOLVER";
            button1.UseVisualStyleBackColor = false;
            // 
            // TelaDetalheEmprestimos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblInfo);
            Controls.Add(lblStatus);
            Controls.Add(lblEntrega);
            Controls.Add(lblCliente);
            Name = "TelaDetalheEmprestimos";
            Text = "TelaDetalheEmprestimos";
            Load += TelaDetalheEmprestimos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label lblEntrega;
        private Label lblStatus;
        private Label lblInfo;
        private Button button1;
    }
}