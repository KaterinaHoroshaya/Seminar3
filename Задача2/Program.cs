/*  Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y) */

int quarter = ReadInt("Введите номер четверти: ");
if(quarter == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if(quarter == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if(quarter == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if(quarter == 4)
{
    Console.WriteLine("x > 0, y < 0");
}
else
{
    Console.WriteLine("Четвертей всего 4!");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}