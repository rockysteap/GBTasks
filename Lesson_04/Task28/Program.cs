// 28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24  // 5  -> 120

using static System.Console;
Clear();

Write("Введите число: ");
int.TryParse(ReadLine(), out int number);

WriteLine($"Произведение ряда чисел от 1 до {number} = {NumProduct(number)}");


int NumProduct(int num)
{
    if (num <= 0) return 0;  // возвращаем 0 без вычислений, если ряд проходит через 0

    int result = 1;
    while (num > 0)
    {
        result *= num;
        num--;
    }
    return result;
}
