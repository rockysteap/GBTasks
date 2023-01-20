// Задача 35:  Задайте одномерный массив из 123 случайных чисел. 
//             Найдите количество элементов массива, 
//             значения которых лежат в отрезке [10,99].

using static System.Console;
Clear();

int[] array = GetArray(123, 10, 99);
PrintArray(array);
WriteLine();
WriteLine(ArrayCount(array));


int ArrayCount(int[] inArray)
{
    int result = 0;
    foreach (int i in inArray)
    {
        if (10 <= i && i <= 99) result ++;
    }
    return result;
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;
}


void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    WriteLine($"{inArray[inArray.Length - 1]}]");
}
