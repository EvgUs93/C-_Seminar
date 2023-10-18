/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

System.Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number%100/10;
System.Console.WriteLine($"{number2}");