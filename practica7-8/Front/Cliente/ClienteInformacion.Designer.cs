namespace Front.Cliente
{
    partial class ClienteInformacion
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
            panel1 = new Panel();
            label4 = new Label();
            telefonoTxt = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            vigenciaPanel = new Panel();
            vigenciaTxt = new Label();
            label5 = new Label();
            vencimientoTxt = new Label();
            label2 = new Label();
            dniTxt = new Label();
            label3 = new Label();
            nombreTxt = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            vigenciaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(telefonoTxt);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(vigenciaPanel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(vencimientoTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dniTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nombreTxt);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 377);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 207);
            label4.Name = "label4";
            label4.Size = new Size(127, 17);
            label4.TabIndex = 14;
            label4.Text = "Número de teléfono";
            // 
            // telefonoTxt
            // 
            telefonoTxt.AutoSize = true;
            telefonoTxt.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            telefonoTxt.Location = new Point(19, 217);
            telefonoTxt.Name = "telefonoTxt";
            telefonoTxt.Size = new Size(277, 45);
            telefonoTxt.TabIndex = 13;
            telefonoTxt.Text = "+00 0000 000000";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.picture1;
            pictureBox1.Location = new Point(362, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(291, 282);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 11;
            label7.Text = "Vencimiento";
            // 
            // vigenciaPanel
            // 
            vigenciaPanel.BackColor = Color.Green;
            vigenciaPanel.Controls.Add(vigenciaTxt);
            vigenciaPanel.Location = new Point(28, 300);
            vigenciaPanel.Name = "vigenciaPanel";
            vigenciaPanel.Size = new Size(244, 65);
            vigenciaPanel.TabIndex = 10;
            // 
            // vigenciaTxt
            // 
            vigenciaTxt.AutoSize = true;
            vigenciaTxt.Font = new Font("Segoe UI Semibold", 36.3564339F, FontStyle.Bold, GraphicsUnit.Point);
            vigenciaTxt.ForeColor = SystemColors.ButtonHighlight;
            vigenciaTxt.Location = new Point(6, -2);
            vigenciaTxt.Name = "vigenciaTxt";
            vigenciaTxt.Size = new Size(232, 68);
            vigenciaTxt.TabIndex = 0;
            vigenciaTxt.Text = "VIGENTE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 280);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 9;
            label5.Text = "Membresía";
            // 
            // vencimientoTxt
            // 
            vencimientoTxt.AutoSize = true;
            vencimientoTxt.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            vencimientoTxt.Location = new Point(274, 293);
            vencimientoTxt.Name = "vencimientoTxt";
            vencimientoTxt.Size = new Size(262, 76);
            vencimientoTxt.TabIndex = 8;
            vencimientoTxt.Text = "10/01/24";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 147);
            label2.Name = "label2";
            label2.Size = new Size(30, 17);
            label2.TabIndex = 7;
            label2.Text = "DNI";
            // 
            // dniTxt
            // 
            dniTxt.AutoSize = true;
            dniTxt.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            dniTxt.Location = new Point(20, 155);
            dniTxt.Name = "dniTxt";
            dniTxt.Size = new Size(164, 46);
            dniTxt.TabIndex = 6;
            dniTxt.Text = "00000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 88);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // nombreTxt
            // 
            nombreTxt.AutoSize = true;
            nombreTxt.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            nombreTxt.Location = new Point(20, 96);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(301, 46);
            nombreTxt.TabIndex = 4;
            nombreTxt.Text = "Nombre Completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30.2376232F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(230, 59);
            label1.TabIndex = 0;
            label1.Text = "SportGym";
            // 
            // ClienteInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 401);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClienteInformacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Información";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            vigenciaPanel.ResumeLayout(false);
            vigenciaPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel vigenciaPanel;
        private Label label5;
        private Label vencimientoTxt;
        private Label label2;
        private Label dniTxt;
        private Label label3;
        private Label nombreTxt;
        private Label label7;
        private Label vigenciaTxt;
        private PictureBox pictureBox1;
        private Label label4;
        private Label telefonoTxt;
    }
}