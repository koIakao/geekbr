Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int multi = 1;

for (int i = 1; i <= num; i++)
{
    //multi = multi * i;
    multi *= i;
}

Console.WriteLine($"Произведение чисел от 1 до {num} = {multi}");