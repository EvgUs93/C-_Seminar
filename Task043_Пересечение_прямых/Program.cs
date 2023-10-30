/*43. Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и 
k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

Console.Clear();
double[] line1 = UserLine(1);
double[] line2 = UserLine(2);
if (ValidatiLines(line1, line2))
{
    double[] coord = new double[2];
    coord[0] = ( line1[1] - line2[1])/(line2[0] - line1[0]);
    coord[1] = line1[0] * coord[0] + line1[1];
    System.Console.WriteLine($"Точка пересечения заданных прямых имеет координаты: ");
    System.Console.Write($"X = {coord[0]}, Y = {coord[1]}");
}

double[] UserLine(int line)
{
    double[] user_line = new double[2];
        System.Console.WriteLine($"Введите коэффициент линии {line}");
    user_line[0] = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine($"Введите константу линии {line}");
    user_line[1] = Convert.ToDouble(Console.ReadLine());
    return user_line;
}

bool ValidatiLines(double[] line1, double[] line2)
{
    if (line1[0] == line2[0])
    {
        if (line1[1] == line2[1])
        {
            System.Console.WriteLine("прямые совпадают");
            return false;
        }
        else
        {
            System.Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}


