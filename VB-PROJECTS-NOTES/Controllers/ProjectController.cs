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
    public class ProjectController : Controller
    {
        private readonly GeneralContext _context;

        private int numberPage;

        [BindProperty(SupportsGet = true)] 
        public string SearchString { get; set; }

        public IList<Project> Projects { get; set; }
        public ProjectController(GeneralContext context)
        {
            _context = context;
        }

        // GET: Project
        public async Task<IActionResult> Index(string searchString, int? pagina)
        {

            int pageSize = 3;
            numberPage = pagina ?? 1;
            var generalContext = _context.Project;
        
            if (!String.IsNullOrEmpty(searchString))
            {
                generalContext = _context.Project;
              
                return View(generalContext.Include(p => p.Country).Include(p => p.Country.Region).Where(X => X.Name.Contains(searchString)).Where(y => y.Active == 1).ToPagedList(numberPage, pageSize));
            }
            else {
               
                return View(generalContext.Include(p => p.Country).Include(p => p.Country.Region).Where(y => y.Active == 1).ToPagedList(numberPage, pageSize));
            }
        


        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

        // GET: Project/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .Include(p => p.Country)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Project/Search/Name
        public async Task<IActionResult> Search(string  searchString, int? pagina)
        {
            int pageSize = 3;
            numberPage = pagina ?? 1;
          
            var generalContext = _context.Project;
            if (!String.IsNullOrEmpty(searchString))
            {
                generalContext = _context.Project;

                return View(generalContext.Include(p => p.Country).Include(p => p.Country.Region).Where(X => X.Name.Contains(searchString)).Where(y => y.Active == 1).ToPagedList(numberPage, pageSize));
            }
            else
            {

                return View(generalContext.Include(p => p.Country).Include(p => p.Country.Region).Where(y => y.Active == 1).ToPagedList(numberPage, pageSize));
            }
        }

    

        // GET: Project/Create
        public IActionResult Create()
        {
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Name");
            return View();
        }

        // POST: Project/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CountryId, JenkisAddress, GitAddress, ProvisionGitAddress, NexusFrontEndAddress, NexusProductAddress, BiometricProductAddress, Notes")] Project project)
        {
            if (ModelState.IsValid)
            {
                project.Active = 1;
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Id", project.CountryId);
            return View(project);
        }

        // GET: Project/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Name", project.CountryId);
            return View(project);
        }

        // POST: Project/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CountryId, Description, JenkisAddress, GitAddress, ProvisionGitAddress, NexusFrontEndAddress, NexusProductAddress, BiometricProductAddress, Notes, Active")] Project project)
        {
            if (id != project.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.Id))
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
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Id", project.CountryId);
            return View(project);
        }

        // GET: Project/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .Include(p => p.Country)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Project/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.Project.FindAsync(id);
            project.Active = 0;
            _context.Update(project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
            return _context.Project.Any(e => e.Id == id);
        }
    }
}
