﻿/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

if ((a / 1000 % 10 * 10 + a / 10000) == a % 100)
    Console.Write($"Число {a} является палиндромом");
else
    Console.Write($"Число {a} не является палиндромом");
