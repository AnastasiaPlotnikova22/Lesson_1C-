// 16. Напишите программу, 
// 1. которая принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool SquareNumber(int num1, int num2)
{
    return((num1 * num1 == num2) || (num2 * num2 == num1));
}

Console.Write("Введите первое число : ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число : ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

bool result = SquareNumber(numberFirst, numberSecond);

if (result == true) Console.WriteLine ("Да");
else Console.WriteLine ("Нет");
