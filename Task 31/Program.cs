int[] CreateArrayInt(int size, int min, int max) //универсальный метод создания массива
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] GetSumNegArray(int[] array) //метод определяющий сумму положительных и отрицательных элементов массива
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sumNeg += array[i];
        else
            sumPos += array[i];
    }
    return new int[] { sumNeg, sumPos };
}

void PrintArray(int[] array) //метод выводит в консоль массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int[] arr = CreateArrayInt(12, -9, 9); //создание параметров массива
PrintArray(arr); //выводим массив
int[] sumNegArray = GetSumNegArray(arr);
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных чисел = {sumNegArray[0]}");
Console.WriteLine($"Сумма положительных чисел = {sumNegArray[1]}");

