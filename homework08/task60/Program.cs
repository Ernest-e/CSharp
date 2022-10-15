// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.




int a = new Random().Next(1,10);
int b = new Random().Next(1,10);
int c = new Random().Next(1,10);

var size = (a, b, c);

int [,,] array3d = new int [a, b, c];


int[,,] FillArray(int[,,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);
    if (x * y * z > 90)
    {
        Console.WriteLine ("В данный массив невозможно поместить уникальные двузначные элементы");
        return null;
    }
    else
    {
        List<int> unique = new List<int>();
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                for (int n = 0; n < z; n++)
                {
                    array[i,j,n] = new Random().Next(10, 100);
                    while (unique.Contains(array[i,j,n]))
                    {
                        array[i,j,n] = new Random().Next(10, 100);
                    }
                    unique.Add(array[i,j,n]);
                }

            }
        }
        return array;
    }
}


void PrintArray (int [,,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);
    for (int i = 0; i < x; i ++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int n = 0; n < z; n++)
            {
                var index = (i, j, n);
                Console.Write($"{array[i,j,n]} {index}");
            }
        }
    Console.WriteLine();
    }
}


Console.WriteLine(size);
FillArray(array3d);
PrintArray(array3d);
