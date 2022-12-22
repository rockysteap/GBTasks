// 18. По номеру дня недели вывести его название при помощи switch() - case

using static System.Console;
Clear();

Write("Введите число, чтобы получить наименование дня недели: ");
int n = int.Parse(ReadLine()!);

switch(n)
{
    case 1: {
        WriteLine($"День недели № {n} - Понедельник");
        break;
    }
    case 2: {
        WriteLine($"День недели № {n} - Вторник");
        break;
    }
    case 3: {
        WriteLine($"День недели № {n} - Среда");
        break;
    }
    case 4: {
        WriteLine($"День недели № {n} - Четверг");
        break;
    }
    case 5: {
        WriteLine($"День недели № {n} - Пятница");
        break;
    }
    case 6: {
        WriteLine($"День недели № {n} - Суббота");
        break;
    }
    case 7: {
        WriteLine($"День недели № {n} - Воскресенье");
        break;
    }
    default: {
        WriteLine("Ошибка");
        break;
    }
}