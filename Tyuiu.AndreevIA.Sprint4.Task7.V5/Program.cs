using Tyuiu.AndreevIA.Sprint4.Task7.V5.Lib;

DataService ds = new DataService();



Console.Title = "Спринт #4 | Выполнил Андреев И. А. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Андреев Иван Александрович | РППб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр \"246813579\".                        *");
Console.WriteLine("* Преобразуйте ее в матрицу 3 на 3 и                                      *");
Console.WriteLine("* подсчитайте количество четных чисел.                                    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int rows = 3;
int columns = 3;
int[,] mtrx = new int[rows, columns];

string str = "246813579";

int index = 0;

Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{str[index]} \t");
        index++;
    }
    Console.WriteLine();
}


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int z = ds.Calculate(rows, columns, str);
Console.WriteLine(z);

Console.ReadKey();