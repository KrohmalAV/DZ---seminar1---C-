/*
Задача 36: Задайте одномерный массив, заполненный случайными
числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 89, 6] -> 85
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
int TotalUnevenIndex(int[]array) // Подсчет суммы элементов массива на нечетных позициях
{
    int total = 0;
    for(int i = 0; i < array.Length; i += 2)
        total += array[i];
    return total;
}

Console.Clear();
int[] array = FillArray(6, -10, 10);
PrintArray(array);
int total = TotalUnevenIndex(array);
Console.WriteLine($"Сумма элементов массива на нечетных позициях: {total} ");