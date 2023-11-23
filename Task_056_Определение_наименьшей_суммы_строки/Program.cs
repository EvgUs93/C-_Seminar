/*
Задание 65. Определение строки с наименьшей суммой элементов.
*/

Console.Clear();
int[, ] userarray = CreateArray(4, 4);
PrintArray(userarray);
System.Console.WriteLine();
FindMinStr(userarray);

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

void FindMinStr(int[,] array)
{
    int[] sumarray = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength( 0 ); i ++ )
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength( 1 ); j++)
        {
            sum = sum + array[i, j];
        }
        sumarray[i] = sum;
    }
    int min = 0;
    for (int k = 0; k < sumarray.Length; k++)
    {
        if(sumarray[min] > sumarray[k]) min = k;
    }
    System.Console.Write($"Наименьшая сумма в строке № {min+1} со значением {sumarray[min]}.");
}