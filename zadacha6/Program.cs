// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
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

            Console.Write(String.Format("{0,4}", arr[i, j]));
        Console.WriteLine();
    }
    Console.WriteLine();
}
void printIndexNumber(int[,] arr, int num)
{
    Console.WriteLine($"число {num} находится:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)

            if (arr[i, j] == num)
            {
                Console.WriteLine($" строка {i} столбец {j}");
            }
    }    
}
bool IndexNumber(int[,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] == num)
            {
                return true;
            }
    }
    return false;
}

int m = 5, n = 6;
int[,] array = new int[m, n];
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "3");

fillArray(array, 0, 10);
printArray(array);
if (IndexNumber(array, number)) printIndexNumber(array, number);
else Console.WriteLine($"числа {number} нет в массиве");