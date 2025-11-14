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

            string[] mas = { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };
            string[] res = ds.Calculate(mas);
            string[] wait = { "Театр", "Кино", "Музей", "Парк" };

            CollectionAssert.AreEqual(wait, res); 

        }
    }
}
