using Tyuiu.AndreevIA.Sprint4.Task2.V26.Lib;

DataService ds = new DataService();
Random rnd = new Random();
Console.Title = "Спринт #4 | Выполнил Андреев И. А. | РППб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема:  Одномерные массивы. (генератор случайных чисел)                  *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #26                                                             *");
Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
Console.WriteLine("* случайными значениями в диапазоне от 1 до 8 подсчитать произведение     *");
Console.WriteLine("* нечетных элементов массива.                                             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int len;
Console.WriteLine("Введите количество элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
for (int i = 0; i <= len - 1; i++)
{
    array[i] = rnd.Next(1, 8);
}
Console.WriteLine("Массив: ");
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine(array[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.Calculate(array));
Console.ReadKey();