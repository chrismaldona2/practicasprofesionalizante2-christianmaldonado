using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Proveedor : Persona
    {
        public long CUIT { get; set; }
        public static List<Proveedor> listaProveedores = new List<Proveedor>();
        public Proveedor(long cuit, string nombre, string apellido, string email, string telefono, string direccion) : base(nombre, apellido, email, telefono, direccion)
        {
            CUIT = cuit;
            if (listaProveedores.Find(x => x.CUIT == CUIT) != null)
            {
                throw new Exception("Ya existe un proveedor con tal CUIIT registrado en la lista, compruebe los datos nuevamente.");
            } else
            {
                this.Registrar();
            }
        }
        void Registrar()
        {
            listaProveedores.Add(this);
        }
    }
}
