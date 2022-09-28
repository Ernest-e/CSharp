Console.OutputEncoding = System.Text.Encoding.UTF8;


void IfPalindrom (int digit)
{
    string line = Convert.ToString(digit);;
    bool check = true;

    for (int i =0; i < line.Length / 2; i++)
    {
        check = line[i] == line[line.Length - 1 - i];
    }
    string txt = check == true ? "yes" : "no";
    Console.WriteLine (txt);
}


Console.WriteLine("Введите число");
int digit = Int32.Parse(Console.ReadLine());

IfPalindrom (digit);