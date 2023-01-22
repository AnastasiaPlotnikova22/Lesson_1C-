// 02: Напишите программу, 

// 1. которая на вход принимает два числа 
// 2. и выдаёт, какое число большее, а какое меньшее.
// 3. Вывод результата

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число1 : ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2 : ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine(number2);
}