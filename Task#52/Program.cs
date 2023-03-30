/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] array = new int[new Random().Next(3, 6), new Random().Next(3, 6)];
double sum = 0;
List<double> avg = new List<double>(array.GetLength(1));

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write($"{array[i, j],3}");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array[j, i];
    }
    avg.Add(sum / array.GetLength(0));
    Console.Write("{0,6:F2}", avg[i]);
    sum = 0;
}
