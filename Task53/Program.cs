// 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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
            Console.Write($"{matrix[i, j],3} | ");
        }
        Console.WriteLine();
    }
}

void RepleceRows(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(1); i++)
   {
      int tmp = 0;
      tmp = matrix[0, i];
      matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
      matrix[matrix.GetLength(0) - 1, i] = tmp;
   }
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
RepleceRows(matrix);
PrintMatrix(matrix);