// Задача 10:  Напишите программу, которая принимает на вход трёхзначное число и 
//             на выходе показывает вторую цифру этого числа.
//             Например:  1) 456 -> 5  2) 782 -> 8  3) 918 -> 1

using static System.Console;
Clear();

// Вариант 1 - генерация 10 трехзначных чисел
int i;
for (i = 0; i < 10; i++)
{
    int n = new Random().Next(100, 1000);
    WriteLine($"Вторая цифра числа '{n}': '{n / 10 % 10}'");
    Thread.Sleep(200);
}


// // Вариант 2 - с ручным вводом
// int n, digits;
// string input = "";

// while (true)
// {
//     Write("Введите: 'q'-выход, или 'трехзначное число', чтобы вывести вторую цифру этого числа: ");
//     input = ReadLine()!;

//     if (!string.IsNullOrEmpty(input) && int.TryParse(input, out n))
//     {
//         digits = (int)Math.Log10(n) + 1;
//         if (3 <= digits && digits < 4)
//         {
//             WriteLine($"Вторая цифра числа '{n}': '{n/10%10}'");
//         }
//         else WriteLine("Некорректный ввод. Попробуйте ещё раз.");
//     }
//     else if (input == "q") break;
//     else WriteLine("Некорректный ввод. Попробуйте ещё раз."); 
// }