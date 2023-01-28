// Задача 58:  Задайте две матрицы. Напишите программу, 
//             которая будет находить произведение двух матриц.
//             Например, даны 2 матрицы:   Результирующая матрица будет:
//                     2 4 | 3 4                       18 20
//                     3 2 | 3 3                       15 18

using static System.Console;
Clear();

string userInput = string.Empty;
int[] userData = new int[4];


MyConsoleMessage("Запуск программы");
Write("\nДля расчёта произведения двух матриц введите в одной строке их размерности."
        + "\nПридерживайтесь шаблона M x N -> N x K для согласованных матриц."
        + "\nВвод: ");
while (true){
    userInput = Console.ReadLine()!;
    if (IsUserNumbersInputValid(userInput)) 
    {
        userData = UserInputParse(userInput);
            if (userData.Length == 4 && 
               (userData[0] > 0 && userData[1] > 0 && userData[2] > 0 && userData[3] > 0) &&
               (userData[1] == userData[2])) break;
            else WriteLine("Матрицы не согласованы!");
            }
    Console.Write($"Обновите ввод: ");
}


WriteLine($"\nСформирована первая матрица размерностью {userData[0]} x {userData[1]}:");
int[,] matrix = CreateRandomValuesMatrix(userData[0], userData[1]);
PrintMatrix(matrix);
WriteLine($"\nСформирована вторая матрица размерностью {userData[2]} x {userData[3]}:");
int[,] matrix2 = CreateRandomValuesMatrix(userData[2], userData[3]);
PrintMatrix(matrix2);
MyConsoleMessage($"Произведение двух матриц:");
int[,] resultMatrix = MatrixMultiply(matrix, matrix2);
PrintMatrix(resultMatrix);
MyConsoleMessage("Завершение");


int[,] MatrixMultiply(int[,] inMatrix1, int[,] inMatrix2){
    int[,] resultMatrix = new int[inMatrix1.GetLength(0), inMatrix2.GetLength(1)]; 
    int tmpSum = 0;
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                tmpSum = 0;
                for (int k = 0; k < inMatrix1.GetLength(1); k++)
                {
                    tmpSum += inMatrix1[i,k] * inMatrix2[k,j];
                }
                resultMatrix[i,j] = tmpSum;
            }
        }
    return resultMatrix;
}


int[,] CreateRandomValuesMatrix(int inRow, int inCol){
    Random rand = new Random();
    int minValue = rand.Next(-99, 0);  int maxValue = rand.Next(0, 100);
    int[,] resultMatrix = new int[inRow, inCol];
    for (int i = 0; i < inRow; i++){
        for (int j = 0; j < inCol; j++){
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


int[] UserInputParse(string inUserInputString)
{
    int[] outData=Array.ConvertAll(inUserInputString
                                        .Split(new char[]{' ', '.', '.', ',', ',', ';', ';', '-'}, 
                                            StringSplitOptions.RemoveEmptyEntries), int.Parse);
    return outData;
}


bool IsUserNumbersInputValid(string inUserInputString)
{
    if (!int.TryParse(string
                            .Join("", inUserInputString
                            .Split(new char[]{' ', '.', '.', ',', ',', ';', ';', '-'}, 
                                StringSplitOptions.RemoveEmptyEntries)), out int a)) return false;
    if (inUserInputString.Split(new char[]{' ', '.', '.', ',', ',', ';', ';', '-'}, 
                                            StringSplitOptions.RemoveEmptyEntries).Length < 2) return false;
    if ( int.TryParse(inUserInputString.Split(new char[]{' ', '.', '.', ',', ',', ';', ';', '-'}, 
                                            StringSplitOptions.RemoveEmptyEntries)[0], out int b) 
      && int.TryParse(inUserInputString.Split(new char[]{' ', '.', '.', ',', ',', ';', ';', '-'}, 
                                            StringSplitOptions.RemoveEmptyEntries)[1], out int c) 
        ) return true;
    else return false;
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
