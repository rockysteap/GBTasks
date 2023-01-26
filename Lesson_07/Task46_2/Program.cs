// **Задача 46 - 2:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//                    Например: m = 3, n = 4.     1 4 8 19        5 -2 33 -2       77 3 8 1
//
// Улучшенный способ парсинга ввода! Создадим целочисленный массив из строк сразу на вводе с клавиатуры

using static System.Console;
Clear();


Write("Введите размер матрицы и диапазон значений через пробел: ");
// string[] parameters = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
// int[] intParams=Array.ConvertAll(parameters, Convert.ToInt32);
// заменим две строки на нижеследующее выражение

// int[] intParams=Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);  // Convert.All конвертация типа массива, первый параметр - входящий массив, второй параметр - правило конвертации. В данном случае конвертация всех элементов в целочисленный тип данных, причем Convert.ToInt32 исполльзуется без скобок, иначе этот метод будет запрашивать данные. Также вместо Convert.ToInt32 можно использовать int.Parse

// или вариант с несколькими разделителями, в данном примере в качестве разделителя выступает массив символов:
int[] intParams=Array.ConvertAll(ReadLine()!.Split(new char[]{'\"','#',';',',','s'},StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = CreateMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);  // таким образом, в метод мы передаем уже числа

PrintMatrixArray(array);


int[,] CreateMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rand = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = rand.Next(minValue, maxValue);
        }
    }
    return resultArray;
}


void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3} ");  // вывод в 3 символа
        }
        WriteLine();
    }
}