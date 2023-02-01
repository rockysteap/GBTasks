// **Задача 63:**  Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//                 в промежутке от 1 до N.
//                 Например:  1) N = 5 -> "1, 2, 3, 4, 5"  2) N = 6 -> "1, 2, 3, 4, 5, 6"

using static System.Console;

string result = GetNumbers(5);
WriteLine(result);
PrintNumbers(5);
WriteLine();
WriteLine(GetNumbers1(5));


string GetNumbers(int num)
{
    if (num == 1) return num.ToString();
    else return $"{GetNumbers(num - 1)}, {num}";
}

string GetNumbers1(int num)
{
    return (num == 1) ? num.ToString() : $"{GetNumbers1(num - 1)}, {num}";
}

void PrintNumbers(int num)
{
    if (num == 1) Write(num);
    else
    {
        PrintNumbers(num - 1);
        Write($", {num}");
    }
}