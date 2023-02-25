// 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов
//  в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа: ");
int number1 =Convert.ToInt32(Console.ReadLine());
int number2 =Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number1, number2);
Console.Write(sumDigits);
// SumDigits(number1, number2);

int SumDigits(int num1, int num2)
{
     if (num1 == num2) return num2;
     return num1 + SumDigits(num1 + 1, num2);
}