using appGuild.Domain.Abstract;
using appGuild.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appGuild.Web.Controllers
{
    public class AdminController : Controller
    {
        private ICharacterRepository repository;
        
        public AdminController (ICharacterRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Characters);
        }

        public ViewResult Edit(int Id)
        {
            Character character = repository.Characters.FirstOrDefault(p => p.Id == Id);
            return View(character);
        }

        [HttpPost]
        public ActionResult Edit(Character character)
        {
            if (ModelState.IsValid)
            {
                repository.SaveCharacter(character);
                TempData["message"] = string.Format("{0} has been saved", character.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // Что-то не так со значениями данных
                return View(character);
            }
        }
    }
}
