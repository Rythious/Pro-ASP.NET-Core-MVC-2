using ControllersAndActions.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ControllersAndActions.Tests
{
    public class ActionTests
    {
        //[Fact]
        //public void ViewSelected()
        //{
        //    //Arrange
        //    HomeController controller = new HomeController();

        //    //Act
        //    ViewResult result = controller.ReceiveForm("Adam", "London");

        //    //Assert
        //    Assert.Equal("Result", result.ViewName);
        //}

        //[Fact]
        //public void ModelObjectType()
        //{
        //    //Arrange
        //    ExampleController controller = new ExampleController();

        //    //Act
        //    ViewResult result = controller.Index();

        //    //Assert
        //    Assert.IsType<string>(result.ViewData["Message"]);
        //    Assert.Equal("Hello", result.ViewData["Message"]);
        //    Assert.IsType<System.DateTime>(result.ViewData["Date"]);
        //}

        //[Fact]
        //public void Redirection()
        //{
        //    //Arrange
        //    ExampleController controller = new ExampleController();

        //    //Act
        //    RedirectToActionResult result = controller.Redirect();

        //    //Assert
        //    Assert.False(result.Permanent);
        //    Assert.Equal("Index", result.ActionName);
        //}

        [Fact]
        public void JsonActionMethod()
        {
            //Arrange
            ExampleController controller = new ExampleController();

            //Act
            JsonResult result = controller.Index();

            //Assert
            Assert.Equal(new[] { "Alice", "Bob", "Joe" }, result.Value);
        }
    }
}
