using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Back;
using Microsoft.IdentityModel.Tokens;

namespace Front.Administrador
{
    public partial class AutenticacionAdmin : Form
    {
        Principal principal;
        public AutenticacionAdmin()
        {
            principal = new Principal();
            InitializeComponent();

        }

        private void iniciarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var admin = principal.autenticacionAdmin(usuarioTxt.Text, contraseñaTxt.Text);
                PantallaAdmin pantallaAdmin = new PantallaAdmin(admin.Nombre);  
                pantallaAdmin.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            registrarAdmin registrarAdmin = new registrarAdmin();
            registrarAdmin.Show();
            this.Close();
        }

        private void atrasBtn_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void mostrarCheck_CheckedChanged(object sender, EventArgs e)
        {
            contraseñaTxt.UseSystemPasswordChar = !contraseñaTxt.UseSystemPasswordChar;
        }

    }
}
