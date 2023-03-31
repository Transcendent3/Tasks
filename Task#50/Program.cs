/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

//Создание массива
int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-30, 30);
        }
    }
    return array;
}

//Вывод массива на экран
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}");
        Console.WriteLine();
    }
}

//Проверка позиций и вывод результата на экран
void ValidPosition(int n, int m, int[,] array)
{
    if (n <= array.GetLength(0) && m <= array.GetLength(1))
        Console.Write($"{array[n - 1, m - 1]}");
    else
        Console.Write($"{m} -> такой позиции в массиве нет");
}

int[,] array = FillArray(new Random().Next(3, 6), new Random().Next(3, 6));
PrintArray(array);
int n, m;
Console.Write("Введите позицию (строку) элемента: ");
int.TryParse(Console.ReadLine()!, out n);
Console.Write("Введите позицию (столбец) элемента: ");
int.TryParse(Console.ReadLine()!, out m);
ValidPosition(n, m, array);

