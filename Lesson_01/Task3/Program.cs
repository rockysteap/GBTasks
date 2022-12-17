// Task3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//        Например:
//        3 -> Среда
//        5 ->  Пятница

using static System.Console;

int n;
string input = "";

Clear();

while (true)
{
    Write("Введите: 'q'-выход, или число, чтобы получить наименование дня недели: ");
    input = ReadLine();
    
    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out n))
    {
        if (1 <= n && n <= 7)
        {
            if (n == 1) WriteLine($"День недели № {n} - Понедельник");
            if (n == 2) WriteLine($"День недели № {n} - Вторник");
            if (n == 3) WriteLine($"День недели № {n} - Среда");
            if (n == 4) WriteLine($"День недели № {n} - Четверг");
            if (n == 5) WriteLine($"День недели № {n} - Пятница");
            if (n == 6) WriteLine($"День недели № {n} - Суббота");
            if (n == 7) WriteLine($"День недели № {n} - Воскресенье");
        }
        else WriteLine("Некорректный ввод, попробуйте ещё раз.");
    }
    else if (input == "q") break;
    else WriteLine("Некорректный ввод, попробуйте ещё раз.");
}
