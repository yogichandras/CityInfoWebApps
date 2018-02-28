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
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CityInfo.Web.Mvc.Controllers
{
    [AbpMvcAuthorize]
    public class GalleriesController : AbpController
    {
        private readonly Solution _context;

        public GalleriesController(Solution context)
        {
            _context = context;
        }

        // GET: Galleries
        public async Task<IActionResult> Index()
        {
            var solution = _context.Gallery.Include(g => g.MasterKategori).Include(g => g.MasterTempat);
            return View(await solution.ToListAsync());
        }

        // GET: Galleries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gallery = await _context.Gallery
                .Include(g => g.MasterKategori)
                .Include(g => g.MasterTempat)
                .SingleOrDefaultAsync(m => m.id == id);
            if (gallery == null)
            {
                return NotFound();
            }

            return View(gallery);
        }

        // GET: Galleries/Create
        public IActionResult Create()
        {
            ViewData["id_kategori"] = new SelectList(_context.Kategori, "id", "id");
            ViewData["id_tempat"] = new SelectList(_context.Tempat, "id", "id");
            return View();
        }

        // POST: Galleries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile file,[Bind("id,id_tempat,id_kategori,image")] Gallery gallery)
        {
            var uploads = Path.Combine("images");
            if (ModelState.IsValid)
            {
                if (file.Length > 0)
                {
                    using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                    await file.CopyToAsync(fileStream);
                    _context.Add(gallery);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewData["id_kategori"] = new SelectList(_context.Kategori, "id", "id", gallery.id_kategori);
            ViewData["id_tempat"] = new SelectList(_context.Tempat, "id", "id", gallery.id_tempat);
            return View(gallery);
        }

        // GET: Galleries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gallery = await _context.Gallery.SingleOrDefaultAsync(m => m.id == id);
            if (gallery == null)
            {
                return NotFound();
            }
            ViewData["id_kategori"] = new SelectList(_context.Kategori, "id", "id", gallery.id_kategori);
            ViewData["id_tempat"] = new SelectList(_context.Tempat, "id", "id", gallery.id_tempat);
            return View(gallery);
        }

        // POST: Galleries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,id_tempat,id_kategori,image")] Gallery gallery)
        {
            if (id != gallery.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gallery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GalleryExists(gallery.id))
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
            ViewData["id_kategori"] = new SelectList(_context.Kategori, "id", "id", gallery.id_kategori);
            ViewData["id_tempat"] = new SelectList(_context.Tempat, "id", "id", gallery.id_tempat);
            return View(gallery);
        }

        // GET: Galleries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gallery = await _context.Gallery
                .Include(g => g.MasterKategori)
                .Include(g => g.MasterTempat)
                .SingleOrDefaultAsync(m => m.id == id);
            if (gallery == null)
            {
                return NotFound();
            }

            return View(gallery);
        }

        // POST: Galleries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gallery = await _context.Gallery.SingleOrDefaultAsync(m => m.id == id);
            _context.Gallery.Remove(gallery);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GalleryExists(int id)
        {
            return _context.Gallery.Any(e => e.id == id);
        }
    }
}
