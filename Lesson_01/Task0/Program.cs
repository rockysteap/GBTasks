// Task0
// Чему равен квадрат введенного числа?

using static System.Console;

Clear();

WriteLine("Введите число: ");

// int a = int.Parse(ReadLine()!);  // int.Parse() - Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком.
int a = Convert.ToInt32(ReadLine());  // Convert.ToInt32() - Преобразует заданное значение в 32-битовое целое число со знаком.
WriteLine($"Квадрат числа {a} равен {a*a}");
