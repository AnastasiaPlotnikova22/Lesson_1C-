// 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

bool GetNumber(int num)
{
    return ((num == 6) || (num == 7));
}

Console.WriteLine("Введите  число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());



while (number < 1 || number > 7)
{
    Console.WriteLine("Введено неверное число недели.");
}

bool numDerday = GetNumber(number);

if (numDerday == true) Console.WriteLine ("Выходной день");
else Console.WriteLine ("Не выхлдной день");
