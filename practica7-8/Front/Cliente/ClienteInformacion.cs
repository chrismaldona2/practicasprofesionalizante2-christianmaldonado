using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Cliente
{
    public partial class ClienteInformacion : Form
    {
        public ClienteInformacion(string nombre, int dni, string telefono, DateTime vencimiento)
        {

            InitializeComponent();
            nombreTxt.Text = nombre;
            dniTxt.Text = dni.ToString();
            telefonoTxt.Text = telefono;
            vencimientoTxt.Text = vencimiento.ToString("dd/MM/yy");

            if (vencimiento < DateTime.Now)
            {
                vigenciaTxt.Text = "VENCIDO";
                vigenciaTxt.Location = new System.Drawing.Point(5, -2);
                vigenciaTxt.BackColor = Color.Red;
                vigenciaPanel.Width = 254;
                vigenciaPanel.BackColor = Color.Red;
                label7.Location = new System.Drawing.Point(301, 282);
                vencimientoTxt.Location = new System.Drawing.Point(284, 293);
            }

        }
    }
}
