using POS.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace DotNetEfCore2.Controllers
{
    public class DivisionController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DivisionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult List()
        {
            IEnumerable<DivisionEntity> divisions = _context.DivisionEntities.ToList();
            return View(divisions);
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            DivisionEntity division = _context.DivisionEntities.Find(id);
            return View(division);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("DivisionName, DivisionDescription")] DivisionEntity request)
        {
            _context.DivisionEntities.Add(request);
            _context.SaveChanges();
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.DivisionEntities.Find(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update([Bind("DivisionName, DivisionDescription")] DivisionEntity request)
        {
            _context.DivisionEntities.Update(request);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entity = _context.DivisionEntities.Find(id);
            if (entity == null)
            {
                return Redirect("List");
            }
            _context.DivisionEntities.Remove(entity);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
