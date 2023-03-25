﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int size, int min, int max, int round)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]} ; ");
        else Console.Write($"{arr[i]};");
    }
    Console.Write("]");
}

double MaxNumber(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

double MinNumber(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

double DifferenceMinMax(double min, double max)
{
    double difference = max - min;
    difference = Math.Round(difference, 1);
    return difference;
}


double[] array = CreateArray(4, 1, 99, 1);
double maxNumber = MaxNumber(array);
double minNumber = MinNumber(array);
double differenceMinMax = DifferenceMinMax(minNumber, maxNumber);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {differenceMinMax}");