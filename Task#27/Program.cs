/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int a;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out a);


int Sumdigit(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
}

int sum = Sumdigit(a);
Console.Write($"Сумма цифр числа {a} равна {sum}");
