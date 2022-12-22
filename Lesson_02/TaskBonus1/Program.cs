// Два числа равны или больше/меньше?

using static System.Console;
Clear();

WriteLine("Введите первое число 'a': ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите второе число 'b': ");
int b = int.Parse(ReadLine()!);

// вариант 1
// if (a==b) WriteLine(" = ");
// else WriteLine(a<b?"<":">");

// вариант 2
WriteLine(a==b?"a = b":a<b?"a < b":"a > b");