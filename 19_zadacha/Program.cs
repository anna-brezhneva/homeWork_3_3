﻿// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Напишите пятизначное число: ");
int a = int.Parse(Console.ReadLine());
if ((9999 < a) && (a < 100000)) 
{
    if ((a.ToString()[0] == a.ToString()[4]) && (a.ToString()[1] == a.ToString()[3]))
    {
        Console.WriteLine("да");
    }
    else 
    {
        Console.WriteLine("нет");
    }
}
else 
{
Console.WriteLine("Вы ввели неверное число");
}

