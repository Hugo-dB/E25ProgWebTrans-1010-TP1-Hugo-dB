using JuliePro.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace JuliePro.Controllers
{
    public class StatsController : Controller
    {
        private readonly JulieProDbContext _context;

        public StatsController(JulieProDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
