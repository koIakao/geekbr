﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Write("Введите число: ");
int usernum = Convert.ToInt32(Console.ReadLine());

int CangeToBin(int a) // преобразование в двоичное число
{
    int result = 0;
    int mult = 1;
    while (a > 0)
    {
        result += a % 2 * mult;
        a /= 2;
        mult *= 10;
    }
    return result;
}
Console.Write($"Двоичное число = {CangeToBin(usernum)}");