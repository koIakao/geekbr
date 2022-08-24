//Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]


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

int[] ChangePosNeg(int[] array) //умножаем числа в массиве на -1
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

void PrintArray(int[] array) //метод выводит массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}
int[] arr = CreateArrayInt(4, -9, 9);
PrintArray(arr);
Console.WriteLine();
int[] posneg = ChangePosNeg(arr);
PrintArray(posneg);