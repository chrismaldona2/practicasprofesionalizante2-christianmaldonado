using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/admins")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<int>> crearAdmin(AdministradorDTO adminDTO)
        {
            Administrador adminNuevo = new Administrador
            {
                Nombre = adminDTO.Nombre,
                Usuario = adminDTO.Usuario,
                Contraseña = adminDTO.Contraseña
            };

            _context.Administradores.Add(adminNuevo);
            await _context.SaveChangesAsync();

            return adminNuevo.Id;
        }
    }
}
