using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public enum TipoEmpleado
    {
        PorHoras,
        Fijo,
        Pasante
    }

    public class Empleado : Persona
    {
        public int LegajoEmpleado { get; set; }
        public TipoEmpleado TipoEmpleado { get; set; }

        public static List<Empleado> listaEmpleados = new List<Empleado>();
        public Empleado(int legajoempleado, TipoEmpleado tipoempleado, string nombre, string apellido, string email, string telefono, string direccion) : base(nombre, apellido, email, telefono, direccion)
        {
            LegajoEmpleado = legajoempleado;
            TipoEmpleado = tipoempleado;

            if (listaEmpleados.Find(x => x.LegajoEmpleado == legajoempleado) != null)
            {
                throw new Exception("Ya existe un empleado con tal número de legajo registrado en la lista, compruebe los datos nuevamente.");
            }
            else
            {
                this.Registrar();
            }

        }
        void Registrar()
        {
            listaEmpleados.Add(this);
        }
    }
}
