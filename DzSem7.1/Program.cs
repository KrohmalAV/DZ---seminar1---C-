/*
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

// Заполнение двумерного массива (рандомно) вещественными числами
double[,] FillDoubleArray(int row, int column)  
{
    double[,] array = new double[row, column];
    for(int i = 0; i < row; i++) 
        for(int j = 0; j < column; j++)
            array[i,j] = Math.Round((new Random().NextDouble() - new Random().NextDouble()) * 10, 2);
    return array;
}
// Вывод двумерного массива
void PrintDoubleArray(double[,]array)  
{
    for(int i = 0; i < array.GetLength(0); i++) 
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j] > 0) Console.Write($" {array[i,j]}  ");
                else Console.Write($"{array[i,j]}  ");
            }
            Console.WriteLine(); 
        } 
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] array = FillDoubleArray(row, column);
PrintDoubleArray(array);