using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Controllers;
using WebAPI.Models;
using System;
using System.Net.Http;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestGetPassenger()
        {
            //Arrange
            var controller = new PassengerController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act
            var response = controller.GetPassenger(10);

            //Assert
            Passenger passenger;
            Assert.IsTrue(response.TryGetContentValue<Passenger>(out passenger));
            Assert.AreEqual(10, passenger.ID);
        }

        [TestMethod]
        public void TestPostMethod()
        {
            // Arrange
            PassengerController controller = new PassengerController();

            controller.Request = new HttpRequestMessage
            {
                RequestUri = new Uri("http://localhost/api/passenger")
            };
            controller.Configuration = new HttpConfiguration();
            controller.Configuration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            controller.RequestContext.RouteData = new HttpRouteData(
                route: new HttpRoute(),
                values: new HttpRouteValueDictionary { { "controller", "passenger" } });

            // Act
            Passenger passenger = new Passenger() { ID = 11, FirstName = "xyz" };
            var response = controller.PostPassenger(passenger);

            // Assert
            Assert.AreEqual("http://localhost/api/passenger/11", response.Headers.Location.AbsoluteUri);
        }
    }
}
