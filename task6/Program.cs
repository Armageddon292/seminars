﻿// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
    {
      Console.Write(num);
      Console.WriteLine(" - является чётным числом");
    }
else
     {
      Console.Write(num);
      Console.WriteLine(" - является нечётным числом");
    }    