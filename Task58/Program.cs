// 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstMartrix = CreateFirstMartrix(2, 4, 0, 4);
PrintMatrix(firstMartrix);
Console.WriteLine();
int[,] secomdMartrix = CreateSecomdMartrix(2, 4, 0, 10);
PrintMatrix(secomdMartrix);

int[,] resultMatrix = MultiplyMatrix(firstMartrix, secomdMartrix); 
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);

int[,] CreateSecomdMartrix(int rows, int columns, int min, int max)
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

int[,] CreateFirstMartrix(int rows, int columns, int min, int max)
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
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j],3}  ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix)
{
      int[,] resultMatrix = new int[firstMartrix.GetLength(0), secomdMartrix.GetLength(1)];
      for (int i = 0; i < firstMartrix.GetLength(0); i++)
      {
        for (int j = 0; j < secomdMartrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                resultMatrix[i,j] += firstMartrix[i, j] * secomdMartrix[i, j];
            }
        }
      }
      return resultMatrix;
}