/*Напишите программу для работы с массивом вещественных чисел.

Реализуйте класс ArrayOperations, который содержит следующие статические 
методы:

FindMax(double[] array): Метод принимает на вход массив вещественных чисел 
array и возвращает максимальное число из массива.

FindMin(double[] array): Метод принимает на вход массив вещественных чисел 
array и возвращает минимальное число из массива.

CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив 
вещественных чисел array и возвращает разницу между максимальным и минимальным 
числами в массиве.

PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на 
вход массив array и выводит его элементы с двумя знаками после запятой через 
табуляцию.
*/

Console.Clear();
double[] test_array = NewArray(5, -10, 10);
PrintArray(test_array);
System.Console.WriteLine();
System.Console.WriteLine("Разность между максимумом и минимумом " + 
Math.Round(FindDif(test_array), 2));



double[] NewArray(int size, double min, double max)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}

void PrintArray(double[] array1)
{
    System.Console.WriteLine("Наш массив:");
    for (int i = 0; i < array1.Length; i++)
        System.Console.Write(Math.Round(array1[i], 2) + ", ");
}

double FindMax(double[] array2)
{
    double max = array2[0];
    for (int i = 0; i < array2.Length; i++)
    {
        if (max < array2[i])
        {
            max = array2[i];
        }
    }
    return max;
}

double FindMin(double[] array3)
{
    double min = array3[0];
    for (int i = 0; i < array3.Length; i++)
    {
        if (min > array3[i])
        {
            min = array3[i];
        }
    }
    return min;
}

double FindDif(double[] array4)
{
    double dif = FindMax(array4) - FindMin(array4);
    return dif;
}
