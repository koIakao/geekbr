// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixInt(int row, int col, int min, int max) //печать двумерного массива
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            matrix[i, j] = rnd.Next(min, max + 1);
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

void EvenIndex(int[,] matr) //поиск элементов, у которых оба индекса чётные, и замена этих элементы на их квадраты
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1)
            {
                if (i % 2 == 0 && j % 2 == 0) matr[i, j] *= matr[i, j];
            }
        }
    }
}

int[,] matrix = CreateMatrixInt(4, 4, 1, 9);
Printmatrix(matrix);
Console.WriteLine();
EvenIndex(matrix);
Printmatrix(matrix);