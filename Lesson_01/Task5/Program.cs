//  Task5. Напишите программу, которая на вход принимает одно число (N), 
//         а на выходе показывает все целые числа в промежутке от -N до N.

//         4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//         2 -> " -2, -1, 0, 1, 2"

using static System.Console;

int i;
int n = 1;
string input = "";

Clear();

while (true)
{
    Write("Введите: 'q'-выход, или 'число'-для просмотра цепочки чисел от '-числа' до '+числа': ");
    input = ReadLine();
    
    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out n))
    {
        for (i=-n;i<n+1;i++) Console.Write($"{i} ");
        WriteLine();
    }
    else if (input == "q") break;
    else WriteLine("Некорректный ввод. Попробуйте ещё раз.");
}
