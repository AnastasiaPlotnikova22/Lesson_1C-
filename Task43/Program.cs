//  43: Напишите программу, которая 
//  найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (b1 - b2)/(k2 - k1);
// double y = k2 * x + b2;

//Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

double PointX(double ba1 ,double ka1 ,double ba2 ,double ka2)
{
    double x = (b1 - b2)/(k2 - k1);
    return x;
}

double PointY(double ba1 ,double ka1 ,double ba2 ,double ka2 ,double pointX)
{
    double y = k2 * pointX + b2;
    return y;
}

double pointX = PointX( b1 , k1 , b2 , k2);
double pointY = PointY( b1 , k1 , b2 , k2, pointX);
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {pointX}, Y: {pointY}");
