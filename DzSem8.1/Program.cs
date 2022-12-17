/*
Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

// Метод пузырьковой сортировки двумерного массива по строкам
void SortRowMatrix(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++) 
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = j + 1; k < array.GetLength(1); k++)
                if(array[i,j] < array[i,k])
                    (array[i,j], array[i,k]) = (array[i,k], array[i,j]);
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = FillMatrix(row, column, 0, 10);
PrintMatrix(array);
SortRowMatrix(array);
Console.WriteLine($"\nСортированный массив:");
PrintMatrix(array);