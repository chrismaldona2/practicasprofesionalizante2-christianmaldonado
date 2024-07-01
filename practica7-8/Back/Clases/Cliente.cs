using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Cliente
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public int idMembresiaActual {  get; set; }
        public DateTime VencimientoMembresia { get; set; }
    }
}
