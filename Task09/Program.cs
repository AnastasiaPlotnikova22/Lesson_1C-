// 09. Напишите программу, которая 
// 1. выводит случайное число 
// 2. из отрезка [10, 99] и 
// 3.показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // последнее число не входит в диапозон
Console.WriteLine($"Случайное число из отрезка 10 -99 => {number}");

int firstDigit = number / 10; // 7
int secondDigit = number % 10; // 8

if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");