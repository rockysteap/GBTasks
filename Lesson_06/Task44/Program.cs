// **Задача 44:**  Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//                 Первые два числа Фибоначчи: 0 и 1.
//                 Например: 1) Если N = 5 -> 0 1 1 2 3  2) Если N = 3 -> 0 1 1  3) Если N = 7 -> 0 1 1 2 3 5 8

using static System.Console;
Clear();

int num = AskUserForNumber("Введите число N для демонстрации первых N чисел ряда Фибоначчи: ");
int[] sequence = Fibonacci(num);

for (int i = 0; i < sequence.Length; i++)
{
    Write($"{sequence[i]} ");
}



int[] Fibonacci(int inNum)
{
    if (inNum < 1) { int[] result2 = {0}; return result2; }

    int[] result = new int[inNum]; result[0] = 0; result[1] = 1;
    
    for (int i = 2; i < inNum; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
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
