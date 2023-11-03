/*48. Задайте двумерный массив размера m на n, каждый элемент в массиве 
находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
*/

Console.Clear();

int[,] GetArray()
{
    int[,] array = new int[5, 5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
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
            Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] array = GetArray();
PrintArray(array);


