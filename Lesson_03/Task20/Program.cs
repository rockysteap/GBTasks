// 19. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка

using static System.Console;
Clear();

Write("Введите координату x: ");
int x = int.Parse(ReadLine()!);
Write("Введите координату y: ");
int y = int.Parse(ReadLine()!);

WriteLine("");
WriteLine("Четверти:");
WriteLine("  II  I");
WriteLine(" III  IV");
WriteLine("");

if (x == 0 || y == 0) {
    WriteLine("Error");
    return;
}

if (x > 0 && y > 0) {
    WriteLine("I четверть");
    return;
}

if (x < 0 && y > 0) {
    WriteLine("II четверть");
    return;
}

if (x < 0 && y < 0) {
    WriteLine("III четверть");
    return;
}

if (x > 0 && y < 0) {
    WriteLine("IV четверть");
    return;
}

WriteLine("");