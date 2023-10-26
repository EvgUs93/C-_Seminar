/*Напишите программу, которая находит сумму элементов с нечетными индексами в 
одномерном массиве целых чисел и выводит результат на экран.
Программа должна иметь метод SumOddElements, который принимает массив целых 
чисел и возвращает сумму элементов с нечетными индексами в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на 
экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
*/

Console.Clear();
int[] our_array = NewArray(5, 1, 10);
PrintArray(our_array);
System.Console.WriteLine();
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
    int sum = 0;
    for (int i = 0; i < arr.Length; i ++)
    {
        if (i%2 == 1) sum += arr[i];
    }
    System.Console.WriteLine($"сумма числел с нечетным индексом равна {sum}.");

}