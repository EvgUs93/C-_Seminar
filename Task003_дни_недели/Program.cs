/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Введите день недели");
int N = Convert.ToInt32(Console.ReadLine());
if (N == 1) System.Console.WriteLine("Понедельник");
if (N == 2) System.Console.WriteLine("Вторник");
if (N == 3) System.Console.WriteLine("Среда");
if (N == 4) System.Console.WriteLine("Четверг");
if (N == 5) System.Console.WriteLine("Пятница");
if (N == 6) System.Console.WriteLine("Суббота");
if (N == 7) System.Console.WriteLine("Воскресенье");