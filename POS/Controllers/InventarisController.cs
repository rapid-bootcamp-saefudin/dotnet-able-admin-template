/*using DotNetEfCore2.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace DotNetEfCore2.Controllers
{
    public class InventarisController : Controller
    {
        private readonly ApplicationDbContext _context;
        public InventarisController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult List()
        {
            IEnumerable<InventarisEntity> inventariss = _context.InventarisEntities.ToList();
            return View(inventariss);
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            InventarisEntity inventaris = _context.InventarisEntities.Find(id);
            return View(inventaris);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("InventarisProductName, InventarisCategory, InventarisBrand, InventarisStock")] InventarisEntity request)
        {
            _context.InventarisEntities.Add(request);
            _context.SaveChanges();
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.InventarisEntities.Find(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update([Bind("InventarisProductName, InventarisCategory, InventarisBrand, InventarisStock")] InventarisEntity request)
        {
            _context.InventarisEntities.Update(request);
            _context.SaveChanges();
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entity = _context.InventarisEntities.Find(id);
            if (entity == null)
            {
                return Redirect("List");
            }
            _context.InventarisEntities.Remove(entity);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
*/