/*37. Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.Clear();
int[] test_array = NewArray(10, -10, 10);
PrintArray(test_array);
System.Console.WriteLine();
PrintArray(Product(test_array));


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
        System.Console.Write(array1[i] + ", ");
}

int[] Product(int[] array3)
{
    int[] array4 = new int[array3.Length / 2];
    for (int i = 0; i < array3.Length / 2; i++)
    {
        array4[i] = array3[i] * array3[array3.Length - 1 - i];
    }
    return array4;
}