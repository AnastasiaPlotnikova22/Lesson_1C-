﻿//  23.Напишите программу, которая 
//  1. принимает на вход число (N) и 
//  2. выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 1 ) 
{
    Console.WriteLine("Некорректный ввод ");
}
Table123(number);

void Table123(int num)
{
    int count = 1;
    while (count <= num)
    {
       Console.WriteLine($"{count, 5} {count * count * count, 5}");
       count++;
    }
}