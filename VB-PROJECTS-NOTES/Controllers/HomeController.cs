using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VB_PROJECTS_NOTES.Models;
using PagedList;

namespace VB_PROJECTS_NOTES.Controllers
{
    public class HomeController : Controller
    {
        private readonly GeneralContext _context;

        private int numberPage;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public IList<Project> Projects { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int Count { get; set; }

        public int PageSize { get; set; } = 1;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public bool EnablePrevious => CurrentPage > 1;

        public bool EnableNext => CurrentPage < TotalPages;

        public HomeController(GeneralContext context)
        {
            _context = context;
      
        }

        public async Task<IActionResult> Index(string searchString,  int? pagina)

        {
            int pageSize = 3;
            numberPage = pagina ?? 1;
            var generalContext = _context.Project;

            if (!String.IsNullOrEmpty(searchString))
            {
                //generalContext = _context.Project;

                return View(generalContext.Include(p => p.Country).Include(p => p.Country.Region).Where(X => X.Name.Contains(searchString)).Where(y => y.Active == 1).ToPagedList(numberPage, pageSize));
            }
            else
            {

                return View(generalContext.Include(p => p.Country).Include(p => p.Country.Region).Where(y => y.Active == 1).ToPagedList(numberPage, pageSize));
            }


        }

        public async Task OnGetAsync()
        {
            var projects = from m in _context.Project
                           select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                projects = projects.Where(s => s.Name.Contains(SearchString));
            }

       

            Projects = await projects.ToListAsync();
        }


        public void OnGet(int currentPage)
        {
            CurrentPage = currentPage == 0 ? 1 : currentPage;

            Count = _context.Project.Count();

            if (CurrentPage > TotalPages)
                CurrentPage = TotalPages;

            Projects = _context.Project
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CountryId")] Project project)
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


        private bool ProjectExists(int id)
        {
            return _context.Project.Any(e => e.Id == id);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
