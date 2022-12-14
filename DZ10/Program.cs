/*
В  институте биоинформатики по офису передвигается робот. Недавно
студенты из группы программистов написали для него программу, по
которой робот, когда заходит в комнату, считает количество 
программистов в ней и произносит его вслух: "n программистов".
Для того, чтобы это звучало правильно, для каждого n нужно использовать
верное окончание слова.
Напишите программу, считывающую с пользовательского ввода целое
число n (неотрицательное), выводящее это число в консоль вместе
с правильным образом изменённым словом "программист", для того,
чтобы робот мог нормально общаться с людьми, например: 1 программист,
2 программиста, 5 программистов.
В комнате может быть очень много программистов. Проверьте, что ваша
программа правильно обработает все случаи, как минимум до 1000 человек.
*/

Console.Clear();
Console.Write("Введите количество человек в помещении: ");
int a = Convert.ToInt32(Console.ReadLine());
if(((a < 10) && (a > 0)) || (a > 20))
{
    if((a == 1) || (a % 10 == 1)) 
        Console.Write($"В помещении {a} программист");
    else if((a % 10 == 2) || (a % 10 == 3) || (a % 10 == 4))
        Console.Write($"В помещении {a} программиста");
    else
        Console.Write($"В помещении {a} программистов");
}
else if((a > 9) && (a < 21))
    Console.Write($"В помещении {a} программистов");
else if(a == 0)
    Console.Write("В помещении нет программистов");
else
    Console.Write("Такого количества программистов в помещении не может быть");