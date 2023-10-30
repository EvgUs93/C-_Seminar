/*42. Напишите программу, которая будет преобразовывать десятичное число в 
двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.Clear();
void InBinaryCode(int num)
{
    string result = "";
    int binary = 0;
    for (int i = num; i > 0; i /= 2)
    {
        binary = i %2;
        result = binary + result;
    }
    System.Console.WriteLine(result);
}

InBinaryCode(10);