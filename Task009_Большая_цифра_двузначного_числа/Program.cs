/*
9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

int N = new Random(). Next(10, 100);
System.Console.WriteLine(N);
if (N/10 > N%10)
System.Console.WriteLine(N/10);
else
System.Console.WriteLine(N%10);