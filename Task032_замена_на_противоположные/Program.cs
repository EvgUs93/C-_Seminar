/*32. Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

Console.Clear();
int[] Arr = NewArray(5, -9, 10);
PrintArray(Arr);
System.Console.WriteLine();
PrintMirrorArray(Arr);



int[] NewArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array1)
{
    System.Console.WriteLine("Наш массив:");
    for(int i = 0; i < array1.Length; i++)
        System.Console.Write(array1[i] + " ");
}

void PrintMirrorArray(int[] array2)
{
    int[] array3 = new int[array2.Length];
    for (int i = 0; i < array2.Length; i++)
    {
        array3[i] = -array2[i];
    }
    System.Console.WriteLine("Новый массив:");
    foreach (int count in array3)
        System.Console.Write(count + " ");
}