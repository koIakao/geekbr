// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


Console.WriteLine("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];

CreateMatrixInt(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Tакого элемента нет");
}
else Console.WriteLine($"Значение элемента {n} строки и {m} столбца == {numbers[n-1,m-1]}");

Printmatrix(numbers);

void CreateMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void Printmatrix(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3},");
            else Console.Write($"{matrix[i, j], 3},");
        }
        Console.WriteLine("]");
    }
}