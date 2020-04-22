using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VB_PROJECTS_NOTES.Models;
using PagedList;

namespace VB_PROJECTS_NOTES.Controllers
{
    public class RegionController : Controller
    {
        private readonly GeneralContext _context;

        private int numberPage;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public RegionController(GeneralContext context)
        {
            _context = context;
        }

        // GET: Region
        public async Task<IActionResult> Index(string searchString,  int? pagina)
        {
            int pageSize = 3;
            numberPage = pagina ?? 1;
            var generalContext = _context.Region;

            if (!String.IsNullOrEmpty(searchString))
            {             
                return View(generalContext.Where(X => X.Name.Contains(searchString)).Where(y => y.Active == 1).ToPagedList(numberPage, pageSize));
            }
            else
            {
                return View(generalContext.Where(y => y.Active == 1).ToPagedList(numberPage, pageSize));
            }
            
        }

        // GET: Region/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Region = await _context.Region
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Region == null)
            {
                return NotFound();
            }

            return View(Region);
        }

        // GET: Region/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Region/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Region Region)
        {
            if (ModelState.IsValid)
            {
                Region.Active = 1;
                _context.Add(Region);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Region);
        }

        // GET: Region/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Region = await _context.Region.FindAsync(id);
            if (Region == null)
            {
                return NotFound();
            }
            return View(Region);
        }

        // POST: Region/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name, Active")] Region Region)
        {
            if (id != Region.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Region);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegionExists(Region.Id))
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
            return View(Region);
        }

        // GET: Region/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Region = await _context.Region
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Region == null)
            {
                return NotFound();
            }

            return View(Region);
        }

        // POST: Region/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Region = await _context.Region.FindAsync(id);
            Region.Active = 0;
            _context.Update(Region);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegionExists(int id)
        {
            return _context.Region.Any(e => e.Id == id);
        }
    }
}
