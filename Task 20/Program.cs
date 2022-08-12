Console.WriteLine("Введите координаты первой точки");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Pifagor(int xc1, int xc2, int yc1, int yc2)
{
    return Math.Sqrt((xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1));
}

double result = Pifagor(x1, x2, y1, y2);
Console.WriteLine($"Расстояние между точками A({x1};{y1}) и В({x2};{y2}) = {Math.Round(result, 3)}");
