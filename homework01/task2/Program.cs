Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c");
int c =  Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > b)
{
    if (a > c)
    {
        max = a;
    }
    else
    {
        max = c;
    }
}
else
{
    if (b > c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
}
Console.WriteLine($"Максимальное число: {max}");
