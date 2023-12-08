using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppLocalSIS2420.Context;
using WebAppLocalSIS2420.Models;

namespace WebAppLocalSIS2420.Controllers
{
    public class AmbientesController : Controller
    {
        private readonly MiContext _context;

        public AmbientesController(MiContext context)
        {
            _context = context;
        }

        // GET: Ambientes
        public async Task<IActionResult> Index()
        {
              return _context.Ambientes != null ? 
                          View(await _context.Ambientes.ToListAsync()) :
                          Problem("Entity set 'MiContext.Ambientes'  is null.");
        }

        // GET: Ambientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ambientes == null)
            {
                return NotFound();
            }

            var ambientes = await _context.Ambientes
                .FirstOrDefaultAsync(m => m.IdAmbiente == id);
            if (ambientes == null)
            {
                return NotFound();
            }

            return View(ambientes);
        }

        // GET: Ambientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ambientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAmbiente,Fotos,NombreAmbiente,Direccion,Zona,Capacidad,Tarima,Estado,Precio")] Ambientes ambientes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ambientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ambientes);
        }

        // GET: Ambientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ambientes == null)
            {
                return NotFound();
            }

            var ambientes = await _context.Ambientes.FindAsync(id);
            if (ambientes == null)
            {
                return NotFound();
            }
            return View(ambientes);
        }

        // POST: Ambientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAmbiente,Fotos,NombreAmbiente,Direccion,Zona,Capacidad,Tarima,Estado,Precio")] Ambientes ambientes)
        {
            if (id != ambientes.IdAmbiente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ambientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmbientesExists(ambientes.IdAmbiente))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ambientes);
        }

        // GET: Ambientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ambientes == null)
            {
                return NotFound();
            }

            var ambientes = await _context.Ambientes
                .FirstOrDefaultAsync(m => m.IdAmbiente == id);
            if (ambientes == null)
            {
                return NotFound();
            }

            return View(ambientes);
        }

        // POST: Ambientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ambientes == null)
            {
                return Problem("Entity set 'MiContext.Ambientes'  is null.");
            }
            var ambientes = await _context.Ambientes.FindAsync(id);
            if (ambientes != null)
            {
                _context.Ambientes.Remove(ambientes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AmbientesExists(int id)
        {
          return (_context.Ambientes?.Any(e => e.IdAmbiente == id)).GetValueOrDefault();
        }
    }
}
