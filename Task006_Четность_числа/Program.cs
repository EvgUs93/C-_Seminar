/*
6.Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

System.Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
if (N%2 == 0) System.Console.WriteLine($"Число {N} четное");
else System.Console.WriteLine($"Число {N} нечетное");