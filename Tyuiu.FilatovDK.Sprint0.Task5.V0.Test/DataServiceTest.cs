using Tyuiu.FilatovDK.Sprint0.Task5.V0.Lib;
namespace Tyuiu.FilatovDK.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValied()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedSubtractionValied()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckedMultiplicationValied()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionValied()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }



    }
}