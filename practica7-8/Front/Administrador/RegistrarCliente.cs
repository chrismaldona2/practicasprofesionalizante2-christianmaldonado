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
    public partial class RegistrarCliente : Form
    {
        Membresia membresiaSeleccionada;
        Principal principal;
        public RegistrarCliente()
        {
            principal = new Principal();
            InitializeComponent();
            membresiasCMB.DataSource = principal.returnListaMembresia();

        }
        private void membresiasCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            membresiaSeleccionada = (Membresia)membresiasCMB.SelectedItem;
            precioTxt.Text = $"{membresiaSeleccionada.Monto} ARS";
            vencimientoTxt.Text = $"{(DateTime.Now.AddMonths(membresiaSeleccionada.CantidadMeses).ToString("dd/MM/yyyy"))}";
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            try
            {

                int dni;
                if (!int.TryParse(dniTxt.Text, out dni))
                {
                    throw new Exception("DNI Invalido.");
                }

                if (membresiaSeleccionada == null)
                {
                    throw new Exception("Membresia seleccionada invalida.");
                }

                principal.registrarCliente(dni, nombreTxt.Text, telefonoTxt.Text, membresiaSeleccionada.Id);
                MessageBox.Show("Cliente registrado con exito.");

                dniTxt.Clear();
                nombreTxt.Clear();
                telefonoTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
