// Задача 2:   Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//             Например: 1) a = 5; b = 7 -> max = 7 2) a = 2 b = 10 -> max = 10 3) a = -9 b = -3 -> max = -3

using static System.Console;

int a, b;
string input = "";

Clear();

while (true)
{
    WriteLine("Введите: 'q'-выход, или два числа, чтобы определить большее из них.");

    Write("Введите первое число 'a': ");
    input = ReadLine();
    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out a))
    {
        Write("Введите второе число 'b': ");
        input = ReadLine();
        if (!string.IsNullOrEmpty(input) && int.TryParse(input, out b))
        {
            if (a > b) WriteLine($"a = {a}; b = {b} -> max = {a}");
            else if (a < b) WriteLine($"a = {a}; b = {b} -> max = {b}");
            else WriteLine($"a = {a}; b = {b} -> Числа равны!");
        }
        else if (input == "q") break;
        else WriteLine("Некорректный ввод. Попробуйте ещё раз.");

    }
    else if (input == "q") break;
    else WriteLine("Некорректный ввод. Попробуйте ещё раз.");
}
