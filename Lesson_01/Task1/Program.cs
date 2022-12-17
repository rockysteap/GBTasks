//  Task1.  Напишите программу, которая на вход принимает два числа и проверяет, 
//          является ли первое число квадратом второго.
//          Например:
//          a = 25; b = 5 -> да
//          a = 2 b = 10 -> нет
//          a = 9; b = -3 -> да
//          a = -3 b = 9 -> нет

using static System.Console;
Clear();

WriteLine("Проверим, является ли первое число квадратом второго?");
WriteLine();
Write("Введите первое число: ");
int a = Convert.ToInt32(ReadLine());
Write("Введите второе число: ");
int b = Convert.ToInt32(ReadLine());
Write("Ответ: ");

if (a == b * b)
    Write("ДА!");
else
    Write("НЕТ!");
