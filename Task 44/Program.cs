// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Задайте значение N: ");
int usernum = Convert.ToInt32(Console.ReadLine());

void Fibonacci(int numb1)
{
    int fibbA = 0;
    int fibbB = 1;
    Console.Write($"{fibbA} {fibbB}");

    for (int i = 2; i < numb1; i++)
    {
        int nextFib = fibbA + fibbB;
        Console.Write($"{nextFib} ");
        fibbA = fibbB;
        fibbB = nextFib;
    }
}

Fibonacci(usernum);