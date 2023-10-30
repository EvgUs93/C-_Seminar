/*44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два 
числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();
Fibanachi(5);

void Fibanachi(int num)
{
    if (num == 0) System.Console.Write("1");
    if (num == 1) System.Console.Write("0, 1");
    if (num > 2)
    {
        int[] fib = new int[num];
        fib[0] = 0; System.Console.Write(fib[0] + " ");
        fib[1] = 1; System.Console.Write(fib[1] + " ");
        for (int i = 2; i < num; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
            System.Console.Write(fib[i] + " ");
        }
    }
}