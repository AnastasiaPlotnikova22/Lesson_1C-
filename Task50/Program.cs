// 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента
// в массиве нет



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("|");
    }
}

Console.WriteLine("Введите позицию элемента:");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);

if(numA > array2D.GetLength(0) || numB > array2D.GetLength(1))
{
   Console.WriteLine("Такого элемента не существует");
}
else
{
    Console.WriteLine($"Значение элемента {numA} строки и {numB} столбца равно {array2D[numA-1,numB-1]}");
}

