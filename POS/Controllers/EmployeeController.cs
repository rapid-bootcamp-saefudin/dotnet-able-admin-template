/*using DotNetEfCore2.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace DotNetEfCore2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult List()
        {
            IEnumerable<EmployeeEntity> employees = _context.EmployeeEntities.ToList();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            EmployeeEntity employee = _context.EmployeeEntities.Find(id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("EmployeeName, EmployeeEmail, EmployeeGender, EmployeeJobPosition, EmployeeStatus")] EmployeeEntity request)
        {
            _context.EmployeeEntities.Add(request);
            _context.SaveChanges();
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.EmployeeEntities.Find(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update([Bind("EmployeeName, EmployeeEmail, EmployeeGender, EmployeeJobPosition, EmployeeStatus")] EmployeeEntity request)
        {
            _context.EmployeeEntities.Update(request);
            _context.SaveChanges();
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entity = _context.EmployeeEntities.Find(id);
            if (entity == null)
            {
                return Redirect("List");
            }
            _context.EmployeeEntities.Remove(entity);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
*/