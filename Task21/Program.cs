//  21. Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distanse(int a1, int b1, int c1, int a2, int b2, int c2)
{
double result = Math.Sqrt(Math.Pow((a2-a1), 2) + Math.Pow((b2 - b1), 2) + Math.Pow((c2 -c1), 2));
return result;
}

Console.WriteLine("Введите координыты первой точки ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("S1: ");
int s1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координыты второй точки ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("S2: ");
int s2 = Convert.ToInt32(Console.ReadLine());

double distanse = Distanse(x1, y1, s1, x2, y2, s2);
double distanse1 = Math.Round(distanse, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками {distanse1}");
