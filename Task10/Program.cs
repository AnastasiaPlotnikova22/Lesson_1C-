// 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и
// 2. на выходе показывает вторую цифру этого числа.


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int finishNumber = GetNumber(number);

if(number < 1000 && number > 99) Console.WriteLine($"Вторая цифра числа {finishNumber}");
else Console.WriteLine("Не является трехзначным числом.");

int GetNumber(int num)
{
    int firstNumber = num / 10;
    int result = firstNumber % 10;
    return result;
}