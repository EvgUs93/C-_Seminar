/*
52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Console.Clear();
int[,] userarray = CreateArray(3, 4);
PrintArray(userarray);
System.Console.WriteLine();
System.Console.Write("Cредние показатели по стольбцам: ");
Midle(userarray);



int[,] CreateArray(int m, int n)
{
    int[,] NewArray = new int[m, n];

    for (int i = 0; i < NewArray.GetLength(0); i++)
    {
        for (int j = 0; j < NewArray.GetLength(1); j++)
        {
            NewArray[i, j] = new Random().Next(1, 10);
        }
    }
    return NewArray;
}


void PrintArray(int[,] array)
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

void Midle(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength (0); j ++)
        {
            sum = sum + array[j, i];
        }
        double result = sum / array.GetLength(0);
        System.Console.Write( Math.Round(result, 1 ) + " ");
    }
}
