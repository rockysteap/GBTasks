// Задача 8:   Напишите программу, которая на вход принимает число (N), 
//             а на выходе показывает все чётные числа от 1 до N.
//             Например: 1) 5 -> 2, 4  2) 8 -> 2, 4, 6, 8

using static System.Console;
int i;

Clear();

Write("Введите число, чтобы показать последовательность четных чисел от 1 до числа: ");
int n = Convert.ToInt32(ReadLine())!;

if (n > 1)
    for (i=1;i<n+1;i++)
        {
            if (i%2 != 0) continue;
            Write($"{i} ");    
        }
else if (n < 1) 
    for (i=1;i>n-1;i--)
        {
            if (i%2 != 0) continue;
            Write($"{i} ");
        }
