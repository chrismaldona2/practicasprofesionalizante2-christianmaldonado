using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public enum TipoVehiculo
    {
        Moto,
        Bici,
        Auto
    }

    public class Repartidor : Persona
    {
        public TipoVehiculo TipoVehiculo { get; set; }
        public static List<Repartidor> listaRepartidores = new List<Repartidor>();
        public Repartidor(string nombre, string apellido, string email, string telefono, string direccion, TipoVehiculo tipoVehiculo) : base(nombre, apellido, email, telefono, direccion)
        {
            TipoVehiculo = tipoVehiculo;
            this.Registrar();
        }
        void Registrar()
        {
            listaRepartidores.Add(this);
        }
    }
}
