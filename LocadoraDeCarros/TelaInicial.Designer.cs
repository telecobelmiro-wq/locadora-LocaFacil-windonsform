namespace LocadoraDeCarros
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnCliente = new Button();
            btnAdministrador = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gray;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(268, 217);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 13;
            label4.Text = "_______";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(170, 217);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 12;
            label2.Text = "_______";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 115);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gray;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(227, 217);
            label3.Name = "label3";
            label3.Size = new Size(35, 28);
            label3.TabIndex = 10;
            label3.Text = "ou";
            // 
            // btnCliente
            // 
            btnCliente.AutoSize = true;
            btnCliente.ForeColor = SystemColors.ControlText;
            btnCliente.Location = new Point(183, 259);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(120, 34);
            btnCliente.TabIndex = 9;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnAdministrador
            // 
            btnAdministrador.BackColor = SystemColors.GradientInactiveCaption;
            btnAdministrador.ForeColor = SystemColors.ControlText;
            btnAdministrador.Location = new Point(183, 178);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(120, 36);
            btnAdministrador.TabIndex = 8;
            btnAdministrador.Text = "Administrador";
            btnAdministrador.UseVisualStyleBackColor = false;
            btnAdministrador.Click += button1_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(484, 361);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnCliente);
            Controls.Add(btnAdministrador);
            Name = "TelaInicial";
            Text = "TelaInicial";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnCliente;
        private Button btnAdministrador;

    }
}