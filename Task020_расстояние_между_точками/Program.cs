/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.Clear();

System.Console.Write("Введите Х первой точки:");
int FirstX = int.Parse(Console.ReadLine());
System.Console.Write("Введите Y первой точки:");
int FirstY = int.Parse(Console.ReadLine());
System.Console.Write("Введите Х второй точки:");
int SecondX = int.Parse(Console.ReadLine());
System.Console.Write("Введите Y первой точки:");
int SecondY = int.Parse(Console.ReadLine());

double distanse = Math.Round((Math.Sqrt(
    (FirstX - SecondX) * (FirstX - SecondX) + (FirstY - SecondY) * (FirstY - SecondY)
    )),2);
System.Console.WriteLine($"расстояние равно {distanse}");

