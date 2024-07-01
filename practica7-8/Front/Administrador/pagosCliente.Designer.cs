namespace Front.Administrador
{
    partial class pagosCliente
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
            label1 = new Label();
            atrasBtn = new Button();
            listaPagos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)listaPagos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(407, 22);
            label2.Name = "label2";
            label2.Size = new Size(182, 46);
            label2.TabIndex = 6;
            label2.Text = "SportGym";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.6831684F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(84, 32);
            label1.Name = "label1";
            label1.Size = new Size(187, 30);
            label1.TabIndex = 5;
            label1.Text = "Pagos registrados";
            // 
            // atrasBtn
            // 
            atrasBtn.Cursor = Cursors.Hand;
            atrasBtn.FlatStyle = FlatStyle.Flat;
            atrasBtn.ForeColor = SystemColors.ButtonFace;
            atrasBtn.Image = Properties.Resources.atras;
            atrasBtn.Location = new Point(19, 22);
            atrasBtn.Name = "atrasBtn";
            atrasBtn.Size = new Size(57, 54);
            atrasBtn.TabIndex = 7;
            atrasBtn.UseVisualStyleBackColor = true;
            atrasBtn.Click += atrasBtn_Click;
            // 
            // listaPagos
            // 
            listaPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaPagos.Location = new Point(19, 91);
            listaPagos.MultiSelect = false;
            listaPagos.Name = "listaPagos";
            listaPagos.ReadOnly = true;
            listaPagos.RowHeadersWidth = 43;
            listaPagos.RowTemplate.Height = 27;
            listaPagos.Size = new Size(558, 309);
            listaPagos.TabIndex = 8;
            // 
            // pagosCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 424);
            Controls.Add(listaPagos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(atrasBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "pagosCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pagos del cliente";
            ((System.ComponentModel.ISupportInitialize)listaPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button atrasBtn;
        private DataGridView listaPagos;
    }
}