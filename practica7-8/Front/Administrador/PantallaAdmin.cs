using Back;
using Back.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Administrador
{
    public partial class PantallaAdmin : Form
    {
        Principal principal;
        public PantallaAdmin(string? nombreAdmin = null)
        {
            principal = new Principal();
            InitializeComponent();
            labelPic.SendToBack();
            if (nombreAdmin != null)
            {
                bienvenidoTxt.Text = $"Bienvenido, {nombreAdmin}!";
            }

            listaClientesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            listaClientesGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

        }
        void seleccionarPrimerFila()
        {
            if (listaClientesGrid.Rows.Count > 0)
            {
                listaClientesGrid.Rows[0].Selected = true;
            }
        }
        void cargarLista()
        {
            principal = new Principal();
            listaClientesGrid.DataSource = principal.returnListaClientes();
            listaClientesGrid.Refresh();
            listaClientesGrid.Columns["Id"].HeaderText = "ID de cliente";
            listaClientesGrid.Columns["Dni"].HeaderText = "DNI";
            listaClientesGrid.Columns["Nombre"].HeaderText = "Nombre completo";
            listaClientesGrid.Columns["Telefono"].HeaderText = "Número de teléfono";
            listaClientesGrid.Columns["idMembresiaActual"].HeaderText = "ID de membresía";
            listaClientesGrid.Columns["VencimientoMembresia"].HeaderText = "Vencimiento de membresía";
            seleccionarPrimerFila();
        }
        private void PantallaAdmin_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void membresiasBtn_Click(object sender, EventArgs e)
        {
            Membresias pantallaMembresias = new Membresias();
            pantallaMembresias.ShowDialog();

        }
        private void registrarClienteBtn_Click(object sender, EventArgs e)
        {
            RegistrarCliente pantallaRegistrarCliente = new RegistrarCliente();
            pantallaRegistrarCliente.ShowDialog();
            cargarLista();
        }

        private void listaClientesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                listaClientesGrid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (listaClientesGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = listaClientesGrid.SelectedRows[0];
                int idSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                try
                {
                    DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar el cliente seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmacion == DialogResult.Yes)
                    {
                        principal.eliminarCliente(idSeleccionado);
                        MessageBox.Show("Cliente eliminado con exito.");
                        cargarLista();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int dniBuscado;

                if (!int.TryParse(dniTxt.Text, out dniBuscado) || dniTxt.Text.Length != 8)
                {
                    throw new Exception("DNI Invalido.");
                }

                listaClientesGrid.DataSource = principal.returnListaClientes().Where(x => x.Dni == dniBuscado).ToList();
                seleccionarPrimerFila();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filtrarVencidasBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listaClientesGrid.DataSource = principal.returnListaClientes().Where(x => x.VencimientoMembresia < DateTime.Now).ToList();
                seleccionarPrimerFila();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void recargarBtn_Click(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void modificarClienteBtn_Click(object sender, EventArgs e)
        {
            if (listaClientesGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = listaClientesGrid.SelectedRows[0];
                int idSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                try
                {
                    modificarCliente pantallaModificarCliente = new modificarCliente(idSeleccionado);
                    pantallaModificarCliente.ShowDialog();
                    cargarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void verPagosBtn_Click(object sender, EventArgs e)
        {
            if (listaClientesGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = listaClientesGrid.SelectedRows[0];
                int clienteSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["Dni"].Value);
                try
                {
                    pagosCliente verPagoCliente = new pagosCliente(clienteSeleccionado);
                    verPagoCliente.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void renovarMembresiaBtn_Click(object sender, EventArgs e)
        {
            if (listaClientesGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = listaClientesGrid.SelectedRows[0];
                int DniCliente = Convert.ToInt32(filaSeleccionada.Cells["Dni"].Value);
                try
                {
                    registrarPago pantallaRegistrarPago = new registrarPago(DniCliente);
                    pantallaRegistrarPago.ShowDialog();
                    cargarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
