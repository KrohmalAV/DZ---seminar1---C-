/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке
от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNums(int m, int n)
{
    if(m == n) return n;
    else return m + SumNums(m + 1, n);
}

Console.Clear();
Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(SumNums(m, n));