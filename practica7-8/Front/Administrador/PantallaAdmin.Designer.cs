namespace Front.Administrador
{
    partial class PantallaAdmin
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
            registrarClienteBtn = new Button();
            listaClientesGrid = new DataGridView();
            label1 = new Label();
            bienvenidoTxt = new Label();
            membresiasBtn = new Button();
            eliminarBtn = new Button();
            modificarClienteBtn = new Button();
            verPagosBtn = new Button();
            renovarMembresiaBtn = new Button();
            filtrarVencidasBtn = new Button();
            labelPic = new PictureBox();
            salirBtn = new Button();
            buscarBtn = new Button();
            dniTxt = new TextBox();
            label2 = new Label();
            recargarBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)listaClientesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)labelPic).BeginInit();
            SuspendLayout();
            // 
            // registrarClienteBtn
            // 
            registrarClienteBtn.Location = new Point(523, 143);
            registrarClienteBtn.Name = "registrarClienteBtn";
            registrarClienteBtn.Size = new Size(264, 56);
            registrarClienteBtn.TabIndex = 1;
            registrarClienteBtn.Text = "Registrar nuevo cliente";
            registrarClienteBtn.UseVisualStyleBackColor = true;
            registrarClienteBtn.Click += registrarClienteBtn_Click;
            // 
            // listaClientesGrid
            // 
            listaClientesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaClientesGrid.Location = new Point(28, 143);
            listaClientesGrid.MultiSelect = false;
            listaClientesGrid.Name = "listaClientesGrid";
            listaClientesGrid.ReadOnly = true;
            listaClientesGrid.RowHeadersWidth = 43;
            listaClientesGrid.RowTemplate.Height = 27;
            listaClientesGrid.Size = new Size(484, 366);
            listaClientesGrid.TabIndex = 1;
            listaClientesGrid.CellClick += listaClientesGrid_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(511, 27);
            label1.Name = "label1";
            label1.Size = new Size(219, 55);
            label1.TabIndex = 2;
            label1.Text = "SportGym";
            // 
            // bienvenidoTxt
            // 
            bienvenidoTxt.AutoSize = true;
            bienvenidoTxt.Font = new Font("Segoe UI", 19.9603958F, FontStyle.Regular, GraphicsUnit.Point);
            bienvenidoTxt.Location = new Point(22, 44);
            bienvenidoTxt.Name = "bienvenidoTxt";
            bienvenidoTxt.Size = new Size(162, 38);
            bienvenidoTxt.TabIndex = 3;
            bienvenidoTxt.Text = "Bienvenido!";
            // 
            // membresiasBtn
            // 
            membresiasBtn.Location = new Point(524, 453);
            membresiasBtn.Name = "membresiasBtn";
            membresiasBtn.Size = new Size(264, 56);
            membresiasBtn.TabIndex = 6;
            membresiasBtn.Text = "Administrar tipos de membresía";
            membresiasBtn.UseVisualStyleBackColor = true;
            membresiasBtn.Click += membresiasBtn_Click;
            // 
            // eliminarBtn
            // 
            eliminarBtn.Location = new Point(524, 205);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(264, 56);
            eliminarBtn.TabIndex = 2;
            eliminarBtn.Text = "Eliminar cliente";
            eliminarBtn.UseVisualStyleBackColor = true;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // modificarClienteBtn
            // 
            modificarClienteBtn.Location = new Point(523, 267);
            modificarClienteBtn.Name = "modificarClienteBtn";
            modificarClienteBtn.Size = new Size(264, 56);
            modificarClienteBtn.TabIndex = 3;
            modificarClienteBtn.Text = "Modificar datos del cliente";
            modificarClienteBtn.UseVisualStyleBackColor = true;
            modificarClienteBtn.Click += modificarClienteBtn_Click;
            // 
            // verPagosBtn
            // 
            verPagosBtn.Location = new Point(524, 391);
            verPagosBtn.Name = "verPagosBtn";
            verPagosBtn.Size = new Size(264, 56);
            verPagosBtn.TabIndex = 5;
            verPagosBtn.Text = "Ver pagos del cliente";
            verPagosBtn.UseVisualStyleBackColor = true;
            verPagosBtn.Click += verPagosBtn_Click;
            // 
            // renovarMembresiaBtn
            // 
            renovarMembresiaBtn.Location = new Point(524, 329);
            renovarMembresiaBtn.Name = "renovarMembresiaBtn";
            renovarMembresiaBtn.Size = new Size(264, 56);
            renovarMembresiaBtn.TabIndex = 4;
            renovarMembresiaBtn.Text = "Renovar membresía";
            renovarMembresiaBtn.UseVisualStyleBackColor = true;
            renovarMembresiaBtn.Click += renovarMembresiaBtn_Click;
            // 
            // filtrarVencidasBtn
            // 
            filtrarVencidasBtn.Cursor = Cursors.Hand;
            filtrarVencidasBtn.Location = new Point(308, 112);
            filtrarVencidasBtn.Name = "filtrarVencidasBtn";
            filtrarVencidasBtn.Size = new Size(177, 25);
            filtrarVencidasBtn.TabIndex = 7;
            filtrarVencidasBtn.Text = "Membresías vencidas";
            filtrarVencidasBtn.UseVisualStyleBackColor = true;
            filtrarVencidasBtn.Click += filtrarVencidasBtn_Click;
            // 
            // labelPic
            // 
            labelPic.Image = Properties.Resources.labelListaClientes;
            labelPic.Location = new Point(10, 413);
            labelPic.Name = "labelPic";
            labelPic.Size = new Size(19, 108);
            labelPic.TabIndex = 10;
            labelPic.TabStop = false;
            // 
            // salirBtn
            // 
            salirBtn.Cursor = Cursors.Hand;
            salirBtn.Image = Properties.Resources.cerrarsesion;
            salirBtn.Location = new Point(731, 27);
            salirBtn.Name = "salirBtn";
            salirBtn.Size = new Size(55, 55);
            salirBtn.TabIndex = 11;
            salirBtn.UseVisualStyleBackColor = true;
            salirBtn.Click += salirBtn_Click;
            // 
            // buscarBtn
            // 
            buscarBtn.Cursor = Cursors.Hand;
            buscarBtn.Location = new Point(226, 112);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(80, 25);
            buscarBtn.TabIndex = 12;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = true;
            buscarBtn.Click += buscarBtn_Click;
            // 
            // dniTxt
            // 
            dniTxt.Location = new Point(28, 112);
            dniTxt.Name = "dniTxt";
            dniTxt.Size = new Size(194, 25);
            dniTxt.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 92);
            label2.Name = "label2";
            label2.Size = new Size(138, 17);
            label2.TabIndex = 14;
            label2.Text = "Buscar cliente por DNI";
            // 
            // recargarBtn
            // 
            recargarBtn.Cursor = Cursors.Hand;
            recargarBtn.Image = Properties.Resources.rotate_right_solid__2_;
            recargarBtn.Location = new Point(487, 112);
            recargarBtn.Name = "recargarBtn";
            recargarBtn.Size = new Size(25, 25);
            recargarBtn.TabIndex = 15;
            recargarBtn.UseVisualStyleBackColor = true;
            recargarBtn.Click += recargarBtn_Click;
            // 
            // PantallaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(recargarBtn);
            Controls.Add(label2);
            Controls.Add(dniTxt);
            Controls.Add(buscarBtn);
            Controls.Add(salirBtn);
            Controls.Add(labelPic);
            Controls.Add(filtrarVencidasBtn);
            Controls.Add(renovarMembresiaBtn);
            Controls.Add(verPagosBtn);
            Controls.Add(modificarClienteBtn);
            Controls.Add(eliminarBtn);
            Controls.Add(membresiasBtn);
            Controls.Add(bienvenidoTxt);
            Controls.Add(label1);
            Controls.Add(listaClientesGrid);
            Controls.Add(registrarClienteBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PantallaAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio ~ Administrador";
            Load += PantallaAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)listaClientesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)labelPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registrarClienteBtn;
        private DataGridView listaClientesGrid;
        private Label label1;
        private Label bienvenidoTxt;
        private Button membresiasBtn;
        private Button eliminarBtn;
        private Button modificarClienteBtn;
        private Button verPagosBtn;
        private Button renovarMembresiaBtn;
        private Button filtrarVencidasBtn;
        private PictureBox labelPic;
        private Button salirBtn;
        private Button buscarBtn;
        private TextBox dniTxt;
        private Label label2;
        private Button recargarBtn;
    }
}