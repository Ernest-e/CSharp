Console.WriteLine("Введите число, чтобы получить таблицу кубок от 1 до вашего числа");
int n = Int32.Parse(Console.ReadLine());

void CubesTable (int N)
{
    int i = 1;
    while (i <= N)
    {
        Console.WriteLine ($"{i}^3 = {Math.Pow(i,3)}");
        i ++;
    }
}


CubesTable(n);
