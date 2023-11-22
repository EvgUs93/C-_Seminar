/*67. Напишите программу, которая будет принимать на вход число и возвращать 
сумму его цифр.
*/

Console.Clear();
int sum = Summ(666);
System.Console.WriteLine(sum);
int Summ(int numb)
{
    int result = 0;
    if ( numb == 0)
    return 0;
    else
    {
        return numb % 10 + Summ( numb / 10);
    }
}