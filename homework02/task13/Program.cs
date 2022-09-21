Console.WriteLine ("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100)
{
    string a = Convert.ToString(n);
    Console.WriteLine ("Третья цифра числа:");
    Console.WriteLine (a[2]);
}
else
{
    Console.WriteLine ("Третьей цифры нет");
}
