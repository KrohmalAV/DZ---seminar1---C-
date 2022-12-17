/*
Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// Метод заполнения двумерного массива (рандомно)
int[,] FillMatrix(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++) 
        for(int j = 0; j < column; j++)
            array[i,j] = new Random().Next(min, max);
    return array;
}

// Метод вывода двумерного массива
void PrintMatrix(int[,]array)  
{
    for(int i = 0; i < array.GetLength(0); i++) 
        {
            for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
            Console.WriteLine(); 
        } 
}

// Метод заполнения массива через произведение двух других массивов
int[,] MultiMatrix(int[,]array1, int[,]array2)
{
    int[,] multiArray = new int[array1.GetLength(0), array1.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++) 
        for(int j = 0; j < array2.GetLength(1); j++)
            for(int k = 0; k < array2.GetLength(0); k++)
                multiArray[i,j] += array1[i, k]*array2[k, j];
    return multiArray;
}

Console.Clear();
Console.Write("Введите количество строк в ПЕРВОМ массиве: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ПЕРВОМ в массиве: ");
int column1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк во ВТОРОМ массиве: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов во ВТОРОМ массиве: ");
int column2 = Convert.ToInt32(Console.ReadLine());
if(column1 == row2)
{
    int[,] matrix1 = FillMatrix(row1, column1, 0, 10);
    PrintMatrix(matrix1);
    Console.WriteLine();
    int[,] matrix2 = FillMatrix(row2, column2, 0, 10);
    PrintMatrix(matrix2);

    int [,] multiMatrix = MultiMatrix(matrix1, matrix2);
    Console.WriteLine($"\nПроизведение массивов равно:");
    PrintMatrix(multiMatrix);
}
else
    {
    Console.WriteLine("Указанные массивы умножать нельзя!");
    Console.WriteLine("Количество столбцов ПЕРВОГО массива должно быть равно количеству строк ВТОРОГО массива!");
    }