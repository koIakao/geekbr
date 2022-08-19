Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= num; i++)
{
    //sum = sum + i;
    sum += i;
}

Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");