/*
30. Напишите программу, которая выводит массив из 8 элементов, заполненный 
нулями и единицами в случайном порядке.
*/

int[] GetRNDarray(int size)
{
    int[] array = new int[size]; //={1,0,0,1,0}
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
    System.Console.Write( arr[i] +" ");
    }
}

int[] userArray = GetRNDarray(8);
PrintArray(userArray);