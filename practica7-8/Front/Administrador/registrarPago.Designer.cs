namespace Front.Administrador
{
    partial class registrarPago
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
            label4 = new Label();
            panel1 = new Panel();
            vencimientoTxt = new Label();
            label9 = new Label();
            precioTxt = new Label();
            label6 = new Label();
            label1 = new Label();
            membresiasCMB = new ComboBox();
            nombreTxt = new TextBox();
            label5 = new Label();
            label2 = new Label();
            dniTxt = new TextBox();
            pagarBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(79, 25);
            label4.Name = "label4";
            label4.Size = new Size(269, 40);
            label4.TabIndex = 9;
            label4.Text = "Renovar membresía";
            // 
            // panel1
            // 
            panel1.Controls.Add(vencimientoTxt);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(precioTxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(membresiasCMB);
            panel1.Controls.Add(nombreTxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dniTxt);
            panel1.Controls.Add(pagarBtn);
            panel1.Location = new Point(9, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 359);
            panel1.TabIndex = 8;
            // 
            // vencimientoTxt
            // 
            vencimientoTxt.AutoSize = true;
            vencimientoTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            vencimientoTxt.ForeColor = Color.Red;
            vencimientoTxt.Location = new Point(192, 241);
            vencimientoTxt.Name = "vencimientoTxt";
            vencimientoTxt.Size = new Size(104, 31);
            vencimientoTxt.TabIndex = 22;
            vencimientoTxt.Text = "00/00/00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(195, 226);
            label9.Name = "label9";
            label9.Size = new Size(119, 17);
            label9.TabIndex = 21;
            label9.Text = "Nuevo vencimiento";
            // 
            // precioTxt
            // 
            precioTxt.AutoSize = true;
            precioTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            precioTxt.ForeColor = Color.Green;
            precioTxt.Location = new Point(28, 241);
            precioTxt.Name = "precioTxt";
            precioTxt.Size = new Size(121, 31);
            precioTxt.TabIndex = 20;
            precioTxt.Text = "00000 ARS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 226);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 19;
            label6.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 154);
            label1.Name = "label1";
            label1.Size = new Size(122, 17);
            label1.TabIndex = 18;
            label1.Text = "Tipo de membresía";
            // 
            // membresiasCMB
            // 
            membresiasCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            membresiasCMB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            membresiasCMB.FormattingEnabled = true;
            membresiasCMB.Location = new Point(30, 174);
            membresiasCMB.Name = "membresiasCMB";
            membresiasCMB.Size = new Size(353, 38);
            membresiasCMB.TabIndex = 17;
            membresiasCMB.SelectedIndexChanged += membresiasCMB_SelectedIndexChanged;
            // 
            // nombreTxt
            // 
            nombreTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nombreTxt.Location = new Point(30, 106);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.ReadOnly = true;
            nombreTxt.Size = new Size(353, 37);
            nombreTxt.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 86);
            label5.Name = "label5";
            label5.Size = new Size(57, 17);
            label5.TabIndex = 14;
            label5.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 23);
            label2.Name = "label2";
            label2.Size = new Size(30, 17);
            label2.TabIndex = 12;
            label2.Text = "DNI";
            // 
            // dniTxt
            // 
            dniTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dniTxt.Location = new Point(30, 43);
            dniTxt.Name = "dniTxt";
            dniTxt.ReadOnly = true;
            dniTxt.Size = new Size(353, 37);
            dniTxt.TabIndex = 5;
            // 
            // pagarBtn
            // 
            pagarBtn.Cursor = Cursors.Hand;
            pagarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pagarBtn.Location = new Point(30, 284);
            pagarBtn.Name = "pagarBtn";
            pagarBtn.Size = new Size(353, 54);
            pagarBtn.TabIndex = 6;
            pagarBtn.Text = "Pagar";
            pagarBtn.UseVisualStyleBackColor = true;
            pagarBtn.Click += pagarBtn_Click;
            // 
            // registrarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 432);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "registrarPago";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar pago";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private Label label5;
        private Label label2;
        private TextBox dniTxt;
        private Button pagarBtn;
        private TextBox nombreTxt;
        private Label vencimientoTxt;
        private Label label9;
        private Label precioTxt;
        private Label label6;
        private Label label1;
        private ComboBox membresiasCMB;
    }
}