Console.WriteLine ("Введите цифру, обозначающую день недели");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Является ли этот день выходным?");
if (n >= 1 & n <=7)
{
    if (n == 6 | n == 7)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("В неделе 7 дней, введите цифру от 1 до 7");
}
