int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number} ");
int a = number % 10;
int b = number / 100;
int c = b * 10;
Console.WriteLine($"Наше число: {a + c} ");