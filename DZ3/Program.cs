﻿/*
Задача 6: Напишите программу, которая на вход принимает
число и выдаёт, является ли число чётным (делится ли оно
на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 0)
{
    Console.WriteLine($"Да. Введенное число {a} четное (делится на 2 без остатка)");
}
else
{
    Console.WriteLine($"Нет. Введенное число {a} нечетное (не делится на 2 без остатка)");
}