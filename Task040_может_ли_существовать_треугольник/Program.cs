/*40. Напишите программу, которая принимает на вход три числа и проверяет,
 может ли существовать треугольник с сторонами такой длины.
*/

int[] UserArray()
{
    int[] user_array = new int[3];
    for (int i = 0; i < 3; i++)
    {
        System.Console.WriteLine($"Введите {i+1} сторону:");
        user_array[i] = int.Parse(Console.ReadLine());
        if (user_array[i] > 0) continue;
        else
        {
            System.Console.WriteLine(" строноа треугольника не может иметь такое значение");
            break;
        }
    }
    return user_array;
}

void Test(int[] arr)
{
   if (arr[0]< arr[1] + arr[2] && arr[1] < arr[0] + arr[2] && arr[2] < arr[0]+arr[1])
   System.Console.WriteLine($"Треугольник со сторонами {arr[0]}, {arr[1]}, {arr[2]} может быть");
   else System.Console.WriteLine("Такого треугольника быть не может");
}

int[] user_array = UserArray();
Test(user_array);