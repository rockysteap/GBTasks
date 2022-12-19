// Задача 13:  Напишите программу, которая выводит третью цифру заданного числа 
//             или сообщает, что третьей цифры нет.
//             Например:  1) 645 -> 5  2) 78 -> третьей цифры нет  3) 32679 -> 6

using static System.Console;
Clear();

// Вариант 1 - генерация 10 чисел
int i;
for (i = 0; i < 10; i++){
    int n = new Random().Next(i*(new Random().Next(10000)/2));
    WriteLine($"{(n/100==0?$"{n} -> третьей цифры нет":$"{n} -> {n%1000/100}")}");
    Thread.Sleep(200);
}

// // Вариант 2 - с ручным вводом

// int n;
// string input = "";

// while (true)
// {
//     Write("Введите: 'q'-выход, или число для вывода третьей цифры: ");
//     input = ReadLine()!;

//     if (!string.IsNullOrEmpty(input) && int.TryParse(input, out n))
//     {
//         WriteLine($"{(n/100==0?$"{n} -> третьей цифры нет":$"{n} -> {n%1000/100}")}");
//     }
//     else if (input == "q") break;
//     else WriteLine("Некорректный ввод. Попробуйте ещё раз."); 
// }