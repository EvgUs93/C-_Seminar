/*45. Напишите программу, которая будет создавать копию заданного одномерного 
массива с помощью поэлементного копирования. 
*/

Console.Clear();
int[] array = NewRND(5);
int[] clone = Clone(array);
Print(array);
System.Console.WriteLine();
Print(clone);

int[] NewRND(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void Print(int[] array)
{
    foreach (int i in array)
        System.Console.Write(i + "\t");
}

int[] Clone(int[] array)
{
    int[] array_clone = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        array_clone[i] = array[i];
    }
    return array_clone;
}






