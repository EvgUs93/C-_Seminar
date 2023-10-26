/*35. Задайте одномерный массив из 123 случайных чисел. Найдите количество 
элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении 
сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

Console.Clear();
int[] our_array = NewArray(123, 0, 1000);
PrintArray(our_array);
Search(our_array);

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

void Search(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
            if(arr[i]>9 && arr[i]<100)
            {
                count += 1;
            }
    }
    System.Console.WriteLine($"Числа заданного диапазона встречаются {count}раз");


}