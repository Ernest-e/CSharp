// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка


int m = new Random().Next(2,10);
int n = new Random().Next(2,10);
int [,] myArray = new int [m, n];

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


void FindMinRaw (int [,] array)
{
    int raw = array.GetLength(0);
    int col = array.GetLength(1);
    int [] conteinerSumOfRaw = new int [raw];
    for (int i = 0; i < raw; i++)
    {
        int sum = 0;
        for (int j = 0; j < col; j++)
        {
            sum += array[i, j];
        }
        conteinerSumOfRaw [i] = sum;
    }
    
    int MinRaw = 0;
    for (int i = 0; i < raw; i++)
    {
        if (conteinerSumOfRaw[i] < conteinerSumOfRaw [MinRaw]) {MinRaw = i;}
    }

    Console.WriteLine ($"Строка с наименьшей суммой элементов - {MinRaw + 1}");
}



PrintArray(myArray);
Console.WriteLine();

FillArray(myArray);
Console.WriteLine();

PrintArray(myArray);
Console.WriteLine();

FindMinRaw(myArray);
Console.WriteLine();