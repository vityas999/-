// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j], 3} ");
    }
    Console.WriteLine("|");
    }
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multiplicationMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(1) ; k++)
            {
                multiplicationMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return multiplicationMatrix;
}

int[,] array2d1 = CreateMatrixRndInt(4, 3, 1, 10);
int[,] array2d2 = CreateMatrixRndInt(4, 3, 1, 10);
int[,] myltiplicationMatrix = MultiplicationMatrix(array2d1, array2d2);

Console.WriteLine("Первая Матрица:");
PrintMatrix(array2d1);
Console.WriteLine();

Console.WriteLine("Вторая Матрица:");
PrintMatrix(array2d2);
Console.WriteLine();

if (array2d1.GetLength(1) == array2d2.GetLength(0))
{
    Console.WriteLine("Результат произведения двух матриц:");
    PrintMatrix(myltiplicationMatrix);
}
else Console.WriteLine("ОШИБКА - Первую матрицу можно умножить на вторую матрицу только в том случае, если число столбцов первой матрицы равняется числу строк второй матрицы. В указанных матрицах это условие не выполняется.");