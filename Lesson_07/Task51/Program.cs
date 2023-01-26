// **Задача 51:**  Задайте двумерный массив. Найдите сумму элементов, 
//                 находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//                 Например, задан массив:  1 4 7 2   5 9 2 3   8 4 2 4
//                 Сумма элементов главной диагонали: 1 + 9 + 2 = 12

using static System.Console;
Clear();

Write("Введите через пробел размерность матрицы и мин и макс значения: ");
string[] par = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] matrixArray = CreateMatrixArray(int.Parse(par[0]), int.Parse(par[1]), int.Parse(par[2]), int.Parse(par[3]));

PrintMatrixArray(matrixArray);
int result = ArrayMainDiagonalSum(matrixArray);
WriteLine(result);

int ArrayMainDiagonalSum(int[,] inArray)    // inArray.Length
{
    int resultSum = 0;
    for (int i = 0; i < (inArray.GetLength(0) > inArray.GetLength(1)? 
                         inArray.GetLength(1) : inArray.GetLength(0)); i++)
    {
        resultSum += inArray[i, i];
    }
    return resultSum;
}


int[,] CreateMatrixArray(int rows, int columns, int inMinValue, int inMaxValue) {
    Random rand = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++) {
            resultArray[i, j] = rand.Next(inMinValue, inMaxValue + 1);
        }
    }
    return resultArray;
}


void PrintMatrixArray(int[,] inArray) {
    for (int i = 0; i < inArray.GetLength(0); i++) {
        for (int j = 0; j < inArray.GetLength(1); j++) {
            Write($"{inArray[i, j],4} ");
        }
        WriteLine();
    }
}
