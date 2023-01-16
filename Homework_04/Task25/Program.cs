// Задача 25:  Напишите программу, реализующую метод,
//             который принимает на вход два числа (A и B) и возводит число A 
//             в натуральную степень B с использованием цикла. В задаче не использвать Math.Pow.
//             Например: 1) 3, 5 -> 243 (3⁵)  2) 2, 4 -> 16

using static System.Console;
Clear();

Write("Введите основание степени: ");
int.TryParse(ReadLine(), out int base_num);
Write("Введите показатель степени: ");
int.TryParse(ReadLine(), out int power_num);

float result = NumToPower(base_num, power_num);
WriteLine($"Результат: {base_num} в степени {power_num} = {result}");


float NumToPower(int base_num, int power_num)
{
    float power_res = (float)base_num;
    if (base_num == 0 && power_num != 0) return 0;
    else if (base_num == 1 || power_num == 0) return 1;
    else if (power_num > 0)
    {
        for (int i = power_num; i > 1; i--)
        {
            power_res *= base_num;
        }
    }
    else if (power_num < 0)
    {
        power_res = 1 / (float)base_num;
        for (int i = power_num; i < -1; i++)
        {
            power_res /= (float)base_num;
        }
    }
    return power_res;
}
