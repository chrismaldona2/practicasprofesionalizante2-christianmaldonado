using Back;
using Back.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Administrador
{
    public partial class crearMembresia : Form
    {
        Principal principal;
        public crearMembresia()
        {
            principal = new Principal();
            InitializeComponent();
        }

        private void crearBtn_Click(object sender, EventArgs e)
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

                principal.añadirTipoMembresia(descripcionTxt.Text, cantMeses, precio);
                MessageBox.Show("Tipo de membresía añadido con exito.");
                descripcionTxt.Clear();
                cantMesesTxt.Clear();
                precioTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
