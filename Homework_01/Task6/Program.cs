// Задача 6:   Напишите программу, которая на вход принимает число и выдаёт, 
//             является ли число чётным (делится ли оно на два без остатка).
//             Например: 1) 4 -> да  2) -3 -> нет  3) 7 -> нет

using static System.Console;
Clear();

int n;
string input;

while (true)
{
    Write("Введите: 'q'-выход, или число для определения четности: ");
    input = ReadLine()!;
    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out n))
    {
        if (n%2 == 0) WriteLine($"Число {n} -> Четное!");
        else WriteLine($"Число {n} -> Нечетное!");
    }
    else if (input == "q") break;
    else WriteLine("Некорректный ввод. Попробуйте ещё раз.");
}
