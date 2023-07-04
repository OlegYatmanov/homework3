using System;
using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine());

for (int i = 1; i <= number; i++)
{
    Write($"{i * i * i}  ");
}
int ReadInt(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}