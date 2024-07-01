namespace Front.Administrador
{
    partial class registrarAdmin
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
            atrasBtn = new Button();
            panel1 = new Panel();
            label = new Label();
            nombreTxt = new TextBox();
            mostrarCheck = new CheckBox();
            label4 = new Label();
            repetirContraseñaTxt = new TextBox();
            label3 = new Label();
            contraseñaTxt = new TextBox();
            label2 = new Label();
            registrarBtn = new Button();
            usuarioTxt = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // atrasBtn
            // 
            atrasBtn.Image = Properties.Resources.atras;
            atrasBtn.Location = new Point(12, 12);
            atrasBtn.Name = "atrasBtn";
            atrasBtn.Size = new Size(57, 54);
            atrasBtn.TabIndex = 4;
            atrasBtn.UseVisualStyleBackColor = true;
            atrasBtn.Click += atrasBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label);
            panel1.Controls.Add(nombreTxt);
            panel1.Controls.Add(mostrarCheck);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(repetirContraseñaTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(contraseñaTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(registrarBtn);
            panel1.Controls.Add(usuarioTxt);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(134, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 465);
            panel1.TabIndex = 3;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Cursor = Cursors.Hand;
            label.Location = new Point(111, 181);
            label.Name = "label";
            label.Size = new Size(57, 17);
            label.TabIndex = 10;
            label.Text = "Nombre";
            // 
            // nombreTxt
            // 
            nombreTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nombreTxt.Location = new Point(111, 201);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(310, 37);
            nombreTxt.TabIndex = 2;
            // 
            // mostrarCheck
            // 
            mostrarCheck.AutoSize = true;
            mostrarCheck.Location = new Point(279, 376);
            mostrarCheck.Name = "mostrarCheck";
            mostrarCheck.Size = new Size(142, 21);
            mostrarCheck.TabIndex = 5;
            mostrarCheck.Text = "Mostrar contraseña";
            mostrarCheck.UseVisualStyleBackColor = true;
            mostrarCheck.CheckedChanged += mostrarCheck_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 311);
            label4.Name = "label4";
            label4.Size = new Size(134, 17);
            label4.TabIndex = 7;
            label4.Text = "Confirmar contraseña";
            // 
            // repetirContraseñaTxt
            // 
            repetirContraseñaTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            repetirContraseñaTxt.Location = new Point(111, 331);
            repetirContraseñaTxt.Name = "repetirContraseñaTxt";
            repetirContraseñaTxt.Size = new Size(310, 37);
            repetirContraseñaTxt.TabIndex = 4;
            repetirContraseñaTxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 245);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // contraseñaTxt
            // 
            contraseñaTxt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            contraseñaTxt.Location = new Point(111, 265);
            contraseñaTxt.Name = "contraseñaTxt";
            contraseñaTxt.Size = new Size(310, 37);
            contraseñaTxt.TabIndex = 3;
            contraseñaTxt.UseSystemPasswordChar = true;
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
            // registrarBtn
            // 
            registrarBtn.Cursor = Cursors.Hand;
            registrarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registrarBtn.Location = new Point(111, 403);
            registrarBtn.Name = "registrarBtn";
            registrarBtn.Size = new Size(310, 54);
            registrarBtn.TabIndex = 6;
            registrarBtn.Text = "Registrarse";
            registrarBtn.UseVisualStyleBackColor = true;
            registrarBtn.Click += registrarBtn_Click;
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
            // registrarAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 570);
            Controls.Add(atrasBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "registrarAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar nuevo administrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button atrasBtn;
        private Panel panel1;
        private Label label3;
        private TextBox contraseñaTxt;
        private Label label2;
        private Button registrarBtn;
        private TextBox usuarioTxt;
        private Label label1;
        private Label label4;
        private TextBox repetirContraseñaTxt;
        private CheckBox mostrarCheck;
        private Label label;
        private TextBox nombreTxt;
    }
}