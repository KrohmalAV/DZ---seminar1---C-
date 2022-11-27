/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
Console.Write("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 99999 || x < 10000)
    Console.WriteLine("Просили же ввести пятизначное число. Эт ты...");
else
{
    int[] M = new int[5];
    int m = x;
    for(int i = 0; i < 5; i++)
    {
        M[i] = m % 10;
        m /= 10;
    }
    if(M[0] == M[4] && M[1] == M[3]) Console.WriteLine($"Число {x} палиндром");
    else Console.WriteLine($"Число {x} не является палиндромом");
}

/* То же самое только через рандом:
Console.Clear();
int x = new Random().Next(10000, 100000);
Console.Write($"Случайное пятизначное число {x}");
int[] M = new int[5];
int m = x;
for(int i = 0; i < 5; i++)
{
    M[i] = m % 10;
    m /= 10;
}
if(M[0] == M[4] && M[1] == M[3]) Console.WriteLine(" - палиндром");
else Console.WriteLine(" не является палиндромом");
*/