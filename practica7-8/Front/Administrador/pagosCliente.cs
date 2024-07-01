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

namespace Front.Administrador
{
    public partial class pagosCliente : Form
    {
        Principal principal;
        public pagosCliente(int dniCliente)
        {
            principal = new Principal();
            InitializeComponent();
            listaPagos.DataSource = principal.returnListaPagosCliente(dniCliente);
        }

        private void atrasBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
