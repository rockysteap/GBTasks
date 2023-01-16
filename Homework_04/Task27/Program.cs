// Задача 27:  Напишите программу, реализующую метод, 
//             который принимает на вход число и выдаёт сумму цифр в числе.
//             Например: 1) 452 -> 11  2) 82 -> 10  3) 9012 -> 12

using static System.Console;
Clear();

Write("Введите число: ");
int.TryParse(ReadLine(), out int number);


int result = DigitsSum(number);
WriteLine($"Сумма цифр числа {number} = {result}");


int DigitsSum(int num)
{
    int result = 0;
    for (int i = Convert.ToString(num).Length; i > 0; i--)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}
