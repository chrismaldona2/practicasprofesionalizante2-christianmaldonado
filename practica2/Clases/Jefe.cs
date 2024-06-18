using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Jefe : Persona
    {
        public string NombreSeccion { get; set; }
        public static List<Jefe> listaJefes = new List<Jefe>();
        public Jefe(string nombreseccion, string nombre, string apellido, string email, string telefono, string direccion) : base(nombre, apellido, email, telefono, direccion)
        {
            NombreSeccion = nombreseccion;
            this.Registrar();
        }
        void Registrar()
        {
            listaJefes.Add(this);
        }
    }
}
