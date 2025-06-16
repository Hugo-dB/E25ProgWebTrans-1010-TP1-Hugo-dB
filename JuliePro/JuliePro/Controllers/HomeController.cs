using JuliePro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JuliePro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
