/*
8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

System.Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i<=N ;i+=2)
{
    if (i<N)
        System.Console.Write(i+", ");
    else
        System.Console.Write(i+".");
}
