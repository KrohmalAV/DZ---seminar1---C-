/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


// Метод заполнения трехмерного массива (рандомно)
int[,,] FillMatrix(int row1, int column, int row2, int min, int max)
{
    int[,,] array = new int[row1, column, row2];
    for(int i = 0; i < row1; i++) 
        for(int j = 0; j < column; j++)
            for(int k = 0; k < row2; k++)
                // array[i,j,k] = new Random().Next(min, max);
                {
                    int num = new Random().Next(min, max);
                    foreach(int arr in array)
                        {
                            if(num == arr)
                                k--;
                            else
                                array[i,j,k] = num;
                        }
                }
    return array;
}

// Метод вывода двумерного массива
void PrintMatrix(int[,,]array)  
{
    for(int i = 0; i < array.GetLength(0); i++) 
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
                Console.WriteLine($"{array[i,j,k]}({i},{j},{k})");
}

Console.Clear();
Console.Write("Введите количество строк в трехмерном массиве: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в трехмерном массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество рядов в трехмерном массиве: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,,] array = FillMatrix(row1, column, row2, 10, 100);
PrintMatrix(array);