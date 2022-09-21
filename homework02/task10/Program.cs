Console.WriteLine ("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());

if ((n >= 100) && (n <= 999))
{
    int first_two_numbers = n/10;
    int second_number = first_two_numbers % 10;
    Console.WriteLine ("Вторая цифра введенного числа:");
    Console.WriteLine (second_number); 
}
else
{
    Console.WriteLine("Ошибка, введите трехзначное число");
}
