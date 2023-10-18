/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/
Console.Clear();
System.Console.Write("Введите номер четверти:");
int number = int.Parse(Console.ReadLine()); 
if (number > 4 || number < 1)
{
    System.Console.WriteLine("введенное число не является номером четверти");
}
if (number == 1)
{
    System.Console.WriteLine("Х от 1 до бесконечности, У от 1 до бесконечности");
} 
if (number == 2)
{
    System.Console.WriteLine("Х от -1 до -бесконечности, У от 1 до бесконечности");
} 
if (number == 3)
{
    System.Console.WriteLine("Х от -1 до -бесконечности, У от -1 до -бесконечности");
} 
if (number == 4)
{
    System.Console.WriteLine("Х от 1 до бесконечности, У от -1 до -бесконечности");
} 