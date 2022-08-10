int showMiddleDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = firstDigit % 10;
    int result = secondDigit;
    return result;
}

int number = new Random().Next(100, 1000);

int res = showMiddleDigit(number);
Console.WriteLine($"Сгенерированное число {number}. Обработанное число -> {res}");