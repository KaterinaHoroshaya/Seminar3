﻿
int number = ReadInt("Введите число: ");
int i = 1;
while(i <= number)
{
    Console.Write(Pow(i++) + " ");
}

int Pow(int a)
{
    return a * a;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
