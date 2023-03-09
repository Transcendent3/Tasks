/* 
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/


int N;
int n = 2;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

while (n <= N)
{
    Console.Write($"{n}, ");
    n += 2;
}
