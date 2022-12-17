// Задача 4:   Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//             Например: 1) 2, 3, 7 -> 7  2) 44 5 78 -> 78  3) 22 3 9 -> 22
using static System.Console;

int a, b, c, max;
string input;

Clear();

while (true)
{
    WriteLine("Введите: 'q'-выход, или три числа, чтобы определить большее из них.");

    Write("Введите первое число 'a': ");
    input = ReadLine();
    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out a))
    {
        Write("Введите второе число 'b': ");
        input = ReadLine();
        if (!string.IsNullOrEmpty(input) && int.TryParse(input, out b))
        {
            Write("Введите третье число 'с': ");
            input = ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out c))
            {
                if (a > b) 
                {
                    max = a;
                    if (c > max) WriteLine($"a = {a}; b = {b}; c = {c} -> max = {c} (Число: 'c')");
                    else if (c == max) WriteLine($"a = {a}; b = {b}; c = {c} -> max = {c} (Два числа: 'a' и 'c')");
                    else WriteLine($"a = {a}; b = {b}; c = {c} -> max = {a} (Число: 'a')");
                }
                else if (a < b)
                {
                    max = b;
                    if (c > max) WriteLine($"a = {a}; b = {b}; c = {c} -> max = {c} (Число: 'c')");
                    else if (c == max) WriteLine($"a = {a}; b = {b}; c = {c} -> max = {c} (Два числа: 'b' и 'c')");
                    else WriteLine($"a = {a}; b = {b}; c = {c} -> max = {b} (Число: 'b')");
                } 

                else if (a == b)
                {
                    if (c > a) WriteLine($"a = {a}; b = {b}; c = {c} -> max = {c} (Число: 'c')");
                    else if (c < a) WriteLine($"a = {a}; b = {b}; c = {c} -> max = {b} (Два числа: 'a' и 'b')");
                    else WriteLine($"a = {a}; b = {b}; c = {c} (Три числа равны!)");
                }
            }
            else if (input == "q") break;
            else WriteLine("Некорректный ввод. Попробуйте ещё раз.");
        }
        else if (input == "q") break;
        else WriteLine("Некорректный ввод. Попробуйте ещё раз.");
    }
    else if (input == "q") break;
    else WriteLine("Некорректный ввод. Попробуйте ещё раз.");
}
