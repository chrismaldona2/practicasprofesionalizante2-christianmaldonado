using Back;
using Front.Administrador;
using Front.Cliente;
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

namespace Front
{
    public partial class Inicio : Form
    {
        Principal principal;
        public Inicio()
        {
            principal = new Principal();
            InitializeComponent();
            
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            AutenticacionAdmin inicioSesionAdmin = new AutenticacionAdmin();
            inicioSesionAdmin.Show();
            this.Hide();
        }

        private void clienteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int dni;
                if (string.IsNullOrWhiteSpace(dniTxt.Text))
                {
                    throw new Exception("No pueden ingresarse valores nulos o compuestos por espacios en blanco.");
                }

                if (!int.TryParse(dniTxt.Text, out dni))
                {
                    throw new Exception("DNI Invalido.");
                }

                var cliente = principal.returnClienteByDNI(dni);
                ClienteInformacion infoCliente = new ClienteInformacion(cliente.Nombre, cliente.Dni, cliente.Telefono, cliente.VencimientoMembresia);
                infoCliente.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
