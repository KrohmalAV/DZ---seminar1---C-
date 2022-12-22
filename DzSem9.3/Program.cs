/*
Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int FunctionAkkerman(int m, int n)
{
    if(m == 0) return n + 1;
    else if(n == 0 && m != 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}

Console.Clear();
Console.Write("Введите натуральное положительное число m для функции Аккермана: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное положительное число n для функции Аккермана: ");
int n = Convert.ToInt32(Console.ReadLine());
if(m > 0 && n > 0) Console.Write(FunctionAkkerman(m, n));
else Console.Write("Необходимо было ввести положительные числа");