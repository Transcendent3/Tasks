/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int size = new Random().Next(3, 11);
double[] array = new double[size];


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 51);
    Console.Write($"{array[i]} ");
}

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (min > array[i]) min = array[i];
    else if (max < array[i]) max = array[i];
}

Console.Write($"-> {max - min}");