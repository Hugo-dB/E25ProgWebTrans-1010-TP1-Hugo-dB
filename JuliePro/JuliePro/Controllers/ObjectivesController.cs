using JuliePro.Models;
using JuliePro.Models.Data;
using JuliePro.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace JuliePro.Controllers
{
    public class ObjectivesController : Controller
    {
        private readonly JulieProDbContext _context;

        public ObjectivesController(JulieProDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Trainer> trainers = _context.Trainers.Include(t => t.Customers).ThenInclude(c => c.Objectives).Include(t => t.Speciality).ToList();

            List<TrainerObjectivesVM> trainerObjectives = new();
            foreach (Trainer trainer in trainers)
            {
                TrainerObjectivesVM trainerObjective = new(trainer);
                trainerObjectives.Add(trainerObjective);
            }
                        
            return View(trainerObjectives);
        }
    }
}
