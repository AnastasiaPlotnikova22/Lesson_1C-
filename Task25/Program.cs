// 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int numbet1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numbet2 = Convert.ToInt32(Console.ReadLine());

double result = Degree(numbet1, numbet2);
Console.WriteLine($"Возведение числа в натуральную степень {result}");

double Degree(int num1, int num2)
{
    return (Math.Pow(num1, num2));
}