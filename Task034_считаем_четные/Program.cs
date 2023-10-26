/*34.Напишите программу, которая подсчитывает количество четных элементов в 
массиве целых положительных трехзначных чисел и выводит результат на экран.

Программа должна иметь метод CountEvenElements, который принимает массив целых 
положительных трехзначных чисел и возвращает количество четных элементов в 
массиве.

Программа должна иметь метод PrintArray, который выводит элементы массива на 
экран.

При выводе элементы массива должны быть разделены символом табуляции "\t".

Если аргументы командной строки не переданы, программа использует массив по 
умолчанию, который содержит следующие значения: {100, 102, 105, 166, 283, 764,
 300, 499, 133}.*/


Console.Clear();
int[] our_array = NewArray(10, 100, 1000);
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
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }
    }
    System.Console.WriteLine($"Четные числа встречаются {count} раз");


}