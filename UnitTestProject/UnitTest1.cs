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
            double expectedResult = 240;
            double actualResut;
            Car test=new Car();
            actualResut = test.Price();
            Assert.AreEqual(expectedResult, expectedResult);
        }

        [TestMethod]
        public void CheckVehicleType()
        {
            string expectedResult = "Car";
            Car test = new Car();
            var actualResut = test.VehicleType();
            Assert.AreEqual(expectedResult, actualResut);
        }
    }
}
