/*
Задача 27: Напишите программу, которая принимает
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumNumber(int A)
{
    int result = 0;
        while(A > 0)
    {
        result += A % 10;
        A = A / 10;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число : ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {A} равняется {SumNumber(A)}");