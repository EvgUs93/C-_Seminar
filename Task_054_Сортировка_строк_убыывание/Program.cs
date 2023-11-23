/* 
Задание 54. Напишите программу, которая сортирует значения строк двумерного массива по убыванию.
*/

Console.Clear();
int[, ] testarray= CreateArray(4, 4);
PrintArray(testarray);
System.Console.WriteLine();
int[, ] newarray = SortArray(testarray);
PrintArray(newarray);


int[,] CreateArray(int m, int n)
{    
    int[,] NewArray = new int[m, n];

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

int[, ] SortArray(int[, ] array)
{
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            int max = j;
            for (int m = j; m < array.GetLength(1); m++)
            {
                if (array[i, max] < array[i, m])
                {
                    max = m;
                }
            }
            temp = array[i, j];
            array[i, j] = array[i, max];
            array[i, max] = temp;
        }
    }
    return array;
}
