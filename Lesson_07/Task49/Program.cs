// **Задача 49:**  Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//                 и замените эти элементы на их квадраты. Также необходимо исключить нулевые индексы!
//                 Например, изначально массив выглядел вот так:   1 4 7 2   5 9 2 3   8 4 2 4
//                 Новый массив будет выглядеть вот так:  1 4 7 2   5 **81** 2 **9**   8 4 2 4

using static System.Console;
Clear();

Write("Введите через пробел размерность матрицы: ");
string[] par = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] matrixArray = CreateMatrixArray(int.Parse(par[0]), int.Parse(par[1]), int.Parse(par[2]), int.Parse(par[3]));

PrintMatrixArray(matrixArray);
WriteLine();
int[,] matrixArray2 = ReconstructMatrix(matrixArray);
PrintComparedArrayValues(matrixArray, matrixArray2);
// PrintMatrixArray(matrixArray2);


int[,] ReconstructMatrix(int[,] inArray)
{
    int[,] resultArray = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i != 0 && j != 0 && i % 2 == 0 && j % 2 == 0) {
                resultArray[i, j] = inArray[i, j] * inArray[i, j];
            }
            else { 
                resultArray[i, j] = inArray[i, j]; 
            }
        }
    }

    return resultArray;
}


int[,] CreateMatrixArray(int rows, int columns, int inMinValue, int inMaxValue)
{
    Random rand = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rand.Next(inMinValue, inMaxValue + 1);
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
            Write($"{inArray[i, j],4} ");
        }
        WriteLine();
    }
}


void PrintComparedArrayValues(int[,] inArray, int[,] inArray2)
{
    if (inArray.GetLength(0) != inArray2.GetLength(0) && inArray.GetLength(1) != inArray2.GetLength(1)) {
        WriteLine("Размер входящих массивов не совпадает.");
        return;
    }

    for (int i = 0; i < inArray.GetLength(0); i++) {
        for (int j = 0; j < inArray.GetLength(1); j++) {
            if ( inArray[i, j] != inArray2[i, j] ) {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Write($"{inArray2[i, j],4} ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else { 
                Write($"{inArray2[i, j],4} ");
            }
        }
        WriteLine();
    }
}
