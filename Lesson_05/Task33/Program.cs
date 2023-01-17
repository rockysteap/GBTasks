// **Задача 33:**  Задайте массив. Напишите программу, которая определяет, 
//                 присутствует ли заданное число в массиве.
//                 4; массив [6, 7, 19, 345, 3] -> нет
//                 3; массив [6, 7, 19, 345, 3] -> да

using static System.Console;
Clear();

int number = AskUserForNumber("Введите число для поиска в массиве: ");
int[] array = { -1, -2, 2, 0, 1, 3, 4 };

WriteLine(ArrayLookUp(array, number)? $"Число {number} присутствует в массиве" : $"Число {number} не найдено в массиве");
PrintArray(array);


bool ArrayLookUp(int[] inArray, int num)
{
    foreach (int i in inArray)
    {
        if (num == i) return true;
    }
    return false;
}


int AskUserForNumber(string inPrompt)
/* Recieves command line prompt, parses entered string into integer, in case of success returns that integer. */
{
    int resultNum = 0;
    string userInput = "";
    while (!int.TryParse(userInput, out resultNum))
    {
        Console.Write(inPrompt);
        userInput = Console.ReadLine()!;
    }
    return resultNum;
}


void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    WriteLine($"{inArray[inArray.Length - 1]}]");
}
