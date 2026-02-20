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
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnCliente = new Button();
            btnAdministrador = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAdministrador);
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 394);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gray;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(218, 235);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 20;
            label4.Text = "_______";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(120, 235);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 19;
            label2.Text = "_______";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 115);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gray;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(177, 235);
            label3.Name = "label3";
            label3.Size = new Size(35, 28);
            label3.TabIndex = 17;
            label3.Text = "ou";
            // 
            // btnCliente
            // 
            btnCliente.AutoSize = true;
            btnCliente.ForeColor = SystemColors.ControlText;
            btnCliente.Location = new Point(133, 277);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(120, 34);
            btnCliente.TabIndex = 16;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnAdministrador
            // 
            btnAdministrador.BackColor = SystemColors.GradientInactiveCaption;
            btnAdministrador.ForeColor = SystemColors.ControlText;
            btnAdministrador.Location = new Point(133, 196);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(120, 36);
            btnAdministrador.TabIndex = 15;
            btnAdministrador.Text = "Administrador";
            btnAdministrador.UseVisualStyleBackColor = false;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(708, 465);
            Controls.Add(panel1);
            Name = "TelaInicial";
            Text = "TelaInicial";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnAdministrador;
        private Button btnCliente;
        private Label label3;
    }
}