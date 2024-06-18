using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Clientes
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string CondicionImpositiva { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public Cliente(int codigo, string nombre, string condicionimpositiva, string email, string telefono)
        {
            Codigo = codigo;
            Nombre = nombre;
            CondicionImpositiva = condicionimpositiva;
            Email = email;
            Telefono = telefono;
        }
    }
}
