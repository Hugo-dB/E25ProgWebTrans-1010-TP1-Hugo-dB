using JuliePro.Models.Data;
using JuliePro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JuliePro.Controllers
{
    public class SpecialityController : Controller
    {
        private JulieProDbContext _baseDonnees { get; set; }

        public SpecialityController(JulieProDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }

        // GET: SpecialityController
        public ActionResult Index()
        {
            List<Speciality> speciality = _baseDonnees.Specialities.Include(s => s.Trainers).ToList();
            return View(speciality);
        }

        // GET: SpecialityController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SpecialityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Speciality speciality)
        {
            if (ModelState.IsValid)
            {
                // Ajouter à la BD
                _baseDonnees.Specialities.Add(speciality);
                _baseDonnees.SaveChanges();
                TempData["Success"] = $"{speciality.Name} speciality added";
                return RedirectToAction("Index");
            }

            return View(speciality);
        }

        // GET: SpecialityController/Edit/5
        public ActionResult Edit(int id)
        {
            Speciality speciality = _baseDonnees.Specialities.Find(id);

            return View(speciality);
        }

        // POST: SpecialityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Speciality speciality)
        {
            if (ModelState.IsValid)
            {
                _baseDonnees.Specialities.Update(speciality);
                _baseDonnees.SaveChanges();
                TempData["Success"] = $"Speciality {speciality.Name} has been modified";
                return RedirectToAction("Index");
            }
            return View(speciality);
        }

        // GET: SpecialityController/Delete/5
        public ActionResult Delete(int id)
        {
            Speciality? speciality = _baseDonnees.Specialities.Find(id);
            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        // POST: SpecialityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            Speciality speciality = _baseDonnees.Specialities.Find(id);
            if (speciality == null)
            {
                return View("NotFound");             
            }

            _baseDonnees.Specialities.Remove(speciality);
            _baseDonnees.SaveChanges();
            TempData["Success"] = $"Speciality {speciality.Name} has been removed";
            return RedirectToAction("Index");

        }
    }
}
