/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит
 их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

System.Console.WriteLine("Введите размер массива");
int user_size = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение минимального числа массива");
int user_min = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение");
int user_max = int.Parse(Console.ReadLine());

int[] NewUserArray(int size, int min, int max)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(min, max+1);
    }
    return Array;
}

void ShowArray(int[] new_array)
{
    for (int i = 0; i < new_array.Length; i++)
    {
        System.Console.Write(new_array[i]+" ");
    }
    //foreach(int i in new_array)
}

int[] user_array = NewUserArray(user_size, user_min, user_max);
ShowArray(user_array);