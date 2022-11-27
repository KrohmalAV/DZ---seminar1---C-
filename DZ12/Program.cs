/*
Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
Console.Write("Введите значение X точки А: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение Y точки А: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение Z точки А: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение X точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение Y точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение Z точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double xAxB = xA - xB;
double yAyB = yA - yB;
double zAzB = zA - zB;
double L = Math.Round(Math.Sqrt((xAxB * xAxB + yAyB * yAyB + zAzB * zAzB)), 2);
Console.WriteLine(L);
