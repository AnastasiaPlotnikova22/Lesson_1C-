// 11. Напишите программу, которая 
// 1. выводит случайное трёхзначное число 
// 2. и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int rendomNumber = new Random().Next(100, 1000);
Console.WriteLine($" Случайное трёхзначное число => {rendomNumber}");

int finishNumber = GetNumber(rendomNumber);
Console.WriteLine($" Конечное число => {finishNumber}");

int GetNumber(int number)
{
    int firstNumber = number / 100;
    int secondNumber = number % 10;
    int result = firstNumber * 10 + secondNumber;
    return result;
}