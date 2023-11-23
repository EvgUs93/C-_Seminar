/*Задача 58. Умножение матриц*/
Console.Clear();
int[,] matrix1 = CreateArray(2,2);
int[,] matrix2 = CreateArray(2,2);
//int[,] matrix1 = new int[,]{{1, 2},{ 3,4}};       для проверки
//int[,] matrix2 = new int[,]{{5, 6}, {7, 8}};
PrintArray(matrix1);
System.Console.WriteLine();
PrintArray(matrix2);
System.Console.WriteLine();
PrintNewMatrix(matrix1, matrix2);

int[,] CreateArray(int m, int n)
{    
    int[,] NewArray = new int[m, n];

    for(int i = 0; i < NewArray.GetLength(0); i ++)
        {
        for(int j = 0; j < NewArray.GetLength(1); j++)
            {
            NewArray[i, j] = new Random().Next(1, 10);
            }
        }
    return NewArray;
}

void PrintArray(int[,] array)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

bool MultplicationPossible(int[,] matrix1, int[,] matrix2)
{
    if (matrix2.GetLength(1) == matrix1.GetLength(0))
    return true;
    else return false;
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] newmatrix = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(1); j++)
        {
            for(int k = 0; k < matrix1.GetLength(0); k++)
            {
                newmatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return newmatrix;
}

void PrintNewMatrix(int[,] matrix1, int[,] matrix2 )
{
    if (MultplicationPossible(matrix1, matrix2) == true )
    {
        int[,] matrix = MatrixMultiplication(matrix1, matrix2);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write(matrix[i, j] + " ");
            }
            System.Console.WriteLine();
        }
    }
    else System.Console.WriteLine("Матрицы нельзя перемножить");
}
