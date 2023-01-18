// Задача 38:  Напишите программу реализующую методы формирования массива, 
//             заполненного случайными вещественными числами 
//             и вычисления разницы между максимальным и минимальным элементов массива.
//             Например: [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;
Clear();

// Инициализируем массив c указанием размера и диапазона (максимальное число в методе увеличивается на единицу)
double[] array = InitRandomRealNumbersArray(4, -10, 10);

// Инициализируем переменную для результата и запишем в неё результат сравнения максимального и минимального элементов массива
var minMaxArrayValueComparisonResult = GetRealNumbersArrayMax(array) - GetRealNumbersArrayMin(array);

// Инициализируем переменную для желаемого формата при выводе
string formatConsoleOutput = "f4";

// Создадим красивый вывод результата )
Write("В массиве ");
PrintFloatArray(array, formatConsoleOutput);
WriteLine($" разница между максимальным элементом {GetRealNumbersArrayMax(array).ToString(formatConsoleOutput)} и минимальным элементом {GetRealNumbersArrayMin(array).ToString(formatConsoleOutput)} составляет {minMaxArrayValueComparisonResult.ToString(formatConsoleOutput)}.\n");


double GetRealNumbersArrayMin(double[] inArray)
{
    double result = inArray[0];
    foreach (var i in inArray)
    {
        if (result > i) result = i;
    }
    return result;
}


double GetRealNumbersArrayMax(double[] inArray)
{
    double result = inArray[0];
    foreach (var i in inArray)
    {
        if (result < i) result = i;
    }
    return result;
}


double[] InitRandomRealNumbersArray(int inSize, double inMinValue, double inMaxValue)
{
    double[] result = new double[inSize];
    double randomMaxValue, randomMinValue;

    if (inMinValue > inMaxValue) { randomMaxValue = inMinValue + 1; randomMinValue = inMaxValue; }
    else { randomMaxValue = inMaxValue + 1; randomMinValue = inMinValue; }

    for (int i = 0; i < result.Length; i++)
    {
        Random randomValue = new Random();
        result[i] = randomMinValue + randomValue.NextDouble() * (randomMaxValue - randomMinValue) ;
    }
    return result;
}


void PrintFloatArray(double[] inArray, string inFormat)
{
    Write("[");
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i].ToString(inFormat)}, ");
        // Write($"{inArray[i]:f4}, ");
    }
    Write("\b\b]");
}
