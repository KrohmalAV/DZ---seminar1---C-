/*
Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

// Заполнение массива вручную
void FillArrayManually(double[]array)
{
    for(int i = 0; i < 8; i++)
    {
        Console.Write($"Введите {i+1} число массива: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
}

// //Заполнение массива рандомно от 0 до 99
// void FillArray(double[]array)
// {
//     for(int i = 0; i < 8; i++) array[i] = new Random().Next(0, 100);
// }

// Вывод массива
void PrintArray(double[]array)
{
    Console.Write($"[{array[0]}");
    for(int i = 1; i < 8; i++) Console.Write($", {array[i]}");
    Console.Write("]");
}

Console.Clear();
double [] array = new double[8];
FillArrayManually(array);
// FillArray(array);
PrintArray(array);
