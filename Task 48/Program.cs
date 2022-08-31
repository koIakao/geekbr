// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixInt(int row, int col) //печать двумерного массива
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            matrix[i, j] = i + j;
    }
    return matrix;
}

void Printmatrix(int[,] matrix) //вывод массива в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2},");
            else Console.Write($"{matrix[i, j], 2},");
        }
        Console.WriteLine("]");
    }
}


Console.WriteLine("введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");
int[,] matrix = CreateMatrixInt(m, n);
Printmatrix(matrix);