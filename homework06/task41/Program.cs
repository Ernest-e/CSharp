Console.WriteLine ("Введите числа через пробел");

int [] myArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int CountOfDigitMoreThanNull (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] > 0) count += 1;
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


int count = CountOfDigitMoreThanNull (myArray);
Console.WriteLine("Чисел больше ноля " + count);
