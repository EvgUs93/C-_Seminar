/*51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
диагонали (с индексами (0,0); (1;1) и т.д.
*/

Console.Clear();

int[,] GetArray()
{
    int[,] array = new int[5, 5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
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

int Sum(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) result += array[i, j];
        }
    }
    return result;
}

int[,] array2 = GetArray();
PrintArray(array2);
System.Console.WriteLine();
int sum = Sum(array2);
System.Console.WriteLine(sum);