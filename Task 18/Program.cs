Console.WriteLine("Введите номер четверти: ");
int qt = Convert.ToInt32(Console.ReadLine());

string QuarterList(int quarter)
{
    if (quarter == 1) return "Значения переменных: x > 0 и y > 0";
    if (quarter == 2) return "Значения переменных: x < 0 и y > 0";
    if (quarter == 3) return "Значения переменных: x < 0 и y < 0";
    if (quarter == 4) return "Значения переменных: x > 0 и y < 0";
    return "Введены некорректные варианты!";
}

string result = QuarterList(qt);
Console.WriteLine(result);