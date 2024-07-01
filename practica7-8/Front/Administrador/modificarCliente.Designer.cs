namespace Front.Administrador
{
    partial class modificarCliente
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
            label6 = new Label();
            membresiasCMB = new ComboBox();
            label1 = new Label();
            vencimientoMembresiaPicker = new DateTimePicker();
            label5 = new Label();
            nombreTxt = new TextBox();
            label2 = new Label();
            dniTxt = new TextBox();
            label3 = new Label();
            telefonoTxt = new TextBox();
            modificarBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(108, 30);
            label4.Name = "label4";
            label4.Size = new Size(229, 40);
            label4.TabIndex = 7;
            label4.Text = "Modificar cliente";
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(membresiasCMB);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(vencimientoMembresiaPicker);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(nombreTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dniTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(telefonoTxt);
            panel1.Controls.Add(modificarBtn);
            panel1.Location = new Point(17, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 429);
            panel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 222);
            label6.Name = "label6";
            label6.Size = new Size(122, 17);
            label6.TabIndex = 18;
            label6.Text = "Tipo de membresía";
            // 
            // membresiasCMB
            // 
            membresiasCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            membresiasCMB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            membresiasCMB.FormattingEnabled = true;
            membresiasCMB.Location = new Point(30, 242);
            membresiasCMB.Name = "membresiasCMB";
            membresiasCMB.Size = new Size(353, 38);
            membresiasCMB.TabIndex = 17;
            membresiasCMB.SelectedIndexChanged += membresiasCMB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 293);
            label1.Name = "label1";
            label1.Size = new Size(180, 17);
            label1.TabIndex = 16;
            label1.Text = "Vencimiento de la membresía";
            // 
            // vencimientoMembresiaPicker
            // 
            vencimientoMembresiaPicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vencimientoMembresiaPicker.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            vencimientoMembresiaPicker.Format = DateTimePickerFormat.Custom;
            vencimientoMembresiaPicker.Location = new Point(30, 313);
            vencimientoMembresiaPicker.Name = "vencimientoMembresiaPicker";
            vencimientoMembresiaPicker.Size = new Size(353, 37);
            vencimientoMembresiaPicker.TabIndex = 15;
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
            // nombreTxt
            // 
            nombreTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nombreTxt.Location = new Point(30, 106);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(353, 37);
            nombreTxt.TabIndex = 3;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 154);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 10;
            label3.Text = "Teléfono";
            // 
            // telefonoTxt
            // 
            telefonoTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            telefonoTxt.Location = new Point(30, 174);
            telefonoTxt.Name = "telefonoTxt";
            telefonoTxt.Size = new Size(353, 37);
            telefonoTxt.TabIndex = 4;
            // 
            // modificarBtn
            // 
            modificarBtn.Cursor = Cursors.Hand;
            modificarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modificarBtn.Location = new Point(30, 372);
            modificarBtn.Name = "modificarBtn";
            modificarBtn.Size = new Size(353, 54);
            modificarBtn.TabIndex = 6;
            modificarBtn.Text = "Modificar";
            modificarBtn.UseVisualStyleBackColor = true;
            modificarBtn.Click += modificarBtn_Click;
            // 
            // modificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 514);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "modificarCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modificar datos del cliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private Label label1;
        private DateTimePicker vencimientoMembresiaPicker;
        private Label label5;
        private TextBox nombreTxt;
        private Label label2;
        private TextBox dniTxt;
        private Label label3;
        private TextBox telefonoTxt;
        private Button modificarBtn;
        private Label label6;
        private ComboBox membresiasCMB;
    }
}