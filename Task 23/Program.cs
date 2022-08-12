Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= n)
{
    Console.WriteLine($"{count} | {Math.Pow(count, 3)}");
    count++;
}