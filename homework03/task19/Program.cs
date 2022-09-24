void IfPalindrom (int digit)
{
    string line = Convert.ToString(digit);;
    
    if (line.Length > 2)
    {
        int i = 0;
        while (i < (line.Length / 2))
        {
            if (line [i] == line [(line.Length - 1 - i)])
            {
                i ++;
            }
            else 
            {
                Console.WriteLine("Число не является палиндромом");
            }
        }
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        if (line.Length == 2)
        {
            if (line [0] == line [1])
            {
                Console.WriteLine("Число является палиндромом");
            }
            else
            {
                Console.WriteLine("Число не является палиндромом");
            }
        }
        else
        {
            Console.WriteLine("Введите число, состоящее из более 1 цифры");
        }
    }
}


Console.WriteLine("Введите число");
int digit = Int32.Parse(Console.ReadLine());

IfPalindrom (digit);



