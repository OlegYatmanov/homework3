using System;
using static System.Console;
Clear();

Write("Введите число: ");
string number = ReadLine();

void CheckingNumber(string number)
{
  if (number[0] == number[4] || number[1] == number[3])
  {
    WriteLine($"{number} -> Да");
  }
  else WriteLine($"{number} -> Нет");
}
  CheckingNumber(number);