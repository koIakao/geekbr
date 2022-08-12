Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

//if (x > 0 && y > 0) System.Console.WriteLine("Первая четверь!");
//else if(x < 0 && y > 0) System.Console.WriteLine("Вторая четверь!");
//else if(x < 0 && y < 0) System.Console.WriteLine("Третья четверь!");
//else if(x > 0 && y < 0) System.Console.WriteLine("Четвёртая четверь!");
//else System.Console.WriteLine("Введены некорректные варианты!");

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверь!";
    if (xc < 0 && yc > 0) return "Вторая четверь!";
    if (xc < 0 && yc < 0) return "Третья четверь!";
    if (xc > 0 && yc < 0) return "Четвёртая четверь!";
    return "Введены некорректные варианты!";
}

string result = Quarter(x, y);
Console.WriteLine(result);