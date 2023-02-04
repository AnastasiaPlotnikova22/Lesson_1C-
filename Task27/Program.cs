// 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers= SumNumbers(number);
Console.WriteLine($"Сумма чцифр в числе = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    int a1 = num % 10;
    int a2 = num / 10 % 10;
    int a3 = num / 100 % 10;
    int a4 = num / 1000;
    sum = a1 + a2 + a3 + a4;
    return sum;
}