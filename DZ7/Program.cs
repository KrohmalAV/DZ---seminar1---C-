/*
Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int n = N;
int x1 = 0, x2 = 0, x3 = 0;
if(n / 100 == 0)
{
    Console.WriteLine("В этом числе нет искомой (третьей) цифры");
}
else
{
    while(n > 0)
    {
        x3 = x2;
        x2 = x1;
        x1 = n % 10;
        n = n / 10;
    }
Console.WriteLine($"В числе {N} третья цифра слева - {x3}");
Console.ReadKey();
}