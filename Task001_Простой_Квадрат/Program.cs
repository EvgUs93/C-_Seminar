/*
1. Напишите программу, которая на вход принимает два числа и проверяет,
 является ли первое число квадратом второго. 

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет
*/

System.Console.Write("Введите первое число:");
int N1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число:");
int N2 = Convert.ToInt32(Console.ReadLine());
if (N1 == N2*N2)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}