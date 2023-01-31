// 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double d = 5.09997623455;
// double dRuynd = Math.Round(d, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(dRuynd);

Console.WriteLine("Введите координыты первой точки ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координыты второй точки ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distanse = Distanse(x1, y1, x2, y2);
double distanse1 = Math.Round(distanse, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками {distanse1}");


double Distanse(int a1, int b1, int a2, int b2)
{
double result = Math.Sqrt(Math.Pow((a2-a1), 2) + Math.Pow((b2 - b1), 2));
return result;
}