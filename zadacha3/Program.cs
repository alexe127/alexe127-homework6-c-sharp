// Показать двумерный массив размером m×n заполненный целыми числами

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

int m = 7, n = 9;
int[,] array = new int[m, n];
fillArray(array, 10, 99);
printArray(array);
