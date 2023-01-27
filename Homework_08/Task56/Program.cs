// Задача 56:  Задайте прямоугольный двумерный массив. Напишите программу, 
//             которая будет находить строку с наименьшей суммой элементов.
//             Например, задан массив:     1 4 7 2
//                                         5 9 2 3
//                                         8 4 2 4
//                                         5 2 6 7
//             Программа считает сумму элементов в каждой строке 
//             и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
Clear();

MyConsoleMessage("Запуск программы");
WriteLine("Сформирована матрица со случайными размером и значениями:");
int[,] matrix = CreateRandomMatrix();
PrintMatrix(matrix);
MyConsoleMessage($"Строка {FindMatrixMinRowByValuesSum(matrix)} имеет наименьшую сумму");
MyConsoleMessage("Завершение");


int FindMatrixMinRowByValuesSum(int[,] inMatrix){
    int minRowSum = int.MaxValue, rowSum = 0, minRow = 0;
    for (int i = 0; i < inMatrix.GetLength(0); i++){
        rowSum = 0;
        for (int j = 0; j < inMatrix.GetLength(1); j++){
            rowSum += inMatrix[i, j];
        }
        if (minRowSum > rowSum){ minRowSum = rowSum;
                                 minRow = i + 1;
        }
    }
    return minRow;
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
            Console.Write($"{inMatrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}