Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++) result = result * numA;
    return result;
}

int exp = Exponentiation(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} = {exp}");