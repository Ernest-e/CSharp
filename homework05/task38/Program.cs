
double [] myArray = new double [new Random().Next(5,15)];

double [] FillArrayWithRandom (double [] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next();
    }
    
    return array;
}

double FindMax (double [] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FindMin (double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double MaxMinDiff (double [] array)
{
    return FindMax(array) - FindMin(array);
}


void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
}




PrintArray (myArray);
Console.WriteLine('\n');

FillArrayWithRandom(myArray);

PrintArray (myArray);
Console.WriteLine('\n');

Console.WriteLine ("Разница между максимальным и минимальным числом равна " + MaxMinDiff(myArray));
