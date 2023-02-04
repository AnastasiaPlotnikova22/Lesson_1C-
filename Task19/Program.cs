// 19.Напишите программу, которая 
// 1 . принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrome(string num)
{
    return(num[0] == num[4] && num[1] == num[3]);
}

Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();

if(number! .Length == 5)
{
    bool result = Palindrome(number);
    Console.WriteLine($"{result}"); 
} 
else Console.WriteLine("Введено неверное число.");
