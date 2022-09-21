Console.WriteLine ("Введите 7 чисел");
int [] array = new int [7];
int i = 0;
int sum = 0;
while (i < array.Length)
{
    array [i] = Convert.ToInt32(Console.ReadLine());
    sum += array[i];
    i++;
}


int mean = sum/ array.Length;

Console.WriteLine();
Console.WriteLine("Среднее арифметическое =");
Console.WriteLine(mean);
