﻿/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
int N = 3;
int M = 5;
int[,] array = new int[N, M];

int value = 1; //значение в ячейке, будет увеличиваться на 1 
int x = 0; //координата х, строка
int y = -1; //координата у, столбец
int d_row = 0;  //шаг по строке, принимает значения 1 (движемся вниз), 0(не движемся), -1 (движемся вверх)
int d_column = 1;  //шаг по столбцу, принимает значения 1 (движемся вправо), 0(не движемся), -1 (движемся влево)

while (value <= N * M)              // пока наше значение меньше максимального числа в массиве, максимальное число = длина строки * длину столбца
{   //первая проверка - наш шаг по строке не выступает за границы массива, вторая проверка - шаг по столбцу не выступает за границы, третья - наша следующая ячейка пустая
    if ((0 <= x + d_row) && (x + d_row < N) && (0 <= y + d_column) && (y + d_column < M) && (array[x + d_row, y + d_column] == 0))
    {
        x += d_row; //увеличиваем х на шаг, т.е. шагаем по строке
        y += d_column; //увеличиваем у на шаг, т.е. шагаем по столбцу
        array[x, y] = value; //присваиваем значение
        value++; //увеличиваем значение
    }
    //если не можем шагнуть (выходим за границы массива или в следующей ячейке уже есть значение), то необходимо повернуть по часовой стрелке
    else
    {
        if (d_column == 1) // мы шагали вправо, если мы не можем дальше идти, идем вниз
        {
            d_row = 1;
            d_column = 0;
        }
        else if (d_row == 1) // мы шагали вниз, если мы не можем дальше идти, идем влево
        {
            d_row = 0;
            d_column = -1;
        }
        else if (d_column == -1) // мы шагали влево, если мы не можем дальше идти, идем вверх
        {
            d_row = -1;
            d_column = 0;
        }
        else if (d_row == -1) // мы шагали вверх, если мы не можем дальше идти, идем вправо
        {
            d_row = 0;
            d_column = 1;
        }
    }

}


Console.WriteLine();
for (int row = 0; row < array.GetLength(0); row++)
{
    for (int col = 0; col < array.GetLength(1); col++)
    {
        Console.Write($"{array[row, col],3}");
    }
    Console.WriteLine();
}