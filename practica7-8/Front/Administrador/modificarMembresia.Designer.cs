namespace Front.Administrador
{
    partial class modificarMembresia
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
            label1 = new Label();
            label5 = new Label();
            membresiasCMB = new ComboBox();
            descripcionTxt = new TextBox();
            label2 = new Label();
            precioTxt = new TextBox();
            label3 = new Label();
            cantMesesTxt = new TextBox();
            modificarBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(79, 31);
            label4.Name = "label4";
            label4.Size = new Size(287, 40);
            label4.TabIndex = 5;
            label4.Text = "Modificar membresía";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(membresiasCMB);
            panel1.Controls.Add(descripcionTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(precioTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cantMesesTxt);
            panel1.Controls.Add(modificarBtn);
            panel1.Location = new Point(17, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 369);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(183, 17);
            label1.TabIndex = 14;
            label1.Text = "Identificador de la membresía";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 86);
            label5.Name = "label5";
            label5.Size = new Size(76, 17);
            label5.TabIndex = 14;
            label5.Text = "Descripción";
            // 
            // membresiasCMB
            // 
            membresiasCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            membresiasCMB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            membresiasCMB.FormattingEnabled = true;
            membresiasCMB.Location = new Point(30, 39);
            membresiasCMB.Name = "membresiasCMB";
            membresiasCMB.Size = new Size(353, 38);
            membresiasCMB.TabIndex = 13;
            membresiasCMB.SelectedIndexChanged += membresiasCMB_SelectedIndexChanged;
            // 
            // descripcionTxt
            // 
            descripcionTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            descripcionTxt.Location = new Point(30, 106);
            descripcionTxt.Name = "descripcionTxt";
            descripcionTxt.Size = new Size(353, 37);
            descripcionTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 219);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 12;
            label2.Text = "Precio (ARS)";
            // 
            // precioTxt
            // 
            precioTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            precioTxt.Location = new Point(30, 239);
            precioTxt.Name = "precioTxt";
            precioTxt.Size = new Size(353, 37);
            precioTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 154);
            label3.Name = "label3";
            label3.Size = new Size(120, 17);
            label3.TabIndex = 10;
            label3.Text = "Cantidad de meses";
            // 
            // cantMesesTxt
            // 
            cantMesesTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cantMesesTxt.Location = new Point(30, 174);
            cantMesesTxt.Name = "cantMesesTxt";
            cantMesesTxt.Size = new Size(353, 37);
            cantMesesTxt.TabIndex = 4;
            // 
            // modificarBtn
            // 
            modificarBtn.Cursor = Cursors.Hand;
            modificarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modificarBtn.Location = new Point(30, 296);
            modificarBtn.Name = "modificarBtn";
            modificarBtn.Size = new Size(353, 54);
            modificarBtn.TabIndex = 6;
            modificarBtn.Text = "Modificar";
            modificarBtn.UseVisualStyleBackColor = true;
            modificarBtn.Click += modificarBtn_Click;
            // 
            // modificarMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 462);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "modificarMembresia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar membresia";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private Label label2;
        private TextBox precioTxt;
        private Label label3;
        private TextBox cantMesesTxt;
        private Button modificarBtn;
        private Label label5;
        private TextBox descripcionTxt;
        private Label label1;
        private ComboBox membresiasCMB;
    }
}