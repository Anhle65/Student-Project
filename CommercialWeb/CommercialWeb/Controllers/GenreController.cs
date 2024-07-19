using CommercialWeb.Data;
using CommercialWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CommercialWeb.Controllers
{
    public class GenreController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GenreController(ApplicationDbContext context)
        {
            _context = context;
        }
        /*protected override void Dispose(bool disposing)
        {
           
        */
        public IActionResult Index()
        {
            var genres = _context.Information.ToList();
            return View(genres);
        }
        public IActionResult UpSert(byte id)
        {
            var category = _context.Information.FirstOrDefault(a => a.FoodId == id);
            if (category == null)
            {
                category = new Information() { FoodId = 0};
            }
            return View(category);
        }
        public async Task<IActionResult> Edit(string type)
        {
            var information = await _context.Information.FindAsync(type);
            if (information == null)
            {
                return NotFound();
            }
            return View(information);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string type, Information inf)
        {
            if (type != inf.ProductType)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Update(inf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inf);
        }
    }
}
