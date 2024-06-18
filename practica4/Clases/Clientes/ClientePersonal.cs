using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Clientes
{
    public class ClientePersonal : Cliente
    {
        public string Direccion { get; set; }
        public ClientePersonal(int codigo, string nombre, string condicionimpositiva, string email, string telefono, string direccion) : base(codigo, nombre, condicionimpositiva, email, telefono)
        {
            Direccion = direccion;
        }
    }
}
