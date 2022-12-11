/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
            Console.Write($" {array[i,j]}   ");
            Console.WriteLine(); 
        } 
}

// Метод заполнения одномерного массива средним арифметическим значением столбцов двумерного массива
double[] FillArrayAverage(int[,] array)
{
    double[] arrayAverage = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++) 
        {
            double sum = 0;
            for(int i = 0; i < array.GetLength(0); i++)
                sum += array[i, j];
            arrayAverage[j] = Math.Round(sum / array.GetLength(0), 1);
       }
    return arrayAverage;
}

// Метод вывода одномерного массива
void PrintArray(double[]array)  
{
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    for(int i = 0; i < array.Length; i++) 
        Console.Write($"{array[i]}   ");
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
if(row < 2 || column < 2)
    Console.Write("Массив с указанным количеством строк и столбцов невозможно создать");
else
{
    int[,] array = FillDoubleArray(row, column, 0, 10);
    PrintDoubleArray(array);
    double[] arrayAverage = FillArrayAverage(array);
    PrintArray(arrayAverage);
}