// 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetDigit(int num)
{
    
    while (num > 999)
     {
        num = num / 10;
     }
     return num % 10;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 99) Console.WriteLine("Третьей цифры нет.");
else 
{
    int result = GetDigit(number);
    Console.WriteLine($"{result}"); 
}