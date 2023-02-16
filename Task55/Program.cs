// 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

int[,] ReplecRowsColumns(int[,] matrix)
{
   int[,] tmpArray = new int[matrix.GetLength(0), matrix.GetLength(1)] ;
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        tmpArray[j,i] = matrix[i, j];
      }
   }
   return tmpArray;
}

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
if(matrix.GetLength(0) == matrix.GetLength(1)) 
{
    int[,] newMatrix = ReplecRowsColumns(matrix);
    PrintMatrix(matrix);
}
else Console.WriteLine("Число строк и столбцов несовпадает!");



// int[,] GenerateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// string PrintMatrix(int[,] matrix)
// {
//     string str = string.Empty;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         str += "[";
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3} ";
//             else str += $" {matrix[i, j],3}, ";
//         }
//         str += "]\n";
//     }
//     return str;

// }

// int[,] ChangeRowsOnColumns(int[,] matrix)
// {
// int[,] temporaryMatrix = new int[matrix]