using POS.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace POS.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<CategoryEntity> categories = _context.CategoryEntities.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            CategoryEntity category = _context.CategoryEntities.Find(id);
            return View(category);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("CategoryCode, CategoryName, CategoryDescription")] CategoryEntity request)
        {
            _context.CategoryEntities.Add(request);
            _context.SaveChanges();
            //return RedirectToAction("GetAll");
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.CategoryEntities.Find(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update(int id, [Bind("CategoryCode, CategoryName, CategoryDescription")] CategoryEntity request)
        {
            _context.CategoryEntities.Update(request);
            _context.SaveChanges();
            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entity = _context.CategoryEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
            _context.CategoryEntities.Remove(entity);
            _context.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}
