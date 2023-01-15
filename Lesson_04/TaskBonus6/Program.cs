// Напишите программу, которая принимает на вход число N и выдаёт сумму чисел от 1 до N, 
// при условии, что N будет делиться на это число без остатка.
// Иными словами: найти сумму всех целочисленных делителей числа N от 1 до N.


using static System.Console;
Clear();

Write("Введите число: ");
int.TryParse(ReadLine(), out int number);


WriteLine($"Сумма целочисленных делителей числа {number} = {DivisorSum(number)}");



int DivisorSum(int num)
{
    int result = 0;
    int number = num;
    while (num > 0)
    {
        if (number % num == 0)
        {
            result += num;
        }
        num--;
    }
    return result;
}
