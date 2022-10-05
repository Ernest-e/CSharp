
int length = new Random().Next(5,15);

int[] myArray = new int [length];

int [] FillArrayWithThreeDigitNumber (int [] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    
    return array;
}

int FindEvenCount (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
}




PrintArray(myArray);
Console.WriteLine('\n');

FillArrayWithThreeDigitNumber(myArray);

PrintArray(myArray);
Console.WriteLine('\n');

int countEven = FindEvenCount (myArray);
Console.Write("четных числе в массиве " + countEven);



