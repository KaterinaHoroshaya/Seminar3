while(true)
{
    int x = ReadInt("Введите точку x: ");
    int y = ReadInt("Введите точку y: ");

    if(x == 0 || y == 0)
    {
        Console.WriteLine("x и y не могут быть равны 0");
        continue;
    }

    if (x > 0 && y > 0)
    {
        Console.WriteLine("1");
    }
    else if(x < 0 && y > 0)
    {
        Console.WriteLine("2");
    }
    else if(x < 0 && y < 0)
    {
        Console.WriteLine("3");
    }
    else if(x > 0 && y < 0)
    {
        Console.WriteLine("4");
    }
    break;
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

