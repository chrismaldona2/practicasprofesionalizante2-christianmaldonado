namespace Front
{
    partial class ListaRazas
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
            razasDataGridView = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)razasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // razasDataGridView
            // 
            razasDataGridView.BackgroundColor = Color.FromArgb(238, 229, 224);
            razasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            razasDataGridView.Location = new Point(27, 69);
            razasDataGridView.Name = "razasDataGridView";
            razasDataGridView.RowHeadersWidth = 43;
            razasDataGridView.RowTemplate.Height = 27;
            razasDataGridView.Size = new Size(554, 278);
            razasDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(167, 35);
            label1.TabIndex = 1;
            label1.Text = "Lista de razas";
            // 
            // ListaRazas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 158, 104);
            ClientSize = new Size(614, 381);
            Controls.Add(label1);
            Controls.Add(razasDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ListaRazas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Razas";
            Load += ListaRazas_Load;
            ((System.ComponentModel.ISupportInitialize)razasDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView razasDataGridView;
        private Label label1;
    }
}