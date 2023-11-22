/*
53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
*/

int [,] UserArray = CreateArray();
PrintArray(UserArray);
System.Console.WriteLine();
int [,] ChangedArray = ChangeArray(UserArray);
PrintArray(ChangedArray);


int[,] CreateArray()
{    
    int[,] NewArray = new int[3, 4];

    for(int i = 0; i < NewArray.GetLength(0); i ++)
        {
        for(int j = 0; j < NewArray.GetLength(1); j++)
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

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int x = array[i, j];
            array[i, j] = array[array.GetLength(0) - 1 - i, j];
            array[array.GetLength(0) - 1 - i, j] = x;
        }
    }
    return array;
}
