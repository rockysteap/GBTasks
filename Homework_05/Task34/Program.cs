// Задача 34:  Напишите программу реализующую методы формирования массива, 
//             заполненного случайными положительными трёхзначными числами, 
//             и подсчета количества чётных чисел в массиве.
//             Например: [345, 897, 568, 234] -> 2

using static System.Console;
Clear();

// Инициализируем массив c указанием размера и диапазона (максимальное число в методе увеличивается на единицу)
int[] array = InitRandomArray(10, 100, 999);

// Инициализируем переменную для результата и запишем в неё результат работы метода подсчета четных чисел
int arrayPositiveValues = CountArrayPositiveValues(array);

// Создадим красивый вывод результата )
Write("В массиве ");
PrintArray(array);
WriteLine($" найдено следующее количество чётных чисел -> {arrayPositiveValues}.\n");


int CountArrayPositiveValues(int[] inArray)
{
    int result = 0;

    foreach (var i in inArray)
    {
        result += (i % 2 == 0) ? 1 : 0;
    }
    return result;
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
