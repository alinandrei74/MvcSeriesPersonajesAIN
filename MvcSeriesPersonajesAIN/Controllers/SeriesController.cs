using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcSeriesPersonajesAIN.Models;
using System.Data.Entity;

namespace MvcSeriesPersonajesAIN.Controllers
{
    public class SeriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SeriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Series
        public IActionResult Index()
        {
            return View(_context.Series.ToList());
        }

        // GET: Series/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serie = _context.Series.FirstOrDefault(m => m.IdSerie == id);
            if (serie == null)
            {
                return NotFound();
            }

            return View(serie);
        }

        // GET: Series/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Series/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("IdSerie,Nombre,Imagen,Anyo")] Serie serie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serie);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(serie);
        }

        // GET: Series/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serie = _context.Series.Find(id);
            if (serie == null)
            {
                return NotFound();
            }
            return View(serie);
        }

        // POST: Series/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("IdSerie,Nombre,Imagen,Anyo")] Serie serie)
        {
            if (id != serie.IdSerie)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(serie);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(serie);
        }

        // GET: Series/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serie = _context.Series.FirstOrDefault(m => m.IdSerie == id);
            if (serie == null)
            {
                return NotFound();
            }

            return View(serie);
        }

        // POST: Series/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public
