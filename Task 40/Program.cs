/*
Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник сo сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон
*/


Console.Write("Введите сторону <a> треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону <b> треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону <c> треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());

bool CheckTriangle(int a1, int b1, int c1)
{
    if(a1 + b1 > c1 && b1 + c1 > a1 && c1 + a1 > b1) return true;
    return false;
}

bool result = CheckTriangle(a, b, c);
if(result) Console.WriteLine("Три числа являются треугольником!");
else Console.WriteLine("Три числа НЕ являются треугольником!");