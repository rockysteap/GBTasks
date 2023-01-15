// 22. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

using static System.Console;
Clear();

Write("Точка А -> Введите координату x: ");
int.TryParse(ReadLine(), out int ax);
Write("Точка А -> Введите координату y: ");
int.TryParse(ReadLine(), out int ay);
Write("Точка B -> Введите координату x: ");
int.TryParse(ReadLine(), out int bx);
Write("Точка B -> Введите координату y: ");
int.TryParse(ReadLine(), out int by);

double length = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2));
WriteLine($"{length:f2}");  // округление -> f2 переводит во float и округляет до 2 знаков, p - проценты
