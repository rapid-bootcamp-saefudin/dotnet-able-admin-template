/*using DotNetEfCore2.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace DotNetEfCore2.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult List()
        {
            IEnumerable<ProductEntity> products = _context.ProductEntities.ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            ProductEntity product = _context.ProductEntities.Find(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("ProductName, ProductCategory, ProductPrice")] ProductEntity request)
        {
            _context.ProductEntities.Add(request);
            _context.SaveChanges();
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.ProductEntities.Find(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update([Bind("ProductName, ProductCategory, ProductPrice")] ProductEntity request)
        {
            _context.ProductEntities.Update(request);
            _context.SaveChanges();
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entity = _context.ProductEntities.Find(id);
            if (entity == null)
            {
                return Redirect("List");
            }
            _context.ProductEntities.Remove(entity);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
*/