/*
19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
14212 -> нет
23432 -> да
12821 -> да
*/
Console.Clear();
System.Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
if (number>99999 || number<10000)
{
    System.Console.WriteLine("вы ввели не 5-тизначное число");
}
else
{
    int num1 = number / 10000;
    int num2 = number % 10000 / 1000;
    int num4 = number % 100 / 10;
    int num5 = number % 10;

    if (num1 == num5 && num2 == num4)
    {
        System.Console.WriteLine("является");
    }
    else
    {
       System.Console.WriteLine("не является");
    }
}
/*for (int i = N; i > 0; i /= 10)
{
    revN= revN * 10 +int % 10;
}*/