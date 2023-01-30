// 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер плоскости");
int number = Convert.ToInt32(Console.ReadLine());

string quarter= Quarter(number);

Console.WriteLine($"{quarter}");

string Quarter(int num)
{
    // if(xc > 0 && yc > 0) return 1;
    // if(xc < 0 && yc > 0) return 2;
    // if(xc > 0 && yc < 0) return 3;
    // if(xc < 0 && yc > 0) return 4;
    // return 0;

    if(num == 1) return "x > 0 и y > 0";
    if(num == 2) return "x < 0 и y > 0";
    if(num == 3) return "x > 0 и y < 0";
    if(num == 4) return "x < 0 и y > 0";
    return "Введены не кореретные координаты";
}