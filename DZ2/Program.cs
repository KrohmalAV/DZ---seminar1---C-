/*
Задача 4: Напишите программу, которая принимает на вход
три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();
Console.Write("Ведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(a == b && a == c)
{
    Console.WriteLine($"Все три введенных числа равны. Выделить максимальное невозможно.");
}
else
{
    if(b > max)
    {
        max = b;
    }
    if(c > max)
    {
        max = c;
    }
    Console.WriteLine($"Максимальное из введенных чисел = {max}");
}