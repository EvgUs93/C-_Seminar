/*
28. Напишите программу, которая принимает на вход число N и выдаёт 
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

System.Console.WriteLine("Веедите число:");
int user_num = int.Parse(Console.ReadLine());

int Fact(int number)
{
    int i = 1;
    int result = 1;
    while (i <= number)
    {
        result = result * i;
        i++;
    }
    return result;
}

int res = Fact(user_num);
System.Console.WriteLine($"Факториал числа {user_num} {res}");