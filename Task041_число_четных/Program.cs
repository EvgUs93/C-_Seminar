/*41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 
0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2; -1, -7, 567, 89, 223-> 3
*/

Console.Clear();
int len = 5;

int[] UserArray(int len)
{
    int[] array = new int[len];
    for(int i = 0; i < len; i++)
    {
        System.Console.WriteLine("введите число");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int Counts(int[] user_array)
{
    int count = 0;
    for (int i = 0; i < user_array.Length; i++)
    {
        if ( user_array[i] > 0) count++;
    }
    return count;
}

void Print(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        System.Console.Write(array[i]+ "\t");
    }
}
int[] arr = UserArray(5);
int count = Counts(arr);
System.Console.WriteLine("Вы ввели числа: ");
Print(arr);
System.Console.WriteLine();
System.Console.WriteLine($"Среди них {count} чисел больше 0");
