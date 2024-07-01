namespace Front
{
    partial class Inicio
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
            panel2 = new Panel();
            label4 = new Label();
            adminBtn = new Label();
            label3 = new Label();
            label2 = new Label();
            clienteBtn = new Button();
            dniTxt = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(clienteBtn);
            panel1.Controls.Add(dniTxt);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(134, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 378);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(adminBtn);
            panel2.Location = new Point(182, 296);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 28);
            panel2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 5;
            label4.Text = "Iniciar como";
            // 
            // adminBtn
            // 
            adminBtn.AutoSize = true;
            adminBtn.Cursor = Cursors.Hand;
            adminBtn.ForeColor = Color.Blue;
            adminBtn.Location = new Point(78, 0);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(90, 17);
            adminBtn.TabIndex = 3;
            adminBtn.Text = "administrador";
            adminBtn.Click += adminBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 268);
            label3.Name = "label3";
            label3.Size = new Size(133, 17);
            label3.TabIndex = 4;
            label3.Text = "_________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 141);
            label2.Name = "label2";
            label2.Size = new Size(30, 17);
            label2.TabIndex = 3;
            label2.Text = "DNI";
            // 
            // clienteBtn
            // 
            clienteBtn.Cursor = Cursors.Hand;
            clienteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clienteBtn.Location = new Point(111, 211);
            clienteBtn.Name = "clienteBtn";
            clienteBtn.Size = new Size(310, 54);
            clienteBtn.TabIndex = 2;
            clienteBtn.Text = "Entrar";
            clienteBtn.UseVisualStyleBackColor = true;
            clienteBtn.Click += clienteBtn_Click;
            // 
            // dniTxt
            // 
            dniTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dniTxt.Location = new Point(111, 161);
            dniTxt.Name = "dniTxt";
            dniTxt.Size = new Size(310, 37);
            dniTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30.2376232F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(151, 75);
            label1.Name = "label1";
            label1.Size = new Size(230, 59);
            label1.TabIndex = 0;
            label1.Text = "SportGym";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            FormClosing += Inicio_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button clienteBtn;
        private TextBox dniTxt;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label adminBtn;
        private Label label3;
        private Label label2;
    }
}