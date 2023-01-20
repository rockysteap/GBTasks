// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//                 Например: 1) 45 -> 101101  2) 3 -> 11  3) 2 -> 10

using static System.Console;
Clear();

int num = AskUserForNumber("Введите число для перевода в двоичную систему: ");
WriteLine($"\nДесятичное число {num} в двоичном представлении будет {DecimalToBinary(num)}.\n");


string DecimalToBinary(int inNum)
{
    if (inNum == 0) return "0";
    string result = string.Empty;
    // остаток - remainder -> var rem
    int rem;

    while (inNum > 0)
    {
        rem = inNum % 2;
        inNum /= 2;
        result = rem.ToString() + result;
    }
    return result;
}


int AskUserForNumber(string inPrompt)
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
