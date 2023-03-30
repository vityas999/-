﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
//     0   1    2    3    

// 0   0,5   7   -2  -0,2
// 1    1  -3,3   8  -9,9
// 2    8   7,8 -7,1   9
double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max, int round = 1)
{                         //  0      1
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(num, round);
        }
        
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
    
}
Console.WriteLine("Введите количество строк для массива:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов для массива:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array2d = CreateMatrixRndDouble(m, n, 1, 10);
PrintMatrix(array2d);