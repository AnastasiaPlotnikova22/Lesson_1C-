// 12. Напишите программу, которая 
// 1. будет принимать на вход два числа и 
// 2. выводить, является ли первое число кратным второму.
// 3. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int MultipleNums (int num1, int num2)
{
    return num1 % num2;
}

Console.Write("Введите два числа : ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
int numberSecond = Convert.ToInt32(Console.ReadLine());

int remaisn = MultipleNums(numberFirst, numberSecond);

if (remaisn == 0)
{
    Console.WriteLine("Кратно");
}

else
{
    Console.WriteLine($"Не кратно, {remaisn}" );
}