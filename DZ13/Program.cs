/*
Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
Console.Write("Введите целое натуральное число: ");
double N = Convert.ToDouble(Console.ReadLine());
if(N > 0 && (N*10) % 10 == 0)
{
    for(int i = 1; i <= N; i++) Console.WriteLine($"Куб числа {i} = {Math.Pow(i, 3)}");
}
else Console.Write($"Просили же ввести целое натуральное число");