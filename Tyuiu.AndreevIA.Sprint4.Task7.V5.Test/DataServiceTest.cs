using Tyuiu.AndreevIA.Sprint4.Task7.V5.Lib;

namespace Tyuiu.AndreevIA.Sprint4.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string array = "123456789";
            int wail = 4;
            int a = 3;
            int b = 3;
            int res = ds.Calculate(a, b, array);
            Assert.AreEqual(wail, res);
        }
    }
}
