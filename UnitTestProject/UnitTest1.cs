using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckPrice()
        {
            double actualResut;
            Car test=new Car();
            actualResut = test.Price();
            Assert.AreEqual(240, actualResut);
        }

        [TestMethod]
        public void CheckVehicleType()
        {
            Car test = new Car();
            var actualResut = test.VehicleType();
            Assert.AreEqual("Car", actualResut);
        }
        [TestMethod]
        public void CheckPriceMC()
        {
            double actualResut;
            MC test = new MC();
            actualResut = test.Price();
            Assert.AreEqual(125, actualResut);
        }

        [TestMethod]
        public void CheckVehicleTypeMC()
        {
            string expectedResult = "MC";
            MC test = new MC();
            var actualResut = test.VehicleType();
            Assert.AreEqual("MC", actualResut);
        }
    }
}
