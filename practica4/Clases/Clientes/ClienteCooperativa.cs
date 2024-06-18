﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Clientes
{
    public class ClienteCooperativa : Cliente
    {
        public long CUIT { get; set; }
        public ClienteCooperativa(int codigo, long cuit, string nombre, string condicionimpositiva, string email, string telefono) : base(codigo, nombre, condicionimpositiva, email, telefono)
        {
            CUIT = cuit;
        }
    }
}
