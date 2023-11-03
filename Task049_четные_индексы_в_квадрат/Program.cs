/*Валерия Шарандина 49. Задайте двумерный массив. Найдите элементы, у которых 
оба индекса чётные, и замените эти элементы на их квадраты.
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

int[,] Pow(int[,] array)
{
    int x = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if((i != 0) &&( j != 0))
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;
}

int[,] array = GetArray();
PrintArray(array);
System.Console.WriteLine();
int[,] array1 = Pow(array);
PrintArray(array1);

