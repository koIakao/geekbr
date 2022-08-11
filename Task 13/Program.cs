//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Write your number (>100): ");
int userNum = Convert.ToInt32(Console.ReadLine());
int firsborder = 99;

    if (userNum <= firsborder)
    {
        Console.WriteLine("incorrect number!");
    }

    else
    {
        int digitCount = (int)Math.Log10(userNum) + 1;
        do
        {
            if (digitCount > 3) userNum = userNum / 10;
        }
        while (digitCount == 3);

    int result = userNum % 10;
    Console.WriteLine($"Result: {result}");
    }