using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CityInfo.Web.Models;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.AspNetCore.Mvc.Controllers;

namespace CityInfo.Web.Mvc.Controllers
{
    [AbpMvcAuthorize]
    public class KategoriController : AbpController
    {
        private readonly Solution _context;

        public KategoriController(Solution context)
        {
            _context = context;
        }

        // GET: Kategori
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kategori.ToListAsync());
        }

        // GET: Kategori/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var masterKategori = await _context.Kategori
                .SingleOrDefaultAsync(m => m.id == id);
            if (masterKategori == null)
            {
                return NotFound();
            }

            return View(masterKategori);
        }

        // GET: Kategori/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kategori/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,kategori")] MasterKategori masterKategori)
        {
            if (ModelState.IsValid)
            {
                _context.Add(masterKategori);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(masterKategori);
        }

        // GET: Kategori/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var masterKategori = await _context.Kategori.SingleOrDefaultAsync(m => m.id == id);
            if (masterKategori == null)
            {
                return NotFound();
            }
            return View(masterKategori);
        }

        // POST: Kategori/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,kategori")] MasterKategori masterKategori)
        {
            if (id != masterKategori.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(masterKategori);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MasterKategoriExists(masterKategori.id))
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
            return View(masterKategori);
        }

        // GET: Kategori/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var masterKategori = await _context.Kategori
                .SingleOrDefaultAsync(m => m.id == id);
            if (masterKategori == null)
            {
                return NotFound();
            }

            return View(masterKategori);
        }

        // POST: Kategori/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var masterKategori = await _context.Kategori.SingleOrDefaultAsync(m => m.id == id);
            _context.Kategori.Remove(masterKategori);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MasterKategoriExists(int id)
        {
            return _context.Kategori.Any(e => e.id == id);
        }
    }
}
