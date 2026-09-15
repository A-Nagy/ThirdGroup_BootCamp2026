using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ThirdGroup_1.Data;
using ThirdGroup_1.Models;

namespace ThirdGroup_1.Controllers
{
    public class CategoriesController : Controller
    {

        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        { 
            List<Category> catdata = _context.Categories.ToList();

            return View(catdata);
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            Category? category = _context.Categories.Find(Id);

            return View(category);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);

        }
        [HttpGet]
        public IActionResult Update(int Id)
        {
            Category? category = _context.Categories.Find(Id);
            if (category == null)
            {
                return NotFound();//like 404 error
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);

        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Category? category = _context.Categories.Find(Id);
            if (category == null)
            {
                return NotFound();//like 404 error
            }
            return View(category);
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(string name)
        {
            if (name.IsNullOrEmpty())
            {
                return NotFound();
            }
            Category? cat = _context.Categories.FirstOrDefault(d => d.Name ==name);

            return RedirectToAction("Details", new { id = cat.Name });
         }
    }
}
