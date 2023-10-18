/*
2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 ->  max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

System.Console.WriteLine("Введите первое число");
int N1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int N2 = Convert.ToInt32(Console.ReadLine());
if (N1 > N2)
{
    System.Console.WriteLine($"число {N1} бельше, чем {N2}");
}
else
{
    System.Console.WriteLine($"число {N2} бельше, чем {N1}");
}