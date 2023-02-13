﻿// 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.


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

double ArithmeticMean(int[,] matrix)
{
    double arr = default;
    // int size = matrix.GetLength(0);
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += (matrix[i, j]);
        }
        arr = sum /matrix.GetLength(0) ;
        Console.WriteLine( arr +";");
    }
    return arr;
}

int[,] matr = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matr);

double arithmeticMean = ArithmeticMean(matr);
// Console.WriteLine();
// Console.WriteLine($"Среднее арифметическое столбца -> {arithmeticMean}" + ";");