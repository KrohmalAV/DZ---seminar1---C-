/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка
*/

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


// Метод заполнения одномерного массива суммой значений строк двумерного массива
int[] FillArraySumString(int[,] array)
{
    int[] arraySumString = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++) 
        {
            for(int j = 0; j < array.GetLength(1); j++)
                arraySumString[i] += array[i, j];
       }
    return arraySumString;
}

// Метод вывода номера строки с наименьшей суммой элементов
void PrintNumStringMinSum(int[]array)  
{
    int indexMinNum = 1;
    int minNum = array[0];
    for(int i = 1; i < array.Length; i++) 
        if (array[i] < minNum)
            {
                minNum = array[i];
                indexMinNum = i + 1;
            }
        Console.Write($"Номер строки массива с наименьшей суммой элементов: {indexMinNum}");
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = FillMatrix(row, column, 0, 10);
PrintMatrix(array);
int[] arraySumString = FillArraySumString(array);
PrintNumStringMinSum(arraySumString);