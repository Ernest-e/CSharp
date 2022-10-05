int length = new Random().Next(5,15);

int[] myArray = new int [length];

int [] FillArrayWithRandom (int [] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next();
    }
    
    return array;
}

long SummOfNotEvenElements (int [] array)
{
    long sum = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    
    return sum;
}

void PrintArray (int [] array)
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

long sum = SummOfNotEvenElements(myArray);
Console.Write("Сумма элементов на нечетных позициях равна " + sum);
