// Задача 36:  Напишите программу реализующую методы формирования массива, 
//             заполненного случайными числами и подсчета суммы элементов, 
//             стоящих на нечётных позициях.
//             Например: 1) [3, 7, 23, 12] -> 19  2) [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

// Инициализируем массив c указанием размера и диапазона (максимальное число в методе увеличивается на единицу)
int[] array = InitRandomArray(4, -10, 10);

// Инициализируем переменную для результата и запишем в неё результат работы метода подсчета суммы элементов, стоящих на нечётных позициях
int arrayOddValuesSum = CountArrayOddValuesSum(array);

// Создадим красивый вывод результата )
Write("В массиве ");
PrintArray(array);
WriteLine($" сумма элементов, стоящих на нечётных позициях = {arrayOddValuesSum}.\n");


int CountArrayOddValuesSum(int[] inArray)
{
    int result = 0;

    // Вариант с циклом foreach с использованием кортежа значений
    foreach (var iteration in inArray.Select((value, index) => new { value, index }))
    {
        result += (iteration.index % 2 != 0) ? iteration.value : 0;
    }

    // // Вариант с циклом foreach с дополнительным счетчиком индекса
    // int index = 0;
    // foreach (var i in inArray)
    // {
    //     result += (index % 2 != 0) ? i : 0;
    //     index++;
    // }

    // Вариант с циклом for (но было интересно сделать с foreach)
    // for (int i = 0; i < inArray.Length; i++)
    // {
    //     result += (i % 2 != 0) ? inArray[i] : 0;
    // }
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
