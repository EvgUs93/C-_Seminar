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
                     //Math.Round(а, б) округляет а до б знаков после запятой
double distanse = Math.Round((Math.Sqrt( //Math.Sqrt(а) извлекает корень а
    Math.Pow((FirstX - SecondX), 2) + //Math.Pow (а, б) возводит а в степень б
    Math.Pow((FirstY - SecondY), 2)
    )), 2);
System.Console.WriteLine($"расстояние равно {distanse}");

