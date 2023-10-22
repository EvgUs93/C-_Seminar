/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.WriteLine("Введите число");
int user_num = int.Parse(Console.ReadLine());

int Sum(int num)
{
    int result = 0;
    for (int i = num; i > 0; i /= 10)
    {
       result += num%10;
    num /=10;
    }
    return result;
}

int user_sum = Sum(user_num);
System.Console.WriteLine($"Сумма цифр в числе {user_num} равна {user_sum}");