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
            generarDatoBtn = new Button();
            pictureBox1 = new PictureBox();
            listaRazasBtn = new Button();
            label1 = new Label();
            limiteDato = new TextBox();
            limiteLista = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // generarDatoBtn
            // 
            generarDatoBtn.BackColor = Color.FromArgb(210, 158, 104);
            generarDatoBtn.Cursor = Cursors.Hand;
            generarDatoBtn.FlatStyle = FlatStyle.Flat;
            generarDatoBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            generarDatoBtn.ForeColor = SystemColors.ButtonHighlight;
            generarDatoBtn.Location = new Point(267, 298);
            generarDatoBtn.Name = "generarDatoBtn";
            generarDatoBtn.Size = new Size(234, 38);
            generarDatoBtn.TabIndex = 2;
            generarDatoBtn.Text = "Generar dato aleatorio";
            generarDatoBtn.UseVisualStyleBackColor = false;
            generarDatoBtn.Click += generarDatoBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Cat_PNG;
            pictureBox1.Location = new Point(172, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // listaRazasBtn
            // 
            listaRazasBtn.BackColor = Color.FromArgb(210, 158, 104);
            listaRazasBtn.Cursor = Cursors.Hand;
            listaRazasBtn.FlatStyle = FlatStyle.Flat;
            listaRazasBtn.Font = new Font("Segoe UI Semibold", 12.1188116F, FontStyle.Bold, GraphicsUnit.Point);
            listaRazasBtn.ForeColor = SystemColors.ButtonHighlight;
            listaRazasBtn.Location = new Point(267, 365);
            listaRazasBtn.Name = "listaRazasBtn";
            listaRazasBtn.Size = new Size(234, 38);
            listaRazasBtn.TabIndex = 4;
            listaRazasBtn.Text = "Obtener lista de razas";
            listaRazasBtn.UseVisualStyleBackColor = false;
            listaRazasBtn.Click += listaRazasBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 278);
            label1.Name = "label1";
            label1.Size = new Size(181, 17);
            label1.TabIndex = 3;
            label1.Text = "Limite de caracteres del dato:";
            // 
            // limiteDato
            // 
            limiteDato.BorderStyle = BorderStyle.None;
            limiteDato.Font = new Font("Segoe UI", 19.9603958F, FontStyle.Regular, GraphicsUnit.Point);
            limiteDato.Location = new Point(35, 298);
            limiteDato.Name = "limiteDato";
            limiteDato.Size = new Size(226, 38);
            limiteDato.TabIndex = 1;
            // 
            // limiteLista
            // 
            limiteLista.BorderStyle = BorderStyle.None;
            limiteLista.Font = new Font("Segoe UI", 19.9603958F, FontStyle.Regular, GraphicsUnit.Point);
            limiteLista.Location = new Point(35, 365);
            limiteLista.Name = "limiteLista";
            limiteLista.Size = new Size(226, 38);
            limiteLista.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 345);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 6;
            label2.Text = "Limite de razas:";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 229, 224);
            ClientSize = new Size(545, 450);
            Controls.Add(label2);
            Controls.Add(limiteLista);
            Controls.Add(limiteDato);
            Controls.Add(label1);
            Controls.Add(listaRazasBtn);
            Controls.Add(pictureBox1);
            Controls.Add(generarDatoBtn);
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gatos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generarDatoBtn;
        private PictureBox pictureBox1;
        private Button listaRazasBtn;
        private Label label1;
        private TextBox limiteDato;
        private TextBox limiteLista;
        private Label label2;
    }
}