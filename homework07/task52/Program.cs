// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int m = new Random().Next(2,10);
int n = new Random().Next(2,10);
int [,] array = new int [m, n];

int[,] FillArray(int[,] array)
{
    int raw = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(-100, 100);
        }
    }
    return array;
}

void PrintArray (int [,] array)
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


void MeanInColumn (int[,] array)
{
    int raw = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < col; i ++)
    {
        double sum = 0;
    
        for (int j = 0; j < raw; j ++)
        {
            sum += array[j, i];
        
        }
        double mean = sum / raw;
        Console.WriteLine($"Среднее арифметическое для столбца {i+1} равняется {mean}");
    }
}


PrintArray(array);
Console.WriteLine();
FillArray(array);
Console.WriteLine();
PrintArray(array);

MeanInColumn(array);

