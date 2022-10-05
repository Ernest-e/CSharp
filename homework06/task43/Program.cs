// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



Console.WriteLine("прямые заданы уравнением y = kx+b");
Console.WriteLine("Введите k1");
double k1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите b1");
double b1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Double.Parse(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y = k1*x + b1;

Console.WriteLine($"точка пересечения прямых ({x};{y})");



