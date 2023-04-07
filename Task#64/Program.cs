/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int n;

Console.Write("Введите значение N: ");
int.TryParse(Console.ReadLine(), out n);

Console.Write(Rec(n));

string Rec(int n)
{
    if (n == 1)
        return $"{n}";
    return $"{n}, {Rec(n - 1)}";
}

