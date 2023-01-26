// Задача 52.  Напишите программу реализующую методы, 
//             формирования двумерного массива и массива средних арифметических значений каждого столбца.
//             Например, задан массив:  1 4 7 2  5 9 2 3  8 4 2 4
//             Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] matrix = AutoCreateRandomMatrix();
Console.WriteLine("Создана следующая матрица: ");
PrintMatrix(matrix);
float[] averageByCol = GetMatrixAverageValuesByColumn(matrix);
float[] averageByRow = GetMatrixAverageValuesByRow(matrix);
Console.WriteLine("Массив средних значений каждого столбца: ");
PrintFloatArray(averageByCol);
Console.WriteLine("Массив средних значений каждой строки: ");
PrintFloatArray(averageByRow);


int[,] AutoCreateRandomMatrix(){
    Random rand = new Random();
    int rows = rand.Next(1, 11);        int columns = rand.Next(1, 11); 
    int minValue = rand.Next(-100, 0);  int maxValue = rand.Next(0, 101);
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            resultArray[i,j] = rand.Next(minValue, maxValue);
        }
    }
    return resultArray;
}


float[] GetMatrixAverageValuesByColumn(int[,] inMatrix)
{
    float[] resultMatrix = new float[inMatrix.GetLength(1)];

    for (int col = 0; col < inMatrix.GetLength(1); col++){
        for (int row = 0; row < inMatrix.GetLength(0); row++){
            resultMatrix[col] += inMatrix[row, col];
        }
        resultMatrix[col] /= inMatrix.GetLength(0);
    }
    return resultMatrix;
}


float[] GetMatrixAverageValuesByRow(int[,] inMatrix)
{
    float[] resultMatrix = new float[inMatrix.GetLength(0)];

    for (int row = 0; row < inMatrix.GetLength(0); row++){
        for (int col = 0; col < inMatrix.GetLength(1); col++){
            resultMatrix[row] += inMatrix[row, col];
        }
        resultMatrix[row] /= inMatrix.GetLength(1);
    }
    return resultMatrix;
}


void PrintMatrix(int[,] inMatrix){
    for (int i = 0; i < inMatrix.GetLength(0); i++){
        for (int j = 0; j < inMatrix.GetLength(1); j++){
            Console.Write($"{inMatrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

void PrintFloatArray(float[] inArray)
{
    Console.Write("[");
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]:f2}, ");
    }
    Console.Write("\b\b]\n");
}