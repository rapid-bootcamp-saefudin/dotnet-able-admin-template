using POS.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace POS.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ClientController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult List()
        {
            IEnumerable<ClientEntity> clients = _context.ClientEntities.ToList();
            return View(clients);
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            ClientEntity client = _context.ClientEntities.Find(id);
            return View(client);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("ClientName, ClientEmail, ClientGender, CompanyName")] ClientEntity request)
        {
            _context.ClientEntities.Add(request);
            _context.SaveChanges();
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.ClientEntities.Find(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update([Bind("ClientName, ClientEmail, ClientGender, CompanyName")] ClientEntity request)
        {
            _context.ClientEntities.Update(request);
            _context.SaveChanges();
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entity = _context.ClientEntities.Find(id);
            if (entity == null)
            {
                return Redirect("List");
            }
            _context.ClientEntities.Remove(entity);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
