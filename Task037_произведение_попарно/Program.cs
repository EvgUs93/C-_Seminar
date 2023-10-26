/*37. Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.Clear();
int[] test_array = NewArray(5, -10, 10);
PrintArray(test_array);
System.Console.WriteLine();
if (test_array.Length % 2 == 0)
{
    int[] test2 = Product1(test_array);
    PrintArray(test2);
}
else
{
    int[] test2 = Product2(test_array);
    PrintArray(test2);
}


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

int[] Product1(int[] array3)
{
    int[] array4 = new int[array3.Length / 2];
    for (int i = 0; i < array3.Length / 2; i++)
    {
        array4[i] = array3[i] * array3[array3.Length - 1 - i];
    }
    return array4;
}
int[] Product2(int[] array3)
{
    int[] array4 = new int[array3.Length / 2 + 1];
    for (int i = 0; i < array3.Length / 2 + 1; i++)
    {
        if (i < array3.Length / 2)
        {
            array4[i] = array3[i] * array3[array3.Length - 1 - i];
        }
        else
        {
            array4[i] = array3[i];
        }
    }
    return array4;
}