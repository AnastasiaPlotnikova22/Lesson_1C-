// 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер плоскости: ");
string? number = Console.ReadLine(); //int number = Convert.ToInt32(Console.ReadLine());

string quarter= Quarter(number!);

Console.WriteLine(quarter);  //Console.WriteLine($"{quarter}");

string Quarter(string num) // (int num)
{
    // if(xc > 0 && yc > 0) return 1;
    // if(xc < 0 && yc > 0) return 2;
    // if(xc > 0 && yc < 0) return 3;
    // if(xc < 0 && yc > 0) return 4;
    // return 0;

    // if(num == 1) return "x > 0 и y > 0";
    // if(num == 2) return "x < 0 и y > 0";
    // if(num == 3) return "x > 0 и y < 0";
    // if(num == 4) return "x < 0 и y > 0";
    // return "Введены неккоректные координаты";

    switch(num)
    {
        case "1" : return "Допустимые координаты: x > 0 и y > 0";  
        case "2" : return "Допустимые координаты: x < 0 и y > 0"; 
        case "3" : return "Допустимые координаты: x > 0 и y < 0"; 
        case "4" : return "Допустимые координаты: x < 0 и y > 0"; 
        default: return "Неккоректный ввод";
    }
}