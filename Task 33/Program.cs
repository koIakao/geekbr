//Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да


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

bool CheckNum(int[] array, int elemF) //проверка наличия заданного числа в массиве
{
    bool ret = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elemF)
        {
            ret = true;
            break;
        }
    }
    return ret;
}

Console.WriteLine("Введите число, которое хотите найти в массиве");
int findi = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayInt(12, -9, 9);
PrintArray(arr);
Console.WriteLine();
bool search = CheckNum(arr, findi);
Console.WriteLine(search ? $"Числo {findi} в наличии!" : $"Число {findi} отсутствует!");