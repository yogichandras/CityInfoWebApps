using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CityInfo.Web.Models;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CityInfo.Web.Mvc.Controllers
{
    [AbpMvcAuthorize]
    public class TempatController : AbpController
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly Solution _context;

        public TempatController(Solution context,IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            var uploads = _hostingEnvironment.WebRootPath + "\\upload\\";
            if (file.Length > 0)
                using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                   await file.CopyToAsync(fileStream);

            return RedirectToAction("Create");
        }

        // GET: Tempat
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tempat.ToListAsync());
        }

        // GET: Tempat/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var masterTempat = await _context.Tempat
                .SingleOrDefaultAsync(m => m.id == id);
            if (masterTempat == null)
            {
                return NotFound();
            }

            return View(masterTempat);
        }

        // GET: Tempat/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tempat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,title,createdate,picture,idKategori")] MasterTempat masterTempat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(masterTempat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(masterTempat);
        }

       

        // GET: Tempat/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var masterTempat = await _context.Tempat.SingleOrDefaultAsync(m => m.id == id);
            if (masterTempat == null)
            {
                return NotFound();
            }
            return View(masterTempat);
        }

        // POST: Tempat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,title,createdate,picture,idKategori")] MasterTempat masterTempat)
        {
            if (id != masterTempat.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(masterTempat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MasterTempatExists(masterTempat.id))
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
            return View(masterTempat);
        }

        // GET: Tempat/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var masterTempat = await _context.Tempat
                .SingleOrDefaultAsync(m => m.id == id);
            if (masterTempat == null)
            {
                return NotFound();
            }

            return View(masterTempat);
        }

        // POST: Tempat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var masterTempat = await _context.Tempat.SingleOrDefaultAsync(m => m.id == id);
            _context.Tempat.Remove(masterTempat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MasterTempatExists(int id)
        {
            return _context.Tempat.Any(e => e.id == id);
        }
    }
}
