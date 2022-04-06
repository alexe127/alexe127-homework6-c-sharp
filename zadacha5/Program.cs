﻿// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void fillArray(int[,] arr, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(start, end + 1);
    }
}

void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void changeArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0) 
            arr[i, j] = arr[i, j] * arr[i, j];
    }

}

int m = 5, n = 5;
int[,] array = new int[m, n];
fillArray(array, 2, 10);
printArray(array);
changeArray(array);
printArray(array);