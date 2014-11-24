using appGuild.Domain.Abstract;
using appGuild.Web.Models;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace appGuild.Web.Controllers
{
    public class CharacterController : Controller
    {
        private ICharacterRepository repository;

        public CharacterController(ICharacterRepository characterRepository)
        {
            repository = characterRepository;
        }

        public JsonResult JsonResult()
        {
            //return this.Content(JsonConvert.SerializeObject(repository.Characters), "application/json");
            return this.Json(repository.Characters, JsonRequestBehavior.AllowGet);
        }

        public ContentResult ContentResult()
        {
            return this.Content(JsonConvert.SerializeObject(repository.Characters), "application/json");
        }

        public ViewResult List()
        {
            CharactersViewModel model = new CharactersViewModel()
            {
                Characters = repository.Characters
            };

            return View(model);
        }

        
    }
}