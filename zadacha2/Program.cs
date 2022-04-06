﻿// Показать двумерный массив размером m×n заполненный вещественными числами
void fillArray(double[,] arr, double startEl, double endEl)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.NextDouble();
    }
}
void printArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int m = 3, n = 3;
double[,] array = new double[m, n];
fillArray(array, -10, 10);
printArray(array);

