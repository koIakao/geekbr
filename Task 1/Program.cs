Console.Write("Введите первое целое число: " );
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: " );
int number2 = Convert.ToInt32(Console.ReadLine());
int square = number2 * number2;

if(square == number1) // если равно
{
Console.Write($"Число: {number1} является квадратом: {number2}! ");
}
if(square != number1) // если не равно
{
Console.Write($"Число: {number1} НЕ является квадратом: {number2}! ");
}