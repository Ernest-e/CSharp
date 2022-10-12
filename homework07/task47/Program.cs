// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

Console.OutputEncoding = System.Text.Encoding.UTF8;
int m = 3;
int n = 4;

double[,] array = new double[m, n];

double[,] FillArray(double[,] array)
{
    int raw = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().NextDouble() * 10;
        }
    }
    return array;
}

void PrintArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}

PrintArray(array);
Console.WriteLine();
FillArray(array);
Console.WriteLine();
PrintArray(array);



