using MedCard.Infrastructure;
using MedCard.Infrastructure.Models;
using MedCard.Models;

using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace MedCard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> GetPersons() {
            var persons = _context.persens.Select(x => new
            {
                x.Surname,
                x.Name,
                x.Patronumic,
                x.Birthday,
                x.Phone
            }).ToList();
            return Json(persons);
        }
        [HttpPost]
        public IActionResult CreatePerson([FromBody] Persen persen)
        {
            if (persen == null)
            {
                return BadRequest("Ошибка на стороне сервера");
            }
            _context.persens.Add(persen);
            _context.SaveChanges();
            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}