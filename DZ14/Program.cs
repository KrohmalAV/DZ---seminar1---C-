/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double Pow(double A, int B)
{
    double result = 1;
    for(int i = 1; i <= B; i++) result *= A;
    return result;   
}

Console.Clear();
Console.Write("Введите возводимое в степень число A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральное число B (степень): ");
int B = Convert.ToInt32(Console.ReadLine());
if(B <= 0) Console.WriteLine("Необходимо было ввести натуральную степень...");
else
{
    double degree = Pow(A, B);
    Console.WriteLine($"{A} в степени {B} равняется {degree}");
}