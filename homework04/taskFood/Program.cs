int [] peopleEveryHour = new int [24]; // создаем массив, в котором каждый элемент = сколько людей в каждый час


int [] ComeInComeOut (int comeInTime, int comeOutTime, int [] col) // метод добавляет человека в массив в тот час, в котором он был в магазине
{

    for (int hour = 0; hour < col.Length; hour ++) 
    {
        if (comeInTime == hour)
        {
            for (int i = hour; i < comeOutTime; i ++)
            {
                col [i] = col [i] + 1;
            }

        }

    }
    return col;
}


int [] HowManyPeople(int countOfPersons, int[] col) // метод позволяет ввести данные о всех людях
{

    for (int i = 1; i <= countOfPersons; i ++)
    {
        
        Console.WriteLine ("Введите время входа:");
        int timeIn = Int32.Parse(Console.ReadLine());
        Console.WriteLine ("Введите время выхода:");
        int timeOut = Int32.Parse(Console.ReadLine());
        Console.WriteLine ("Количество людей по часам:");
        col = ComeInComeOut(timeIn, timeOut, col);
        PrintArray(col);
        Console.WriteLine();
        if (i != countOfPersons)
        {
            Console.WriteLine ("Следующий человек");
        }
    }
    Console.WriteLine ();
    return col;
}



int [] FindMaxInterval (int [] array) // метод ищет интервал, в котором было максимальное количество людей
{
    int max = array [0];
    int maxIndex = 0;
    int interval = 1;
    
    for (int i = 0; i < array.Length; i ++)
    {
        if (array [i] > max)
        {
            max = array [i];
            maxIndex = i;
        }
    }
    
    for (int k = maxIndex + 1; k < array.Length; k ++ )
    {
        if (array[k] == array[maxIndex])
        {
            interval += 1;
        }
        else
        {
            break;
        }

    }


    return new [] {maxIndex, (maxIndex + interval)};
}




void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
}





Console.WriteLine ("Сколько людей было в магазине?");
int countOfPersonsInStore = Int32.Parse(Console.ReadLine());

peopleEveryHour = HowManyPeople (countOfPersonsInStore, peopleEveryHour);

int [] intervalOfMaxPersons = FindMaxInterval (peopleEveryHour);
string maxInterval = string.Join(":", intervalOfMaxPersons);
Console.WriteLine("Интервал, в который было больше всего людей - " + maxInterval);

