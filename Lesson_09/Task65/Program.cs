// **Задача 65:**  Задайте значения M и N. Напишите программу, 
//                 которая выведет все натуральные числа в промежутке от M до N.
//                 Например: 1)  M = 1; N = 5. -> "1, 2, 3, 4, 5"  2)  M = 4; N = 8. -> "4, 5, 6, 7, 8"

using static System.Console;
Clear();

// Write("Введите M: ");
// int m = int.Parse(ReadLine());
// Write("Введите N: ");
// int inN = ReadLine();

PrintNums(5,2);
WriteLine();
// WriteLine(GetNumbers(2, 5));
// WriteLine();
// WriteLine(GetNumbersTernary(2, 5));

// Для входящих M > N и N > M
void PrintNums(int inM, int inN)
{
    if (inN == inM) Write(inN);
    else {
        if (inM > inN) {
            PrintNums(inN, inM-1);
            Write($", {inM}");
        }
        else {
            PrintNums(inM, inN-1);
            Write($", {inN}");
        }
    }
}

string GetNumbers(int inM, int inN)
{
    if (inN == inM) return inN.ToString();
    else return $"{GetNumbers(inM, inN - 1)}, {inN}";
}

string GetNumbersTernary(int inM, int inN)
{
    return (inN == inM) ? inN.ToString() : $"{GetNumbersTernary(inM, inN - 1)}, {inN}";
}
