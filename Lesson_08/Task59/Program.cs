// **Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

using static System.Console;
Clear();

int[,] matrix = CreateRandomMatrix();
int minValue =  GetMinMatrixValue(matrix);
int shrinkCount = 0;

Write($"\n\n{new string('-', 20)}Запуск программы{new string('-', 20)}"
     + "\nСформирована матрица со случайными размером и значениями\n");

    WriteLine($"Начальная матрица: ");
    PrintMatrix(matrix);

while (true)
{
    if (CountMatrixValue(matrix, minValue) < 1) {
        WriteLine($"Элементов с минимальным значением: '{minValue}' не осталось."
                + $"\n{new string('-', 17)}Завершение программы{new string('-', 17)}\n");
        break;
    }
    WriteLine($"Минимальное значение: '{minValue}' найдено в матрице {CountMatrixValue(matrix, minValue)} раз(а). ");
    if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2) {
        WriteLine($"Матрица имеет минимальные размеры и после преобразования будет уничтожена."
                + $"\n{new string('-', 27)}Завершение программы{new string('-', 27)}\n");
        break;
    }
    matrix = ShrinkMatrixByAdress(matrix, minValue);
    shrinkCount++;
    WriteLine($"\nИзмененная матрица(сокращений -> {shrinkCount}):");
    PrintMatrix(matrix);
}


int[,] ShrinkMatrixByAdress(int[,] inMatrix, int inMinValue)
{
    if (inMatrix.GetLength(0) < 1 || inMatrix.GetLength(1) < 1) return inMatrix;
    int row = 0; int column = 0;
    for (int i = inMatrix.GetLength(0) - 1; i >= 0; i--) {
        for (int j = inMatrix.GetLength(1) - 1; j >= 0; j--) {
            if (inMatrix[i, j] == inMinValue) {
                row = i;
                column = j;
            }
        }
    }
    // WriteLine($"Адрес минимального: {row}, {column}");
    int[,] resultMatrix = new int[inMatrix.GetLength(0) - 1, inMatrix.GetLength(1) - 1];
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            if (i < row && j < column) {resultMatrix[i, j] = inMatrix[i, j];}
            if (i < row && j > column) {resultMatrix[i, j - 1] = inMatrix[i, j];}
            if (i > row && j > column) {resultMatrix[i - 1, j - 1] = inMatrix[i, j];}
            if (i > row && j < column) {resultMatrix[i - 1, j] = inMatrix[i, j];}
            // resultMatrix[i, j] = (i < row && j < column) ? inMatrix[i, j] 
            //     : (i < row && j > column) ? inMatrix[i, j];
                                  
        }    
    }
    return resultMatrix;
}


int CountMatrixValue(int[,] inMatrix, int inMinValue)
{
    int counter = 0;
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            counter += inMinValue == inMatrix[i, j] ? 1 : 0;
        }
    }
    return counter;
}


int GetMinMatrixValue(int[,] inMatrix)
{
    int result = inMatrix[0, 0]; 
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            result = ( result > inMatrix[i,j] ) ? inMatrix[i, j] : result;
        }
    }
    return result;
} 


int[,] CreateRandomMatrix(){
    Random rand = new Random();
    int rows = rand.Next(1, 11);        int columns = rand.Next(1, 11); 
    int minValue = rand.Next(-10, 0);  int maxValue = rand.Next(0, 10);
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            resultArray[i,j] = rand.Next(minValue, maxValue);
        }
    }
    return resultArray;
}

void PrintMatrix(int[,] inMatrix){
    for (int i = 0; i < inMatrix.GetLength(0); i++){
        for (int j = 0; j < inMatrix.GetLength(1); j++){
            Console.Write($"{inMatrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}
