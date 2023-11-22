/*
69. Напишите программу, которая на вход принимает два числа A и B, и возводит 
число А в целую степень B с помощью рекурсии.
*/

Console.Clear();
int test = Pow(5, 3);
System.Console.WriteLine(test);

int Pow(int number, int square)
{
    if ( square == 1)
    {
        return number;
    }
    else
    {
        return number * Pow(number, square - 1);
    }
}
