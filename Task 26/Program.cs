Console.WriteLine("Введите число: ");
int usernum = Convert.ToInt32(Console.ReadLine());

int digitCount = (int)Math.Log10(usernum) + 1;
Console.WriteLine($"Кол-во цифр в числе: {digitCount}");