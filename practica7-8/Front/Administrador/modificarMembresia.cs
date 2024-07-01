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
    public partial class modificarMembresia : Form
    {
        Principal principal;
        Membresia seleccion;
        public modificarMembresia(int idSel)
        {
            principal = new Principal();
            InitializeComponent();
            membresiasCMB.DataSource = principal.returnListaMembresia();
            membresiasCMB.DisplayMember = "Id";
            SeleccionarMembresiaPorID(idSel);
        }

        private void SeleccionarMembresiaPorID(int id)
        {
            foreach (var item in membresiasCMB.Items)
            {
                Membresia membresia = item as Membresia;
                if (membresia != null && membresia.Id == id)
                {
                    membresiasCMB.SelectedItem = membresia;
                    break;
                }
            }
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int cantMeses;
                double precio;

                if (!int.TryParse(cantMesesTxt.Text, out cantMeses))
                {
                    throw new Exception("Cantidad de meses invalida, verifique que sea un número entero.");
                }

                if (!double.TryParse(precioTxt.Text, out precio))
                {
                    throw new Exception("Precio invalido, verifique que sea un número.");
                }

                principal.modificarMembresia(seleccion.Id, descripcionTxt.Text, cantMeses, precio);
                MessageBox.Show("Membresía modificada con exito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void membresiasCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (membresiasCMB.SelectedItem != null)
            {
                seleccion = (Membresia)membresiasCMB.SelectedItem;
                descripcionTxt.Text = seleccion.Descripcion;
                cantMesesTxt.Text = seleccion.CantidadMeses.ToString();
                precioTxt.Text = seleccion.Monto.ToString();
            }

        }
    }
}
