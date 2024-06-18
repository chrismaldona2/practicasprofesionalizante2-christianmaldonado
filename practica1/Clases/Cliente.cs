using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public Cliente(int dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }
    }
}
