//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

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


void FindElemenbyPosition (string position, int [,] array)
{

    int [] coord = Array.ConvertAll(position.Split(), int.Parse);
    if (coord.Length != 2) 
    {
        Console.WriteLine ("Введите позицию состоящию из 2 числе: строки и столбца через пробел.");
    }
    if (coord[0] > array.GetLength(0) || coord[1]> array.GetLength(0))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else {Console.WriteLine($"Элемент на позиции {coord[0]};{coord[1]} это {array[coord[0]-1, coord[1]-1]}"); }

}

PrintArray(array);
Console.WriteLine();
FillArray(array);
Console.WriteLine();
PrintArray(array);

Console.WriteLine(array.GetLength(0));
Console.WriteLine(array.GetLength(1));

Console.WriteLine("Введите позицию элемента через пробел: сначала строку, потом столбик");
string position = Console.ReadLine();

FindElemenbyPosition(position, array);
