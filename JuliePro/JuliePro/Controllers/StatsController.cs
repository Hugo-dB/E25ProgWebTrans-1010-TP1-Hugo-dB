using JuliePro.Models;
using JuliePro.Models.Data;
using JuliePro.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            List<Customer> customers = _context.Customers.Include(c => c.Objectives).ToList();
            StatsVM statsVM = new(customers);
            return View(statsVM);
        }
    }
}
