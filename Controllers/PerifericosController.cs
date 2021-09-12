using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChamadosTI.Models.Modelo;

namespace GestaoT.I.Controllers
{

    public class PerifericosController : Controller
    {
        private readonly Contexto _context;

        public PerifericosController(Contexto context)
        {
            _context = context;
        }

        // GET: Perifericos
        public async Task<IActionResult> Index()
        {
            return View(await _context.perifericosContext.ToListAsync());
        }

        // GET: Perifericos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perifericos = await _context.perifericosContext
                .FirstOrDefaultAsync(m => m.id == id);
            if (perifericos == null)
            {
                return NotFound();
            }

            return View(perifericos);
        }

        // GET: Perifericos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Perifericos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nomePerifericos,especificacaoPerifericos,quantidadePerifericos")] Perifericos perifericos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(perifericos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(perifericos);
        }

        // GET: Perifericos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perifericos = await _context.perifericosContext.FindAsync(id);
            if (perifericos == null)
            {
                return NotFound();
            }
            return View(perifericos);
        }

        // POST: Perifericos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nomePerifericos,especificacaoPerifericos,quantidadePerifericos")] Perifericos perifericos)
        {
            if (id != perifericos.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(perifericos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerifericosExists(perifericos.id))
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
            return View(perifericos);
        }

        // GET: Perifericos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perifericos = await _context.perifericosContext
                .FirstOrDefaultAsync(m => m.id == id);
            if (perifericos == null)
            {
                return NotFound();
            }

            return View(perifericos);
        }

        // POST: Perifericos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var perifericos = await _context.perifericosContext.FindAsync(id);
            _context.perifericosContext.Remove(perifericos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerifericosExists(int id)
        {
            return _context.perifericosContext.Any(e => e.id == id);
        }
    }
}
