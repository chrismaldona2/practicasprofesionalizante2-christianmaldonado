namespace Front.Administrador
{
    partial class crearMembresia
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
            label2 = new Label();
            precioTxt = new TextBox();
            label3 = new Label();
            cantMesesTxt = new TextBox();
            label1 = new Label();
            descripcionTxt = new TextBox();
            crearBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 34);
            label4.Name = "label4";
            label4.Size = new Size(333, 40);
            label4.TabIndex = 3;
            label4.Text = "Crear tipo de membresia";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(precioTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cantMesesTxt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(descripcionTxt);
            panel1.Controls.Add(crearBtn);
            panel1.Location = new Point(17, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 296);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 154);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 12;
            label2.Text = "Precio (ARS)";
            // 
            // precioTxt
            // 
            precioTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            precioTxt.Location = new Point(30, 174);
            precioTxt.Name = "precioTxt";
            precioTxt.Size = new Size(353, 37);
            precioTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 86);
            label3.Name = "label3";
            label3.Size = new Size(120, 17);
            label3.TabIndex = 10;
            label3.Text = "Cantidad de meses";
            // 
            // cantMesesTxt
            // 
            cantMesesTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cantMesesTxt.Location = new Point(30, 106);
            cantMesesTxt.Name = "cantMesesTxt";
            cantMesesTxt.Size = new Size(353, 37);
            cantMesesTxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 8;
            label1.Text = "Descripción";
            // 
            // descripcionTxt
            // 
            descripcionTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            descripcionTxt.Location = new Point(30, 40);
            descripcionTxt.Name = "descripcionTxt";
            descripcionTxt.Size = new Size(353, 37);
            descripcionTxt.TabIndex = 1;
            // 
            // crearBtn
            // 
            crearBtn.Cursor = Cursors.Hand;
            crearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            crearBtn.Location = new Point(30, 230);
            crearBtn.Name = "crearBtn";
            crearBtn.Size = new Size(353, 54);
            crearBtn.TabIndex = 4;
            crearBtn.Text = "Crear";
            crearBtn.UseVisualStyleBackColor = true;
            crearBtn.Click += crearBtn_Click;
            // 
            // crearMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 400);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "crearMembresia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "crearMembresia";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private Label label3;
        private TextBox cantMesesTxt;
        private Label label1;
        private TextBox descripcionTxt;
        private Button crearBtn;
        private Label label2;
        private TextBox precioTxt;
    }
}