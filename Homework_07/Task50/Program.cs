// Задача 50.  Напишите программу реализующую метод, принимающий позиции элемента в двумерном массиве, 
//             и возвращающий значение этого элемента или же указание, что такого элемента нет.
//             Например, задан массив: 1 4 7 2  5 9 2 3  8 4 2 4
//             1) 1;7 -> такого элемента в массиве нет  2) 1;1 -> 9

// /* Компактное выполнение: начало */
// int[,] matrix = {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};
// Console.Write("Введите искомый адрес элемента: ");
// var address = UserInputParse(Console.ReadLine()!);

// CheckValueInMatrix(matrix, address);

// void CheckValueInMatrix(int[,] inMatrix, int[] inAddress)
// {
//     if (0 <= inAddress[0] && inAddress[0] < inMatrix.GetLength(0) &&
//         0 <= inAddress[1] && inAddress[1] < inMatrix.GetLength(1)) 
//         Console.WriteLine($"По адресу {inAddress[0]};{inAddress[1]} найден элемент со значением {inMatrix[inAddress[0], inAddress[1]]}.");
//     else Console.WriteLine($"По адресу {inAddress[0]};{inAddress[1]} элементов не найдено.");
// }
// /* Компактное выполнение: конец (+ метод UserInputParse внизу) */


// Игра артиллерист-сапер с использованием поиска в массиве
Console.Clear();

int triesCount = 5;
int minesDestroyed = 0;
int fieldRows = 20;
int fieldColumns = 20;
int[] shotCoords = new int[2];

int[,] field = CreateBinaryMatrix(fieldRows, fieldColumns);

while (triesCount > 0)
{
    string userInput = string.Empty;
    Console.Write($"\nПомогите разминировать минное поле размером {fieldRows}х{fieldColumns}\n"
                + $"Выстрелов осталось {triesCount}\n"
                + $"Введите координаты для выстрела: "
                );
    
    while (true){
        userInput = Console.ReadLine()!;
        if (IsUserNumbersInputValid(userInput)) break;
        Console.Write($"Целеуказание введено некорректно: ");
    }
    
    shotCoords = UserInputParse(userInput);
    string shotResult = IsHit(field, shotCoords)? "попал точно в цель!" : "не достиг цели.";
    Console.WriteLine($"Выстрел наводкой ({shotCoords[0]},{shotCoords[1]}) {shotResult}");
    if (IsHit(field, shotCoords)){
        field[shotCoords[0], shotCoords[1]] = 0;
        minesDestroyed++;
    } 
    triesCount--; 
}

Console.Write($"\nКомандование оценило ваши заслуги:\n"
            + $"Попаданий {minesDestroyed}, {MissionSummary(minesDestroyed)}\n");


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


bool IsHit(int[,] inFieldBinaryMatrix, int[] inUserInputCoords)
{
    if (0 <= inUserInputCoords[0] && inUserInputCoords[0] < inFieldBinaryMatrix.GetLength(0) &&
        0 <= inUserInputCoords[1] && inUserInputCoords[1] < inFieldBinaryMatrix.GetLength(1)) 
        return inFieldBinaryMatrix[inUserInputCoords[0], inUserInputCoords[1]] != 0;
    else return false;
}



int[,] CreateBinaryMatrix(int inRows, int inColumns)
{
    int[,] resultMatrix = new int[inRows, inColumns];
    Random rand = new Random();
        for (int i = 0; i < inRows; i++)
        {
            for (int j = 0; j < inColumns; j++)
            {
                resultMatrix[i, j] = rand.Next(2);
            }
        }
    return resultMatrix;
}


string MissionSummary(int inMinesDestroyed)
{
    string resultString = string.Empty;
    switch (inMinesDestroyed) {
        case 0: {
            resultString = "Получите направление к окулисту!";
            break;
        }
        case 1: {
            resultString = "присвоено звание Канонир!";
            break;
        }
        case 2: {
            resultString = "присвоено звание Бомбардир!";
            break;
        }
        case 3: {
            resultString = "присвоено звание Бомбардир-наводчик!";
            break;
        }
        case 4: {
            resultString = "присвоено звание Младший фейерверкер!";
            break;
        }
        case 5: {
            resultString = "присвоено звание Старший фейерверкер. Получите медаль \"За орлиную зоркость!\"";
            break;
        }
    }
    return resultString;
}


// void PrintMatrix(int[,] inMatrix)
// {
//     for (int i = 0; i < inMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inMatrix.GetLength(1); j++)
//         {
//             Console.Write($"{inMatrix[i, j],3} ");  // вывод в 3 символа
//         }
//         Console.WriteLine();
//     }
// }

