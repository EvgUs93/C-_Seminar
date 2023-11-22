/*50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же
 указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 и 2 -> 2
1 и 7 -> такого числа в массиве нет
*/

Console.Clear();
int[, ] userarray = CreateArray(4, 4);
PrintArray(userarray);
int number = FindElement(userarray, 2, 4);
if (number == -1) System.Console.WriteLine("Введено неверное значение");
else System.Console.WriteLine(number);

int FindElement(int[, ] array, int str, int col)
{
    if (str >= array.GetLength(0) || col >= array.GetLength(1))
    {
        return -1;
    }
    else
    {
        return array[str, col];
    }
}

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
