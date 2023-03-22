/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int size = new Random().Next(3, 11);
int[] array = new int[size];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
    if (array[i] % 2 == 0) count++;
}
Console.Write($"-> {count}");