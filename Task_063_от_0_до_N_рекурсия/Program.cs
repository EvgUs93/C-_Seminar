/*63. Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от 1 до N.
*/
Console.Clear();
int usernum = UserNum("Введите число");
Print(usernum);

int UserNum(string message)
{
    System.Console.WriteLine(message);
    int userN = int.Parse(Console.ReadLine());
    return userN;
}

void Print(int number, int start = 1)
{
    if (number < start)
    return;
    else
    {
        System.Console.Write(start + " ");
        Print(number, start + 1);
    }
}
