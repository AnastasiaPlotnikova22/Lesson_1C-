// 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] matrix = CreateMatrixRndInt(5, 4, 1, 10);
Printmatrixix(matrix);
Console.WriteLine();

int sumLine = SumLineElements(matrix);
int minSum =0;
for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int tmp = SumLineElements(matrix);
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (minSum > tmp)
            {
                minSum = tmp;
                minSum = i;
            }
        }
    }

Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

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

void Printmatrixix(int[,] matrixix)
{

    for (int i = 0; i < matrixix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrixix.GetLength(1); j++)
        {
            Console.Write($"{matrixix[i, j],3} | ");
        }
        Console.WriteLine();
    }
}

int SumLineElements(int[,] matrix)
{   int sum = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
    }
    return sum;
}

