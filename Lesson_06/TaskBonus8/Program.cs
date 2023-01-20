// 6 знаков билетик, сумма первых трех равна сумме вторых трех

using static System.Console;
Clear();


// Вариант со строковыми вводными данными
Write("Введите номер билета: ");
string ticket = ReadLine()!;
WriteLine(IsLuckyTicket2(ticket) ? $"\nБилетик {ticket} счастливый.\n" : $"\nБилетик {ticket} не счастливый.\n");


bool IsLuckyTicket2(string inString)
{
    int partOne = 0, partTwo = 0;
    for (int i = 0; i < inString.Length / 2; i++)
    {
        partOne += (int)Char.GetNumericValue(inString[i]);
        partTwo += (int)Char.GetNumericValue(inString[inString.Length - i - 1]);
        // для проверки вычислений
        // WriteLine($"{partOne} {partTwo}");
    }
    return partOne == partTwo;
}


// // Вариант с целочисленными вводными данными
// int ticket = AskUserForNumber("Введите номер билета: ");
// WriteLine(IsLuckyTicket(ticket) ? $"\nБилетик {ticket} счастливый.\n" : $"\nБилетик {ticket} не счастливый.\n");
//
//
// bool IsLuckyTicket(int inNum)
// {
//     // 123456
//     // abcdef
//     int a = inNum / 100000;
//     int b = (inNum / 10000) % 10;
//     int c = (inNum / 1000) % 10;
//     int d = (inNum % 1000) / 100;
//     int e = (inNum % 1000) / 10 % 10;
//     int f = (inNum % 1000) % 10;
//     // для проверки вычислений
//     // WriteLine($"{a} {b} {c} {d} {e} {f}");
//     return (a + b + c == d + e + f);
// }
//
//
// int AskUserForNumber(string inPrompt)
// {
//     int resultNum = 0;
//     string userInput = "";
//     while (!int.TryParse(userInput, out resultNum))
//     {
//         Console.Write(inPrompt);
//         userInput = Console.ReadLine()!;
//     }
//     return resultNum;
// }
