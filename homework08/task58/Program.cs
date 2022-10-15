// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.




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


int [,] MatrixMultiplication (int [,] matrixone, int [,] matrixtwo)
{
    int raw1 = matrixone.GetLength(0);
    int col1 = matrixone.GetLength(1);
    int raw2 = matrixtwo.GetLength(0);
    int col2 = matrixtwo.GetLength(1);

    if (col1 != raw2)
    {
        Console.WriteLine("Данные матрицы не могут быть перемножены");
        return null;
    }
    
    else
    {
        int [,] multiplication = new int [raw1, col2];
        for (int i = 0; i < raw1; i ++)
        {
            for (int j = 0; j < col2; j ++)
            {
                for (int n = 0; n < col1; n ++)
                {
                    multiplication [i, j] += matrixone [i,n] * matrixtwo [n,j];
                }
            }
        }

        return multiplication;

    }

}

int a = new Random().Next(2,10);
int b = new Random().Next(2,10);
int c = new Random().Next(2,10);
int [,] matrix1 = new int [a, b];
int [,] matrix2 = new int [b, c];


FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();

int [,] newMatrix = MatrixMultiplication(matrix1, matrix2);
PrintArray(newMatrix);