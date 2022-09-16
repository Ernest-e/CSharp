Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int n = N / 2;
int i = 1;

Console.WriteLine($"Четные числа от 1 до числа {N}:");
while (i <= n)
{
    int x = 2 * i;
    i += 1;
    Console.WriteLine(x);
}
