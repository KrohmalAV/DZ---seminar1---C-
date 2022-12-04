/*
Задача 34: Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет количество
чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] FillArray(int size, int min, int max)  // Заполнение массива (рандомно)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) array[i] = new Random().Next(min, max);
    return array;
}
void PrintArray(int[]array)  // Вывод массива
{
    Console.Write($"[{array[0]}");
    for(int i = 1; i < array.Length; i++) Console.Write($", {array[i]}");
    Console.WriteLine("]");
}
int FindCountEvenNum(int[]array) // Поиск количества четных чисел массива
{
    int count = 0;
    foreach(int arr in array)
        if(arr % 2 == 0) count++;
    return count;
}

Console.Clear();
int[] array = FillArray(10, 100, 1000);
PrintArray(array);
int count = FindCountEvenNum(array);
Console.WriteLine($"Количество четных чисел в массиве: {count} ");