/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
int sum = Summ(4, 8);
System.Console.WriteLine(sum);
int Summ(int start, int finish)
{
    if ( start > finish)
    return 0;
    else
    {
        return start + Summ( start +1, finish);
    }
}