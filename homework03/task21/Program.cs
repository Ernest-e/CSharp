double [] A = new double [3];
double [] B = new double [3];

Console.WriteLine ("Введите координаты точки A");
int i = 0;
while (i < 3)
{
    A[i] = Convert.ToDouble(Console.ReadLine());
    i ++;
}

Console.WriteLine ("Введите координаты точки B");
int k = 0;
while (k < 3)
{
    B[k] = Convert.ToDouble(Console.ReadLine());
    k ++;
}


double FindDistance (double [] A, double [] B)
{
    double dictance = Math.Sqrt(Math.Pow((A[0] - B[0]), 2) + Math.Pow((A[1] - B[1]), 2) + Math.Pow((A[2] - B[2]), 2));
    return dictance;
}


double dictance = FindDistance (A, B);
Console.WriteLine ("Расстояние между точками A и B равняется:");
Console.WriteLine (dictance);




