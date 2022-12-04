/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу
между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

decimal[] FillArray(int size, int min, int max)  // Заполнение массива (рандомно)
{
    decimal[] array = new decimal[size];
    for(int i = 0; i < size; i++) array[i] = new Random().Next(min, max);
    return array;
}
void PrintArray(decimal[]array)  // Вывод массива
{
    Console.Write($"[{array[0]}");
    for(int i = 1; i < array.Length; i++) Console.Write($", {array[i]}");
    Console.WriteLine("]");
}
decimal MaxNum(decimal[]array) // Max элемент в массиве
{
    decimal max = array[0];
    for(int i = 1; i < array.Length; i++)
        if(array[i] > max)
            max = array[i];
    return max;
}

decimal MinNum(decimal[]array) // Min элемент в массиве
{
    decimal min = array[0];
    for(int i = 1; i < array.Length; i++)
        if(array[i] < min)
            min = array[i];
    return min;
}
Console.Clear();
decimal[] array = FillArray(6, -10, 10);
PrintArray(array);
decimal diff = MaxNum(array) - MinNum(array);
Console.WriteLine($"Max элемент массива: {MaxNum(array)}");
Console.WriteLine($"Min элемент массива: {MinNum(array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");
