/* 33. Задайте массив. Напишите программу, которая определяет, присутствует 
ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

Console.Clear();
int[] array3 = NewArray(10, -10, 11);
PrintArray(array3);
Search(array3, 4);


int[] NewArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array1)
{
    System.Console.WriteLine("Наш массив:");
    for (int i = 0; i < array1.Length; i++)
        System.Console.Write(array1[i] + " ");
}

void Search(int[] arr, int number)
{
    int count = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            System.Console.WriteLine($"Заданное число на {i + 1} позиции.");
            break;
        }
        else
        {
            count = count + 1;
            if (count > arr.Length)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Заданного числа в массиве нет.");
            }
        }
    }
}