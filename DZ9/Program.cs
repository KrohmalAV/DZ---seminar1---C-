﻿/*
Напишите программу, которая выводит на экран числа от 1 до 100. При этом вместо
чисел кратным трем программа должна выводить слово Fizz, а вместо чисел кратных 
пяти - слово Buzz. Если число кратно пятнадцати, то программа должна выводить слово
FizzBuzz. задача может показаться очевидной, но нужно получить наиболее простое и 
красивое решение.
*/

Console.Clear();
int i = 1;
while(i <= 100)
{
    if(i % 15 == 0) Console.Write("FizzBuzz  ");
    else if(i % 5 == 0) Console.Write("Buzz  ");
    else if(i % 3 == 0) Console.Write("Fizz  ");
    else Console.Write($"{i}  ");
    i++;
}
