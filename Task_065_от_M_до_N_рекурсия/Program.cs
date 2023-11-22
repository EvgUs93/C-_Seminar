/*
65. Задайте значения M и N. Напишите программу, которая выведет все натуральные 
числа в промежутке от M до N.
*/

Console.Clear();
Diapason(4, 10);

void Diapason(int M, int N)
{
if ( M > N) return;
else
{
    System.Console.Write(M + " ");
    Diapason(M + 1, N);
}
}

