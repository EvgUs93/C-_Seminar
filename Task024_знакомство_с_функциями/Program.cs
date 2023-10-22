/*24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму 
чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

System.Console.WriteLine("введите число");
int user_num = int.Parse(Console.ReadLine());

int Sum(int N)
{
    int result =0;
    for (int i= 1; i <= N; i++)
    {
        result = result + i;
    }
    return result;
}

int sum = Sum(user_num);
System.Console.WriteLine($"Сумма чисел от 1 до {user_num} равна {sum}");