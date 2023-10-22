/*26. Напишите программу, которая принимает на вход число и выдаёт количество 
цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

System.Console.WriteLine("Веедите число:");
int user_num = int.Parse(Console.ReadLine());

int Numb(int number)
{
    int result = 0;
    for (int i = number; i > 0; i/=10)
    {
        result+=1;
    }
    return result;
}

int res = Numb(user_num);
System.Console.WriteLine($"В числе {user_num} {res} цифр");