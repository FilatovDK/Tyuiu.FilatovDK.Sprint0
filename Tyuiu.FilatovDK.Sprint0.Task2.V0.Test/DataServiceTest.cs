using Tyuiu.FilatovDK.Sprint0.Task2.V0.Lib;
namespace Tyuiu.FilatovDK.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            var name = "�����";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("������..., �����", res);
        }
    }
}