using System;
using CoffeeMakerRhinoMoq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Using Rhino Mock.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            ///Arrange
            var service = MockRepository.GenerateMock<IMakeACoffee>();
            service.Expect(x => x.CheckIngridentAvalability()).Return(true);
            service.Expect(x => x.CoffeeMaking(Arg<int>.Is.Anything, Arg<int>.Is.Anything)).Return("Your Order is received.");
            var store = new StarbuckStore(service);

            ///Act
            var result = store.OrderCoffee(2, 4);

            ///Assert
            Assert.AreEqual("Your Order is received.", result);
            service.VerifyAllExpectations();
        }
    }
}
