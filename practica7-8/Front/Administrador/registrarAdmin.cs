using Back;
using Microsoft.IdentityModel.Tokens;
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
    public partial class registrarAdmin : Form
    {
        Principal principal;
        public registrarAdmin()
        {
            principal = new Principal();
            InitializeComponent();
        }

        private void atrasBtn_Click(object sender, EventArgs e)
        {
            AutenticacionAdmin autenticacionAdmin = new AutenticacionAdmin();
            autenticacionAdmin.Show();
            this.Close();
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(repetirContraseñaTxt.Text))
                {
                    throw new Exception("No pueden ingresarse valores nulos o compuestos por espacios en blanco.");
                }

                if (contraseñaTxt.Text == repetirContraseñaTxt.Text)
                {
                    principal.registrarAdmin(nombreTxt.Text, usuarioTxt.Text, contraseñaTxt.Text);
                    MessageBox.Show("Administrador registrado con exito.");
                    AutenticacionAdmin inicioSesionAdmin = new AutenticacionAdmin();
                    inicioSesionAdmin.Show();
                    this.Close();
                }
                else
                {
                    throw new Exception("Las contraseñas ingresadas no coinciden.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mostrarCheck_CheckedChanged(object sender, EventArgs e)
        {
            contraseñaTxt.UseSystemPasswordChar = !contraseñaTxt.UseSystemPasswordChar;
            repetirContraseñaTxt.UseSystemPasswordChar = !repetirContraseñaTxt.UseSystemPasswordChar;
        }
    }
}
