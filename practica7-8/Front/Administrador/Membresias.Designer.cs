namespace Front.Administrador
{
    partial class Membresias
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
            listaMembresiasGrid = new DataGridView();
            modificarBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            crearBtn = new Button();
            eliminarBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)listaMembresiasGrid).BeginInit();
            SuspendLayout();
            // 
            // atrasBtn
            // 
            atrasBtn.Cursor = Cursors.Hand;
            atrasBtn.FlatStyle = FlatStyle.Flat;
            atrasBtn.ForeColor = SystemColors.ButtonFace;
            atrasBtn.Image = Properties.Resources.atras;
            atrasBtn.Location = new Point(17, 15);
            atrasBtn.Name = "atrasBtn";
            atrasBtn.Size = new Size(57, 54);
            atrasBtn.TabIndex = 4;
            atrasBtn.UseVisualStyleBackColor = true;
            atrasBtn.Click += atrasBtn_Click;
            // 
            // listaMembresiasGrid
            // 
            listaMembresiasGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaMembresiasGrid.Location = new Point(29, 79);
            listaMembresiasGrid.MultiSelect = false;
            listaMembresiasGrid.Name = "listaMembresiasGrid";
            listaMembresiasGrid.ReadOnly = true;
            listaMembresiasGrid.RowHeadersWidth = 43;
            listaMembresiasGrid.RowTemplate.Height = 27;
            listaMembresiasGrid.Size = new Size(404, 330);
            listaMembresiasGrid.TabIndex = 1;
            listaMembresiasGrid.CellClick += listaMembresiasGrid_CellClick;
            // 
            // modificarBtn
            // 
            modificarBtn.Location = new Point(439, 145);
            modificarBtn.Name = "modificarBtn";
            modificarBtn.Size = new Size(210, 60);
            modificarBtn.TabIndex = 2;
            modificarBtn.Text = "Modificar";
            modificarBtn.UseVisualStyleBackColor = true;
            modificarBtn.Click += modificarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.6831684F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(82, 25);
            label1.Name = "label1";
            label1.Size = new Size(212, 30);
            label1.TabIndex = 3;
            label1.Text = "Tipos de membresía";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(469, 15);
            label2.Name = "label2";
            label2.Size = new Size(182, 46);
            label2.TabIndex = 4;
            label2.Text = "SportGym";
            // 
            // crearBtn
            // 
            crearBtn.Location = new Point(439, 79);
            crearBtn.Name = "crearBtn";
            crearBtn.Size = new Size(210, 60);
            crearBtn.TabIndex = 1;
            crearBtn.Text = "Crear nuevo tipo";
            crearBtn.UseVisualStyleBackColor = true;
            crearBtn.Click += crearBtn_Click;
            // 
            // eliminarBtn
            // 
            eliminarBtn.Location = new Point(439, 211);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(210, 60);
            eliminarBtn.TabIndex = 3;
            eliminarBtn.Text = "Eliminar";
            eliminarBtn.UseVisualStyleBackColor = true;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // Membresias
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 439);
            Controls.Add(eliminarBtn);
            Controls.Add(crearBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(modificarBtn);
            Controls.Add(listaMembresiasGrid);
            Controls.Add(atrasBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Membresias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Membresias";
            Load += Membresias_Load;
            ((System.ComponentModel.ISupportInitialize)listaMembresiasGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button atrasBtn;
        private DataGridView listaMembresiasGrid;
        private Button modificarBtn;
        private Label label1;
        private Label label2;
        private Button crearBtn;
        private Button eliminarBtn;
    }
}