/*
47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

Console.Clear();

double[, ] array = CreateArray(4, 4);
PrintArray(array);

double[,] CreateArray(int m, int n)
{    
    double[,] NewArray = new double[m, n];

    for(int i = 0; i < NewArray.GetLength(0); i ++)
        {
        for(int j = 0; j < NewArray.GetLength(1); j++)
            {
            NewArray[i, j] = new Random().Next(1, 10) + Math.Round(new Random().NextDouble(), 1);
            }
        }
    return NewArray;
}


void PrintArray(double[,] array)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}