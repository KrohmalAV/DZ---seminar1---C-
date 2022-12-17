/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

// Метод заполнения двумерного массива (по спирали)
int[,] FillMatrix(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    int count = 1;
    int i = 0;
    int j = 0;
    while (count <= row * column)
    {
        array[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < column - 1)
            j++;
        else if (i < j && i + j >= row - 1)
            i++;
        else if (i >= j && i + j > column - 1)
            j--;
        else
            i--;
    }
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

Console.Clear();
int[,] array = FillMatrix(4, 4, 0, 10);
PrintMatrix(array);