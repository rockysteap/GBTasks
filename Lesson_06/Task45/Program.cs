// Задача 45:  Напишите программу, которая будет создавать копию заданного массива 
//             с помощью поэлементного копирования.

using static System.Console;
Clear();

// Инициализируем массив
int[] array = InitRandomArray(20, -10, 10);
int[] array2 = ArrayCopy(array);

Write(array.GetHashCode() + " "); PrintArray(array);
WriteLine();
Write(array2.GetHashCode() + " "); PrintArray(array2);


int[] ArrayCopy(int[] inArray)
{
    int[] resultArray = new int[inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        resultArray[i] = inArray[i];
    }
    return resultArray;
}


int[] InitRandomArray(int inSize, int inMinValue, int inMaxValue)
{
    int[] result = new int[inSize];
    int randomMaxValue, randomMinValue;

    if (inMinValue > inMaxValue) { randomMaxValue = inMinValue + 1; randomMinValue = inMaxValue; }
    else { randomMaxValue = inMaxValue + 1; randomMinValue = inMinValue; }

    for (int i = 0; i < result.Length; i++)
    {
        Random randomValue = new Random();
        result[i] = randomValue.Next(randomMinValue, randomMaxValue);
    }
    return result;
}


void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write("\b\b]");
}