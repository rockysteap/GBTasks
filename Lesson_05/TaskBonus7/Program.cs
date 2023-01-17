// Создадим собственную структуру данных

using static System.Console;
Clear();

Write("Введите кор А через пробел: ");
Point A = GetPointFromString(ReadLine()!);
Write("Введите кор B через пробел: ");
Point B = GetPointFromString(ReadLine()!);

double delta = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2) + Math.Pow(A.Z - B.Z, 2));
WriteLine(delta);


Point GetPointFromString(string inStr)
{
    Point res = new Point();
    string[] par = inStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    res.X = int.Parse(par[0]);
    res.Y = int.Parse(par[1]);
    res.Z = int.Parse(par[2]);
    return res;
}

struct Point
{
    public int X;
    public int Y;
    public int Z;
}

struct MyStruct
{
    public int ArrayValue;
    public int ArrayIndex;
}
