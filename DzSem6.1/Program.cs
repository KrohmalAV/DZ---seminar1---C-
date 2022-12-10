/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

// Ввод чисел через пробел единой строкой
Console.Clear();
Console.Write("Введите числа через пробел: ");
string numM = Console.ReadLine();
string[] array = numM.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
double[] arrayInt = array.Select(double.Parse).ToArray();
int count = 0;
foreach(int num in arrayInt)
    if (num > 0)
        count++;
Console.WriteLine($"Вами введено {count} положительных чисел");
Console.ReadKey();

// Ввод чисел построчно до написания стоп-слова
Console.Write("Вводите числа.\nДля прекращения ввода введите слово 'stop'.\n");
string NumStr = "-1";
int count2 = 0;
int index = 1;
while(string.Compare(NumStr, "stop", true) < 0)
{
    int NumInt = Convert.ToInt32(NumStr);
    Console.Write($"{index} число - ");
    NumStr = Console.ReadLine();
    if(NumInt > 0) count2 += 1;
    index++;
}
Console.WriteLine($"Вами введено {count2} положительных чисел");