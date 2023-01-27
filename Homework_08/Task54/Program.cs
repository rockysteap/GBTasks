 // Задача 54:  Задайте двумерный массив. Напишите программу, 
//             которая упорядочит по убыванию элементы каждой строки двумерного массива.
//             Например, задан массив:     В итоге получается вот такой массив:
//                     1 4 7 2                             7 4 2 1
//                     5 9 2 3                             9 5 3 2
//                     8 4 2 4                             8 4 4 2

using static System.Console;
Clear();
MyConsoleMessage("Запуск программы");
WriteLine("Сформирована матрица со случайными размером и значениями:");

int[,] matrix = CreateRandomMatrix();
PrintMatrix(matrix);
//  Сортировка пузырьком (bubble sort) -> 4 метода (по убыванию и возрастанию для строк и колонок)
// SortMatrixAscendingValuesByRows(matrix);
SortMatrixDescendingValuesByRows(matrix);
// SortMatrixAscendingValuesByColumns(matrix);
// SortMatrixDescendingValuesByColumns(matrix);
MyConsoleMessage("Применен метод сортировки \"пузырьком\"");
PrintMatrix(matrix);
MyConsoleMessage("Завершение");


void SortMatrixDescendingValuesByRows(int[,] inMatrix){
    int tmp = 0;
    for (int i = 0; i < inMatrix.GetLength(0); i++){
        for (int n = 0; n < inMatrix.GetLength(1) - 1; n++){
            for (int j = 0; j < inMatrix.GetLength(1) - 1; j++){
                if (inMatrix[i, j] < inMatrix[i, j+1]){
                    tmp = inMatrix[i, j];
                    inMatrix[i, j] = inMatrix[i, j+1];
                    inMatrix[i, j+1] = tmp;
                }
            }
        }
    }
}


// void SortMatrixAscendingValuesByRows(int[,] inMatrix){
//     int tmp = 0;
//     for (int i = 0; i < inMatrix.GetLength(0) - 1; i++){
//         for (int n = 0; n < inMatrix.GetLength(1) - 1; n++){
//             for (int j = 0; j < inMatrix.GetLength(1); j++){
//                 if (inMatrix[i, j] > inMatrix[i, j+1]){
//                     tmp = inMatrix[i, j];
//                     inMatrix[i, j] = inMatrix[i, j+1];
//                     inMatrix[i, j+1] = tmp;
//                 }
//             }
//         }
//     }
// }


// void SortMatrixAscendingValuesByColumns(int[,] inMatrix){
//     int tmp = 0;
//     for (int n = 0; n < inMatrix.GetLength(1) - 1; n++){
//         for (int i = 0; i < inMatrix.GetLength(0) - 1; i++){
//             for (int j = 0; j < inMatrix.GetLength(1); j++){
//                 if (inMatrix[i, j] > inMatrix[i+1, j]){
//                     tmp = inMatrix[i, j];
//                     inMatrix[i, j] = inMatrix[i+1, j];
//                     inMatrix[i+1, j] = tmp;
//                 }
//             }
//         }
//     }
// }


// void SortMatrixDescendingValuesByColumns(int[,] inMatrix){
//     int tmp = 0;
//     for (int n = 0; n < inMatrix.GetLength(1) - 1; n++){
//         for (int i = 0; i < inMatrix.GetLength(0) - 1; i++){
//             for (int j = 0; j < inMatrix.GetLength(1); j++){
//                 if (inMatrix[i, j] < inMatrix[i+1, j]){
//                     tmp = inMatrix[i, j];
//                     inMatrix[i, j] = inMatrix[i+1, j];
//                     inMatrix[i+1, j] = tmp;
//                 }
//             }
//         }
//     }
// }


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
