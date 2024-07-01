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
    public partial class modificarCliente : Form
    {
        Principal principal;
        Membresia membresiaSeleccionada;
        int idSel;
        public modificarCliente(int idsel)
        {
            principal = new Principal();

            InitializeComponent();
            membresiasCMB.DataSource = principal.returnListaMembresia();

            idSel = idsel;
            var cliente = principal.returnListaClientes().FirstOrDefault(x => x.Id == idSel);
            dniTxt.Text = cliente.Dni.ToString();
            nombreTxt.Text = cliente.Nombre;
            telefonoTxt.Text = cliente.Telefono;

            foreach (Membresia membresia in membresiasCMB.Items)
            {
                if (membresia.Id == cliente.idMembresiaActual)
                {
                    membresiasCMB.SelectedItem = membresia;
                    break;
                }
            }

            vencimientoMembresiaPicker.Value = cliente.VencimientoMembresia;
            vencimientoMembresiaPicker.CustomFormat = "dd/MM/yyyy";
        }
        private void membresiasCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            membresiaSeleccionada = (Membresia)membresiasCMB.SelectedItem;
        }
        private void modificarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                principal.modificarCliente(idSel, nombreTxt.Text, telefonoTxt.Text, membresiaSeleccionada.Id, vencimientoMembresiaPicker.Value);
                MessageBox.Show("Cliente modificado con exito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
