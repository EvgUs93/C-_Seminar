/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

System.Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());

double Pow(int a, int b)
{
    double result = Math.Pow(A, B);
    return result;
}

System.Console.WriteLine(Pow(A, B));