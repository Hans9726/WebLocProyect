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
    public class AlquileresController : Controller
    {
        private readonly MiContext _context;

        public AlquileresController(MiContext context)
        {
            _context = context;
        }

        // GET: Alquileres
        public async Task<IActionResult> Index()
        {
              return _context.Alquileres != null ? 
                          View(await _context.Alquileres.ToListAsync()) :
                          Problem("Entity set 'MiContext.Alquileres'  is null.");
        }

        // GET: Alquileres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Alquileres == null)
            {
                return NotFound();
            }

            var alquileres = await _context.Alquileres
                .FirstOrDefaultAsync(m => m.IdAlquiler == id);
            if (alquileres == null)
            {
                return NotFound();
            }

            return View(alquileres);
        }

        // GET: Alquileres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alquileres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAlquiler,NombreCliente,NombreAmbAqluilar,FechaReserva,FechaAlquilar,Adelanto,Saldo,Total")] Alquileres alquileres)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alquileres);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alquileres);
        }

        // GET: Alquileres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Alquileres == null)
            {
                return NotFound();
            }

            var alquileres = await _context.Alquileres.FindAsync(id);
            if (alquileres == null)
            {
                return NotFound();
            }
            return View(alquileres);
        }

        // POST: Alquileres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAlquiler,NombreCliente,NombreAmbAqluilar,FechaReserva,FechaAlquilar,Adelanto,Saldo,Total")] Alquileres alquileres)
        {
            if (id != alquileres.IdAlquiler)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alquileres);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlquileresExists(alquileres.IdAlquiler))
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
            return View(alquileres);
        }

        // GET: Alquileres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Alquileres == null)
            {
                return NotFound();
            }

            var alquileres = await _context.Alquileres
                .FirstOrDefaultAsync(m => m.IdAlquiler == id);
            if (alquileres == null)
            {
                return NotFound();
            }

            return View(alquileres);
        }

        // POST: Alquileres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Alquileres == null)
            {
                return Problem("Entity set 'MiContext.Alquileres'  is null.");
            }
            var alquileres = await _context.Alquileres.FindAsync(id);
            if (alquileres != null)
            {
                _context.Alquileres.Remove(alquileres);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlquileresExists(int id)
        {
          return (_context.Alquileres?.Any(e => e.IdAlquiler == id)).GetValueOrDefault();
        }
    }
}
