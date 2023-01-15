// 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3  // 78 -> 2  // 89126 -> 5

using static System.Console;
Clear();

Write("Введите число: ");
int.TryParse(ReadLine(), out int number);


WriteLine($"Количество цифр в числе {number} -> {NumCountWLoop(number)}");
WriteLine($"Количество цифр в числе {number} -> {NumCountWLog(number)}");
WriteLine($"Количество цифр в числе {number} -> {NumCountWLength(number)}");


int NumCountWLoop(int num)
{
    int digits = 0;
    while (num > 0)
    {
        digits++;
        num /= 10;
    }
    return digits;
}

int NumCountWLog(int num)
{
    int digits = (int)Math.Log10(num) + 1;
    return digits;
}

int NumCountWLength(int num)
{
    int digits = Convert.ToString(num).Length;
    return digits;
}