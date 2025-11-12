using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.AndreevIA.Sprint4.Task0.V10.Lib
{
    public class DataService : ISprint4Task0V10
    {
        public int GetSumOddArrEl(int[] array) => array.Where(x => x % 2 == 1).Sum();
    }
}
