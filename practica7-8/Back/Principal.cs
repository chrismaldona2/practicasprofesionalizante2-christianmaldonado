using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Json;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Back
{
    
    public class Principal
    {
        private readonly ApplicationDbContext _context;
        public Principal(ApplicationDbContext? context = null)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer("server=DESKTOP-1GAL31E\\SQLEXPRESS; database=GimnasioBD; trusted_connection=true; Encrypt=false; Connection Timeout=60;").Options;

            _context = context ?? new ApplicationDbContext(options);
        }


        void comprobarDatosIncompletos(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new Exception("No pueden ingresarse valores nulos o compuestos por espacios en blanco.");
            }
        }
        void comprobarDni(int dni)
        {
            if (dni.ToString().Length != 8)
            {
                throw new Exception("DNI Invalido.");
            }
        }
        //cliente
        public Cliente returnClienteByDNI(int dni)
        {
            try
            {
                comprobarDatosIncompletos(dni.ToString());
                comprobarDni(dni);

                var cliente = _context.Clientes.FirstOrDefault(c => c.Dni == dni);
                if (cliente != null)
                {
                    return cliente;
                }
                else
                {
                    throw new Exception("Cliente no encontrado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Cliente> returnListaClientes()
        {
            return _context.Clientes.ToList();
        }
        public void registrarCliente(int dni, string nombre, string telefono, int idMembresia)
        {
            try
            {
                string[] datos = {dni.ToString(), nombre.ToString(), telefono.ToString(), idMembresia.ToString()};
                foreach (var x in datos)
                {
                    comprobarDatosIncompletos(x);
                }
                comprobarDni(dni);

                if (_context.Clientes.FirstOrDefault(c => c.Dni == dni) == null)
                {
                    var membresia = _context.Membresias.FirstOrDefault(x => x.Id == idMembresia);
                    DateTime vencimiento = DateTime.Now.AddMonths(membresia.CantidadMeses);
                    if (membresia != null)
                    {
                        _context.Clientes.Add(new Cliente
                        {
                            Dni = dni,
                            Nombre = nombre,
                            Telefono = telefono,
                            idMembresiaActual = idMembresia,
                            VencimientoMembresia = vencimiento
                        });
                        _context.SaveChanges();

                        registrarPago(dni, idMembresia, vencimiento);
                        _context.SaveChanges();
                    } else
                    {
                        throw new Exception("Membresia no encontrada.");
                    }
                }
                else
                {
                    throw new Exception("Ya hay un cliente registrado con el DNI ingresado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void modificarCliente(int idModificar, string? nombre = null, string? telefono = null, int? idMembresia = null, DateTime? vencimientoMembresia = null)
        {
            try
            {
                var clienteModificar = _context.Clientes.Find(idModificar);
                clienteModificar.Nombre = nombre ?? clienteModificar.Nombre;
                clienteModificar.Telefono = telefono ?? clienteModificar.Telefono;
                clienteModificar.idMembresiaActual = idMembresia ?? clienteModificar.idMembresiaActual;
                clienteModificar.VencimientoMembresia = vencimientoMembresia ?? clienteModificar.VencimientoMembresia;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void eliminarCliente(int idEliminar)
        {
            try
            {
                _context.Clientes.Remove(_context.Clientes.Find(idEliminar));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //admin

        public void registrarAdmin(string nombre, string usuario, string contraseña)
        {
            try
            {
                string[] datos = { nombre, usuario, contraseña };
                foreach (var x in datos)
                {
                    comprobarDatosIncompletos(x);
                }

                var usuarioExistente = _context.Administradores.FirstOrDefault(a => a.Usuario == usuario);

                if (usuarioExistente == null)
                {
                    _context.Administradores.Add(new Administrador
                    {
                        Usuario = usuario,
                        Contraseña = contraseña,
                        Nombre = nombre
                    });
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("El nombre de usuario ya se encuentra en uso.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Administrador autenticacionAdmin(string usuario, string contraseña)
        {
            try
            {
                string[] datos = { usuario, contraseña };
                foreach (var x in datos)
                {
                    comprobarDatosIncompletos(x);
                }

                var admin = _context.Administradores.FirstOrDefault(a => a.Usuario == usuario && a.Contraseña == contraseña);

                if (admin != null)
                {
                    return admin;
                }
                else
                {
                    throw new Exception("Usuario y/o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //membresia

        public List<Membresia> returnListaMembresia()
        {
            return _context.Membresias.ToList();
        }
       
        public void añadirTipoMembresia(string descripcion, int cantMeses, double monto)
        {
            try
            {
                string[] datos = { descripcion, cantMeses.ToString(), monto.ToString() };
                foreach (var x in datos)
                {
                    comprobarDatosIncompletos(x);
                }

                if (cantMeses <= 0)
                {
                    throw new Exception("La cantidad de meses no puede ser menor o igual a 0.");
                }
                else if (monto < 0)
                {
                    throw new Exception("El precio no puede ser menor a 0.");
                }

                _context.Membresias.Add(new Membresia
                {
                    Descripcion = descripcion,
                    CantidadMeses = cantMeses,
                    Monto = monto
                });
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void modificarMembresia(int idModificar, string? descripcion = null, int? cantMeses = null, double? monto = null)
        {
            try
            {
                var membresiaModificar = _context.Membresias.Find(idModificar);
                int cantMesesMod = cantMeses ?? membresiaModificar.CantidadMeses;
                double montoMod = monto ?? membresiaModificar.Monto;
                descripcion = descripcion ?? membresiaModificar.Descripcion;

                if (cantMesesMod <= 0)
                {
                    throw new Exception("La cantidad de meses no puede ser menor o igual a 0.");
                }
                else if (montoMod < 0)
                {
                    throw new Exception("El precio no puede ser menor a 0.");
                }
                membresiaModificar.Descripcion = descripcion;
                membresiaModificar.CantidadMeses = cantMesesMod;
                membresiaModificar.Monto = montoMod;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void eliminarMembresia(int id)
        {
            try
            {
                _context.Membresias.Remove(_context.Membresias.Find(id));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //pago
        public void registrarPago(int dniCliente, int idMembresia, DateTime? fechaVencimentoNueva = null)
        {
            try
            {
                string[] datos = { dniCliente.ToString(), idMembresia.ToString()};

                foreach (var x in datos)
                {
                    comprobarDatosIncompletos(x);
                }

                var cliente = returnClienteByDNI(dniCliente);

                var membresia = _context.Membresias.FirstOrDefault(x => x.Id == idMembresia);

                DateTime fechaPago = DateTime.Now;

                if (fechaVencimentoNueva == null)
                {
                    if (cliente.VencimientoMembresia < fechaPago)
                    {
                        _context.Clientes.Find(cliente.Id).VencimientoMembresia = fechaPago.AddMonths(membresia.CantidadMeses);
                    }
                    else
                    {
                        _context.Clientes.Find(cliente.Id).VencimientoMembresia = cliente.VencimientoMembresia.AddMonths(membresia.CantidadMeses);
                    }
                }
                else
                {
                    _context.Clientes.Find(cliente.Id).VencimientoMembresia = fechaVencimentoNueva.Value;
                }

                _context.Pagos.Add(new Pago()
                {
                    IdMembresia = idMembresia,
                    DniCliente = dniCliente,
                    FechaPago = fechaPago,
                    Monto = membresia.Monto
                });
                
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pago> returnListaPagosCliente(int dni)
        {
            try
            {
                var cliente = returnClienteByDNI(dni);
                return _context.Pagos.Where(x => x.DniCliente == cliente.Dni).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
