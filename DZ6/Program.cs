/*
Задача 10: Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую цифру
этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.Write("Введите трехзначное  целое число: ");
string Z = Console.ReadLine();
if(Z.Length == 3) 
{
    int z = Convert.ToInt32(Z);
    Console.WriteLine(((z / 10) % 10));
} 
else Console.WriteLine("Нужно было ввести трехзначное число");
