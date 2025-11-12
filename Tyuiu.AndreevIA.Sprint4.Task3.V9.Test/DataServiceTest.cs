using Tyuiu.AndreevIA.Sprint4.Task3.V9.Lib;

namespace Tyuiu.AndreevIA.Sprint4.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = { { 9, 6, 4, 5, 3 },
                     { 7, 4, 7, 5, 3 },
                     { 8, 5, 9, 9, 3 },
                     { 7, 8, 7, 9, 3 },
                     { 3, 7, 3, 7, 7 } };

            int[,] expected = { { 9, 1, 1, 5, 3 },
                       { 7, 1, 7, 5, 3 },
                       { 1, 5, 9, 9, 3 },
                       { 7, 1, 7, 9, 3 },
                       { 3, 7, 3, 7, 7 } };

            var res = ds.Calculate(array);
            CollectionAssert.AreEqual(expected, res);

        }
    }
}
