System.Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1%number2 == 0)
{
  System.Console.WriteLine("кратно");
}
else
{
  int number3 = number1%number2;
  System.Console.WriteLine($"некратно, остаток {number3}");
}