﻿// пятая задача. Показывает последюю цифру 3-х значного числа
Console.WriteLine("Введите 3-х значное число");

string? inNumber = Console.ReadLine();
if (inNumber != null)
{
    char [] M = inNumber.ToCharArray();
    Console.WriteLine(M[2]);
}
