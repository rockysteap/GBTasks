// Задача 4:   Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//             Например: 1) 2, 3, 7 -> 7  2) 44 5 78 -> 78  3) 22 3 9 -> 22

using static System.Console;
Clear();

WriteLine("Введите три числа, чтобы определить большее из них.");
Write("Введите первое число 'a': ");
int a = Convert.ToInt32(ReadLine());
Write("Введите второе число 'b': ");
int b = Convert.ToInt32(ReadLine());
Write("Введите третье число 'с': ");
int c = Convert.ToInt32(ReadLine());

if (a > b) 
{
    int max = a;
    if (c > max) WriteLine($"a = {a}; b = {b}; c = {c} -> max = {c} (Число: 'c')");
    else if (c == max) WriteLine($"a = {a}; b = {b}; c = {c} -> max = {c} (Два числа: 'a' и 'c')");
    else WriteLine($"a = {a}; b = {b}; c = {c} -> max = {a} (Число: 'a')");
}
else if (a < b)
{
    int max = b;
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
