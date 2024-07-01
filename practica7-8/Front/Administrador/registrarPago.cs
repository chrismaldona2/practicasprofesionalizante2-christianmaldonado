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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Front.Administrador
{
    public partial class registrarPago : Form
    {
        Principal principal;
        Membresia membresiaSeleccionada;

        DateTime vencimientoMembresia;
        void mostrarVencimiento()
        {
            if (vencimientoMembresia < DateTime.Now)
            {
                vencimientoTxt.Text = $"{(DateTime.Today.AddMonths(membresiaSeleccionada.CantidadMeses).ToString("dd/MM/yyyy"))}";
            }
            else
            {
                vencimientoTxt.Text = $"{(vencimientoMembresia.AddMonths(membresiaSeleccionada.CantidadMeses).ToString("dd/MM/yyyy"))}";
            }
        }
        public registrarPago(int dni)
        {
            principal = new Principal();

            var cliente = principal.returnListaClientes().FirstOrDefault(x => x.Dni == dni);
            InitializeComponent();

            membresiasCMB.DataSource = principal.returnListaMembresia();
            dniTxt.Text = cliente.Dni.ToString();
            nombreTxt.Text = cliente.Nombre;
            vencimientoMembresia = cliente.VencimientoMembresia;

            foreach (Membresia membresia in membresiasCMB.Items)
            {
                if (membresia.Id == cliente.idMembresiaActual)
                {
                    membresiasCMB.SelectedItem = membresia;
                    break;
                }
            }

            
            mostrarVencimiento();
        }
        private void membresiasCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            membresiaSeleccionada = (Membresia)membresiasCMB.SelectedItem;
            precioTxt.Text = $"{membresiaSeleccionada.Monto} ARS";
            mostrarVencimiento();
        }
        private void pagarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (membresiaSeleccionada == null)
                {
                    throw new Exception("Membresia seleccionada invalida.");
                }

                principal.registrarPago(int.Parse(dniTxt.Text), membresiaSeleccionada.Id);
                MessageBox.Show("Pago registrado con exito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
