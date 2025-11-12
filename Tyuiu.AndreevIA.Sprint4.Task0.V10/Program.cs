using Tyuiu.AndreevIA.Sprint4.Task0.V10.Lib;

Console.Title = "Спринт #4 | Выполнил Андреев И. А. | РППб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Операции сравнения                                                      *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");

Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последова*");
Console.WriteLine("*ательность операций не должна нарушаться) и арифметических выражений, кот*");
Console.WriteLine("*торая вернет логическую последовательность(массив): (True, True, True, Tr*");
Console.WriteLine("*rue, True, False), при x = 1054, y = 375                                 *");

Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("***************************************************************************");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

var result = ds.GetSumOddArrEl(new int[] { 1, 2, 3, 4, 5 });
Console.WriteLine(result);
Console.ReadKey();