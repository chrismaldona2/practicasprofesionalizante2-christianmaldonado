using Back;
using Back.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Administrador
{
    public partial class Membresias : Form
    {
        Principal principal;
        public Membresias()
        {
            principal = new Principal();
            InitializeComponent();
            listaMembresiasGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void listaMembresiasGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                listaMembresiasGrid.Rows[e.RowIndex].Selected = true;
            }
        }
        void cargarLista()
        {
            principal = new Principal();
            listaMembresiasGrid.DataSource = principal.returnListaMembresia();
            listaMembresiasGrid.Refresh();

            listaMembresiasGrid.Columns["Id"].HeaderText = "Id";
            listaMembresiasGrid.Columns["Descripcion"].HeaderText = "Descripción";
            listaMembresiasGrid.Columns["CantidadMeses"].HeaderText = "Cantidad de meses";
            listaMembresiasGrid.Columns["Monto"].HeaderText = "Precio (ARS)";

            if (listaMembresiasGrid.Rows.Count > 0)
            {
                listaMembresiasGrid.Rows[0].Selected = true;

            }
        }
        private void Membresias_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void atrasBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void crearBtn_Click(object sender, EventArgs e)
        {
            crearMembresia pantallaCrearMembresia = new crearMembresia();
            pantallaCrearMembresia.ShowDialog();
            cargarLista();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (listaMembresiasGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = listaMembresiasGrid.SelectedRows[0];
                int idSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                try
                {
                    DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar la membresía seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmacion == DialogResult.Yes)
                    {
                        principal.eliminarMembresia(idSeleccionado);
                        MessageBox.Show("Membresía eliminada con exito.");
                        cargarLista();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (listaMembresiasGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = listaMembresiasGrid.SelectedRows[0];
                int idSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                modificarMembresia pantallaModificar = new modificarMembresia(idSeleccionado);
                pantallaModificar.ShowDialog();
                cargarLista();
            }
        }

    }
}
