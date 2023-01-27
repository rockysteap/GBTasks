// Задача 58:  Задайте две матрицы. Напишите программу, 
//             которая будет находить произведение двух матриц.
//             Например, даны 2 матрицы:   Результирующая матрица будет:
//                     2 4 | 3 4                       18 20
//                     3 2 | 3 3                       15 18

using static System.Console;
Clear();

MyConsoleMessage("Запуск программы");
WriteLine("Сформирована первая матрица со случайными размером и значениями:");
int[,] matrix = CreateRandomMatrix();
PrintMatrix(matrix);
WriteLine("Сформирована вторая матрица со случайными размером и значениями:");
int[,] matrix2 = CreateRandomMatrix();
PrintMatrix(matrix2);
MyConsoleMessage($"Произведение двух матриц:");
int[,] resultMatrix = MultiplyTwoMatrix(matrix, matrix2);
PrintMatrix(resultMatrix);
MyConsoleMessage("Завершение");


int[,] MultiplyTwoMatrix(int[,] inMatrix1, int[,] inMatrix2){
    int m1Row = inMatrix1.GetLength(0), m1Col = inMatrix1.GetLength(1),
        m2Row = inMatrix2.GetLength(0), m2Col = inMatrix2.GetLength(1);
    // rM <- resultMatrix 
    int[,] rM = new int[m1Row>m2Row?m2Row:m1Row, m1Col>m2Col?m2Col:m1Col];
        for (int i = 0; i < rM.GetLength(0); i++)
        {
            for (int j = 0; j < rM.GetLength(1); j++)
            {
                rM[i,j] = inMatrix1[i,j] * inMatrix2[i,j];
            }
        }
    return rM;
}


int[,] CreateRandomMatrix(){
    Random rand = new Random();
    int rows = rand.Next(1, 11);        int columns = rand.Next(1, 11); 
    int minValue = rand.Next(-100, 0);  int maxValue = rand.Next(0, 101);
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            resultMatrix[i,j] = rand.Next(minValue, maxValue);
        }
    }
    return resultMatrix;
}


void PrintMatrix(int[,] inMatrix){
    for (int i = 0; i < inMatrix.GetLength(0); i++){
        for (int j = 0; j < inMatrix.GetLength(1); j++){
            Console.Write($"{inMatrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}


void MyConsoleMessage(string inMessage = "-", int inLength = 60, char inDividerChar = '-')
// Выводит в консоль входящее сообщение дополняя символами до заданной длины
{
    if (inMessage.Length > inLength){
        Console.WriteLine("Ошибка: длина передаваемой строки выходит за границы");
    }
    else{
        int mL = inMessage.Length; int iL = inLength; 
        int dividerTimes = (iL-mL)/2;
        int k = (iL-mL)%2!=0 ? 1 : 0; // доп.символ в случае нечётного количества
        Console.Write($"\n{new string(inDividerChar, dividerTimes)}"
            + $"{inMessage}{new string(inDividerChar, dividerTimes+k)}\n");
    }
}
