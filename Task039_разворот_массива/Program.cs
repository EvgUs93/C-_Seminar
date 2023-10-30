/*39. Напишите программу, которая разворачивает одномерныйй массив.(Меняет 
первый и последний элемент местами и тд.)
*/

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void Print(int[] arr)
{
    foreach (int i in arr)
    {
        System.Console.Write(i + "\t");
    }
}

int[] Revers(int[] arr1)
{
    int num = 0;
    for(int i = 0, j = (arr1.Length - 1); i < j; i++, j--)
    {
        num = arr1[j];
        arr1[j] = arr1[i];
        arr1[i] = num;
    }
    return arr1;
}
Console.Clear();

System.Console.WriteLine("введите число значений в массиве:");
int size = int.Parse(Console.ReadLine());
int[] user_array = GetRnd(size);
Print(user_array);
System.Console.WriteLine();
Print(Revers(user_array));