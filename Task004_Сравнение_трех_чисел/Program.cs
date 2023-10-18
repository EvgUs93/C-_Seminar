/*
4. Напишите программу, которая принимает на вход три числа и выдаёт 
максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

System.Console.WriteLine("Введите первое число");
int N1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int N2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите Третье число");
int N3 = Convert.ToInt32(Console.ReadLine());

if (N1>N2)
{
    if (N1>N3)
    {
        System.Console.WriteLine($"самое большое число {N1}");
    }
    else
    {
        System.Console.WriteLine($"самое большое число {N3}");
    }
}
else
{
    if (N2>N3)
    {
        System.Console.WriteLine($"самое большое число {N2}");
    }
    else
    {
        System.Console.WriteLine($"самое большое число {N3}");
    }
}