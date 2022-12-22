/*
Задача 64: Задайте значение N. Напишите программу, которая
выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void OutputNum(int n, int m)
{
    if(n == m) Console.Write($"{m}");
    else 
    {
        Console.Write($"{n} ");
        OutputNum(n - 1, m);       
    }
}

Console.Clear();
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
OutputNum(n, m);