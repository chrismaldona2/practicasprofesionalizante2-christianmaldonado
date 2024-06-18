using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente : Persona
    {
        public int CodigoCliente { get; set; }
        public static List<Cliente> listaClientes = new List<Cliente>();
        public Cliente (string nombre, string apellido, string email, string telefono, string direccion) : base(nombre, apellido, email, telefono, direccion)
        {
            CodigoCliente = listaClientes.Count();
            this.Registrar();
        }
        void Registrar()
        {
            listaClientes.Add(this);
        }
    }
}
