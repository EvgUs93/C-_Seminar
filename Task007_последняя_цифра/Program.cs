/*
7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/
int N = new Random().Next(100, 1000) ;
//System.Console.WriteLine("Введите трехзначное число");
//int N = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(N);
    System.Console.WriteLine(N % 10);
