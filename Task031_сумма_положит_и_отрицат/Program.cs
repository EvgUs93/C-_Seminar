/*31. Задайте массив из 12 элементов, заполненный случайными числами из 
промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов 
массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел
 равна 29, сумма отрицательных равна -20.
 */
Console.Clear();

int[] some_array = NewArray();
int positive = SumPositive(some_array);
int negative = SumNegative(some_array);
System.Console.WriteLine($"Массив:");
PrintArray (some_array);
System.Console.WriteLine($"Сумма положительных цифр {positive}");
System.Console.WriteLine($"Сумма отрицательных цифр {negative}");
 
int[] NewArray()
 {
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
 }

 int SumPositive (int[] arr)
 {
    int sum_pos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        {
            sum_pos += arr[i];
        }
    }
    return sum_pos;
 }

  int SumNegative (int[] arr1)
 {
    int sum_neg = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i]<0)
        {
            sum_neg += arr1[i];
        }
    }
    return sum_neg;
 }

void PrintArray(int[] array)
{
    foreach(int i in array)
    System.Console.Write(i + " ");
}
 