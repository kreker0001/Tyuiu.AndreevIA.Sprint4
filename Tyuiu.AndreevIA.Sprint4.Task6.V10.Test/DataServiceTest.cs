using Tyuiu.AndreevIA.Sprint4.Task6.V10.Lib;

namespace Tyuiu.AndreevIA.Sprint4.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas = { "Òåàòð", "Êèíî", "Ìóçåé", "Ïàðê", "Çîîïàðê", "Êîíöåðò", "Âûñòàâêà" };
            string[] res = ds.Calculate(mas);
            string[] wait = { "Òåàòð", "Êèíî", "Ìóçåé", "Ïàðê" };
            Assert.AreEqual(res, wait);
        }
    }
}
