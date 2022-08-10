Console.WriteLine("Write your first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1 % num2;

if (result == 0)
{
Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток равен {result}");
}