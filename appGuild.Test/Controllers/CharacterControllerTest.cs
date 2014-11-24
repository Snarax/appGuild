using System;
using Moq;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appGuild.Domain.Abstract;
using appGuild.Domain.Entities;
using appGuild.Web.Controllers;
using appGuild.Web.Models;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Web.Helpers;

namespace appGuild.Test.Controllers
{
    [TestClass]
    public class CharacterControllerTest
    {
        [TestMethod]
        public void ControllerReturnRightData()
        {
            Mock<ICharacterRepository> repository = new Mock<ICharacterRepository>();
            repository.Setup(m => m.Characters).Returns(new Character[] {
                new Character { Name = "n1", Class = "c1", Points = 0},
                new Character { Name = "n2", Class = "c2", Points = 0},
                new Character { Name = "n3", Class = "c3", Points = 0},
                new Character { Name = "n4", Class = "c4", Points = 0},
                new Character { Name = "n5", Class = null, Points = 0},
            }.AsQueryable());

            CharacterController controller = new CharacterController(repository.Object);

            CharactersViewModel result = (CharactersViewModel)controller.List().Model;

            Assert.AreEqual(result.Characters.First().Name, "n1");
        }

        [TestMethod]
        public void JsonReturnSpeedTest()
        {

            Mock<ICharacterRepository> repository = new Mock<ICharacterRepository>();
            repository.Setup(m => m.Characters).Returns(new Character[] {
                new Character { Name = "n1", Class = "c1", Points = 0},
                new Character { Name = "n2", Class = "c2", Points = 0},
                new Character { Name = "n3", Class = "c3", Points = 0},
                new Character { Name = "n4", Class = "c4", Points = 0},
                new Character { Name = "n5", Class = null, Points = 0},
            }.AsQueryable());


            CharacterController controller = new CharacterController(repository.Object);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(repository.Object.Characters);
            
            var actual = controller.JsonResult();

            var data = Newtonsoft.Json.JsonConvert.SerializeObject(actual.Data);

            Assert.AreEqual(json, data);
        }

        [TestMethod]
        public void ContentReturnSpeedTest()
        {

            Mock<ICharacterRepository> repository = new Mock<ICharacterRepository>();
            repository.Setup(m => m.Characters).Returns(new Character[] {
                new Character { Name = "n1", Class = "c1", Points = 0},
                new Character { Name = "n2", Class = "c2", Points = 0},
                new Character { Name = "n3", Class = "c3", Points = 0},
                new Character { Name = "n4", Class = "c4", Points = 0},
                new Character { Name = "n5", Class = null, Points = 0},
            }.AsQueryable());

            CharacterController controller = new CharacterController(repository.Object);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(repository.Object.Characters);

            
            ContentResult result = controller.ContentResult();
            Assert.AreEqual(result.Content, json);
        }
    }
}
