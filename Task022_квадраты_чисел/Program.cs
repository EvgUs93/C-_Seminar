/*
22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/


Console.Clear();
System.Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
for (int i=1; i <= N; i++)
{
    if (i <N)
    {
         Console.Write(Math.Pow(i, 2)+", " );
    }
    else
    {
        Console.Write(Math.Pow(i, 2)+". " );
    }
}