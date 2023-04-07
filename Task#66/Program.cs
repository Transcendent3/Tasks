/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int n, m;
Console.Write("Введите значение M: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write("Введите значение N: ");
int.TryParse(Console.ReadLine(), out n);

Console.Write($"Сумма натуральных элементов от {m} до {n} -> {Rec(m, n)}");

int Rec(int m, int n)
{
    if (m == n)
        return m;
    else if (m > n)
        return 0;
    return m + Rec(m + 1, n);
}

