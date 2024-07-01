namespace Front.Administrador
{
    partial class RegistrarCliente
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
            vencimientoTxt = new Label();
            label9 = new Label();
            precioTxt = new Label();
            label6 = new Label();
            label5 = new Label();
            membresiasCMB = new ComboBox();
            label3 = new Label();
            telefonoTxt = new TextBox();
            label1 = new Label();
            nombreTxt = new TextBox();
            label2 = new Label();
            registrarBtn = new Button();
            dniTxt = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(vencimientoTxt);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(precioTxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(membresiasCMB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(telefonoTxt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nombreTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(registrarBtn);
            panel1.Controls.Add(dniTxt);
            panel1.Location = new Point(10, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 434);
            panel1.TabIndex = 0;
            // 
            // vencimientoTxt
            // 
            vencimientoTxt.AutoSize = true;
            vencimientoTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            vencimientoTxt.ForeColor = Color.Red;
            vencimientoTxt.Location = new Point(192, 307);
            vencimientoTxt.Name = "vencimientoTxt";
            vencimientoTxt.Size = new Size(104, 31);
            vencimientoTxt.TabIndex = 16;
            vencimientoTxt.Text = "00/00/00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(195, 292);
            label9.Name = "label9";
            label9.Size = new Size(78, 17);
            label9.TabIndex = 15;
            label9.Text = "Vencimiento";
            // 
            // precioTxt
            // 
            precioTxt.AutoSize = true;
            precioTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            precioTxt.ForeColor = Color.Green;
            precioTxt.Location = new Point(28, 307);
            precioTxt.Name = "precioTxt";
            precioTxt.Size = new Size(121, 31);
            precioTxt.TabIndex = 14;
            precioTxt.Text = "00000 ARS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 292);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 13;
            label6.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 220);
            label5.Name = "label5";
            label5.Size = new Size(122, 17);
            label5.TabIndex = 12;
            label5.Text = "Tipo de membresía";
            // 
            // membresiasCMB
            // 
            membresiasCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            membresiasCMB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            membresiasCMB.FormattingEnabled = true;
            membresiasCMB.Location = new Point(30, 240);
            membresiasCMB.Name = "membresiasCMB";
            membresiasCMB.Size = new Size(353, 38);
            membresiasCMB.TabIndex = 4;
            membresiasCMB.SelectedIndexChanged += membresiasCMB_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 155);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 10;
            label3.Text = "Teléfono";
            // 
            // telefonoTxt
            // 
            telefonoTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            telefonoTxt.Location = new Point(30, 175);
            telefonoTxt.Name = "telefonoTxt";
            telefonoTxt.Size = new Size(353, 37);
            telefonoTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 89);
            label1.Name = "label1";
            label1.Size = new Size(116, 17);
            label1.TabIndex = 8;
            label1.Text = "Nombre completo";
            // 
            // nombreTxt
            // 
            nombreTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nombreTxt.Location = new Point(30, 109);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(353, 37);
            nombreTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 23);
            label2.Name = "label2";
            label2.Size = new Size(30, 17);
            label2.TabIndex = 6;
            label2.Text = "DNI";
            // 
            // registrarBtn
            // 
            registrarBtn.Cursor = Cursors.Hand;
            registrarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registrarBtn.Location = new Point(30, 356);
            registrarBtn.Name = "registrarBtn";
            registrarBtn.Size = new Size(353, 54);
            registrarBtn.TabIndex = 5;
            registrarBtn.Text = "Registrar";
            registrarBtn.UseVisualStyleBackColor = true;
            registrarBtn.Click += registrarBtn_Click;
            // 
            // dniTxt
            // 
            dniTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dniTxt.Location = new Point(30, 43);
            dniTxt.Name = "dniTxt";
            dniTxt.Size = new Size(353, 37);
            dniTxt.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(106, 44);
            label4.Name = "label4";
            label4.Size = new Size(220, 40);
            label4.TabIndex = 1;
            label4.Text = "Registrar cliente";
            // 
            // RegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 533);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegistrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar nuevo cliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button registrarBtn;
        private TextBox dniTxt;
        private Label label1;
        private TextBox nombreTxt;
        private Label label3;
        private TextBox telefonoTxt;
        private Label label4;
        private Label label5;
        private ComboBox membresiasCMB;
        private Label vencimientoTxt;
        private Label label9;
        private Label precioTxt;
        private Label label6;
    }
}