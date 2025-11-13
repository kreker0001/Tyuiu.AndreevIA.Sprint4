using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AndreevIA.Sprint4.Task7.V5.Lib
{
    public class DataService : ISprint4Task7V5
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrx = new int[3, 3];
            int r = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    matrx[i, j] = int.Parse(value[i * 3 + j].ToString());
                    if (matrx[i, j] % 2 == 0)
                    {
                        r++;
                    }
                }
            }

            return r;
        }
    }
}
