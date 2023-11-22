/*
55. Задайте двумерный массив. Напишите программу, которая заменяет строки на 
столбцы. В случае, если это невозможно, программа должна вывести сообщение для 
пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/

Console.Clear();
int[,] userarray = CreateArray();
PrintArray(userarray);
System.Console.WriteLine();
int[,] changedarray = ChangeArray(userarray);
PrintArray(changedarray);

int[,] CreateArray()
{    
    int[,] NewArray = new int[4, 4];

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
    int[,] array1 = new int[array.GetLength(0), array.GetLength(1)];
    if (array.GetLength(0) == array.GetLength(1))
        {
            
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array1[j, i] = array[i, j];
                }
            }
        }
        else
        {
            System.Console.WriteLine("Заменить строки на столбцы невозможно");
        }
    return array1;
}