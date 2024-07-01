namespace Front.Administrador
{
    partial class AutenticacionAdmin
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
            label2 = new Label();
            iniciarBtn = new Button();
            usuarioTxt = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            mostrarCheck = new CheckBox();
            adminBtn = new Label();
            label5 = new Label();
            label3 = new Label();
            contraseñaTxt = new TextBox();
            atrasBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 118);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // iniciarBtn
            // 
            iniciarBtn.Cursor = Cursors.Hand;
            iniciarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iniciarBtn.Location = new Point(111, 273);
            iniciarBtn.Name = "iniciarBtn";
            iniciarBtn.Size = new Size(310, 54);
            iniciarBtn.TabIndex = 4;
            iniciarBtn.Text = "Iniciar sesión";
            iniciarBtn.UseVisualStyleBackColor = true;
            iniciarBtn.Click += iniciarBtn_Click;
            // 
            // usuarioTxt
            // 
            usuarioTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            usuarioTxt.Location = new Point(111, 138);
            usuarioTxt.Name = "usuarioTxt";
            usuarioTxt.Size = new Size(310, 37);
            usuarioTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30.2376232F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(151, 52);
            label1.Name = "label1";
            label1.Size = new Size(230, 59);
            label1.TabIndex = 0;
            label1.Text = "SportGym";
            // 
            // panel1
            // 
            panel1.Controls.Add(mostrarCheck);
            panel1.Controls.Add(adminBtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(contraseñaTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iniciarBtn);
            panel1.Controls.Add(usuarioTxt);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(134, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 396);
            panel1.TabIndex = 1;
            // 
            // mostrarCheck
            // 
            mostrarCheck.AutoSize = true;
            mostrarCheck.Location = new Point(279, 248);
            mostrarCheck.Name = "mostrarCheck";
            mostrarCheck.Size = new Size(142, 21);
            mostrarCheck.TabIndex = 3;
            mostrarCheck.Text = "Mostrar contraseña";
            mostrarCheck.UseVisualStyleBackColor = true;
            mostrarCheck.CheckedChanged += mostrarCheck_CheckedChanged;
            // 
            // adminBtn
            // 
            adminBtn.AutoSize = true;
            adminBtn.Cursor = Cursors.Hand;
            adminBtn.ForeColor = Color.Blue;
            adminBtn.Location = new Point(206, 354);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(120, 17);
            adminBtn.TabIndex = 5;
            adminBtn.Text = "Crear cuenta nueva";
            adminBtn.Click += adminBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 331);
            label5.Name = "label5";
            label5.Size = new Size(133, 17);
            label5.TabIndex = 8;
            label5.Text = "_________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 185);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // contraseñaTxt
            // 
            contraseñaTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            contraseñaTxt.Location = new Point(111, 205);
            contraseñaTxt.Name = "contraseñaTxt";
            contraseñaTxt.Size = new Size(310, 37);
            contraseñaTxt.TabIndex = 2;
            contraseñaTxt.UseSystemPasswordChar = true;
            // 
            // atrasBtn
            // 
            atrasBtn.Image = Properties.Resources.atras;
            atrasBtn.Location = new Point(12, 12);
            atrasBtn.Name = "atrasBtn";
            atrasBtn.Size = new Size(57, 54);
            atrasBtn.TabIndex = 6;
            atrasBtn.UseVisualStyleBackColor = true;
            atrasBtn.Click += atrasBtn_Click;
            // 
            // AutenticacionAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(atrasBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AutenticacionAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autenticación";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Button iniciarBtn;
        private TextBox usuarioTxt;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private TextBox contraseñaTxt;
        private Button atrasBtn;
        private Label adminBtn;
        private Label label5;
        private CheckBox mostrarCheck;
    }
}