using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using appGuild.Domain.Abstract;
using appGuild.Web.Controllers;
using appGuild.Domain.Entities;
using System.Web.Mvc;

namespace appGuild.Test.Controllers
{
    /// <summary>
    /// Summary description for AdminControllerTest
    /// </summary>
    [TestClass]
    public class AdminControllerTest
    {
        public AdminControllerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void CanSaveValidChanges()
        {
            //
            // TODO: Add test logic here
            //
            Mock<ICharacterRepository> mock = new Mock<ICharacterRepository>();
            AdminController target = new AdminController(mock.Object);
            Character character = new Character { Name = "Test" };
            ActionResult result = target.Edit(character);
            mock.Verify(m => m.SaveCharacter(character));
            Assert.IsNotInstanceOfType(result, typeof(ViewResult));

        }

        [TestMethod]
        public void CannotSaveInvalidChanges()
        {
            Mock<ICharacterRepository> mock = new Mock<ICharacterRepository>();
            AdminController target = new AdminController(mock.Object);
            Character character = new Character { Name = "Test" };
            target.ModelState.AddModelError("error", "error");
            ActionResult result = target.Edit(character);
            mock.Verify(m => m.SaveCharacter(It.IsAny<Character>()), Times.Never());
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
