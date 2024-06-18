using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Clientes
{
    public class ClienteVirtual : Cliente
    {
        public string Usuario { get; set; }
        public ClienteVirtual(int codigo, string nombre, string condicionimpositiva, string email, string telefono, string usuario) : base(codigo, nombre, condicionimpositiva, email, telefono)
        {
            Usuario = usuario;
        }
    }
}
