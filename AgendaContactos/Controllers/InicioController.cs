using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgendaContactos.Data;
using AgendaContactos.Models;

namespace AgendaContactos.Controllers
{
    public class InicioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InicioController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index() =>
            View(await _context.Contactos.ToListAsync());

        public IActionResult Crear() => View();

        [HttpPost]
        public async Task<IActionResult> Crear(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _context.Contactos.Add(contacto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contacto);
        }

        public async Task<IActionResult> Editar(int? id) =>
            View(await _context.Contactos.FindAsync(id));

        [HttpPost]
        public async Task<IActionResult> Editar(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _context.Update(contacto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contacto);
        }

        public async Task<IActionResult> Borrar(int? id) =>
            View(await _context.Contactos.FindAsync(id));

        [HttpPost, ActionName("Borrar")]
        public async Task<IActionResult> BorrarConfirmado(int id)
        {
            var contacto = await _context.Contactos.FindAsync(id);
            _context.Contactos.Remove(contacto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
