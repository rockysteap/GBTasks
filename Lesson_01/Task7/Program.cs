// Task7. Напишите программу, которая принимает на вход трёхзначное число и 
//        на выходе показывает **последнюю** цифру этого числа.
//        Например: 456 -> 6, 782 -> 2, 918 -> 8

using static System.Console;

int n, digits;
string input = "";

Clear();

while (true)
{
    Write("Введите: 'q'-выход, или 'трехзначное число', чтобы вывести последнюю цифру этого числа: ");
    input = ReadLine()!;

    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out n))
    {
        digits = (int)Math.Log10(n) + 1;
        if (3 <= digits && digits < 4)
        {
            WriteLine($"Последняя цифра числа '{n}': '{n%10}'");
        }
        else WriteLine("Некорректный ввод. Попробуйте ещё раз.");
    }
    else if (input == "q") break;
    else WriteLine("Некорректный ввод. Попробуйте ещё раз."); 
}
