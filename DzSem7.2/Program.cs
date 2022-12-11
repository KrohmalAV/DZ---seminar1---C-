/*
Задача 50. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

// Метод заполнения двумерного массива (рандомно)
int[,] FillDoubleArray(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++) 
        for(int j = 0; j < column; j++)
            array[i,j] = new Random().Next(min, max);
    return array;
}

// Метод вывода двумерного массива
void PrintDoubleArray(int[,]array)  
{
    for(int i = 0; i < array.GetLength(0); i++) 
        {
            for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]}  ");
            Console.WriteLine(); 
        } 
}

// Поиск элемента в массива по его положению (строка, столбец)
void FindNumArray(int[,] array, string line)
{
    string[] lineString = line.Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries);
    int[] PositionNumArray = lineString.Select(Int32.Parse).ToArray();
    if(PositionNumArray[0] > array.GetLength(0)
        || PositionNumArray[1] > array.GetLength(1)
        || PositionNumArray[0] < 1
        || PositionNumArray[1] < 1)
        Console.WriteLine("В массиве такого числа нет");
    else
    {
        Console.WriteLine($"\nВ массиве число на позиции [{PositionNumArray[0]}, {PositionNumArray[1]}]");
        Console.WriteLine($"имеет значение {array[PositionNumArray[0] - 1, PositionNumArray[1] - 1]}");
    }
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = FillDoubleArray(row, column, -9, 10);
PrintDoubleArray(array);

Console.Write("Введите через пробел номер строки и номер столбца искомого элемента массива: ");
string PositionNumArray = Console.ReadLine()!;
if(PositionNumArray.Length < 3)
    Console.WriteLine("Нужно было ввести 2 числа (номер строки и номер столбца) через пробел...");
else
    FindNumArray(array, PositionNumArray);