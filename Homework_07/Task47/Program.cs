// Задача 47.  Напишите программу реализующую метод, который возвращает массив размером m×n, 
//             заполненный случайными вещественными числами.
//             Например: m = 3, n = 4. -> 0,5 7 -2 -0,2  1 -3,3 8 -9,9  8 7,8 -7,1 9

Console.Clear();

float[,] array = CreateRealMatrixArray(10, 10, -100, 100);
PrintRealMatrixArray(array);


float[,] CreateRealMatrixArray(int rows, int columns, float inMinValue, float inMaxValue)
{
    Random rand = new Random();
    float[,] resultMatrix = new float[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i, j] = Convert.ToSingle(inMinValue + rand.NextDouble()*(inMaxValue - inMinValue));
        }
    }
    return resultMatrix;
}


void PrintRealMatrixArray(float[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Console.Write($"{inMatrix[i, j].ToString("f2"), 6} ");
        }
        Console.WriteLine();
    }
}