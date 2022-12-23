// Задача 23: Напишите программу, которая принимает на вход число (N) 
//            и выдаёт таблицу кубов чисел от 1 до N.
//            Например:  1) 3 -> 1, 8, 27  2) 5 -> 1, 8, 27, 64, 125

using static System.Console;
Clear();

Write("Введите число для вывода таблицы кубов от 1 до числа: ");
int.TryParse(ReadLine(), out int n);

for (int i = 1; i < n + 1; i++)
{
    WriteLine($"Куб числа {i} = {Math.Pow(i, 3)}");
}

// int i = 1;
// while (i < n + 1)
// {
//     WriteLine($"Куб числа {i} = {Math.Pow(i, 3)}");
//     i++;
// }
