// Задача 19: Не использовать обращение к символу строки, только математические методы работы с числами
//            Напишите программу, которая принимает на вход пятизначное число и проверяет,
//            является ли оно палиндромом.
//            Например:  1) 14212 -> нет  2) 12821 -> да  3) 23432 -> да

using static System.Console;
Clear();

Write("Введите число (до 10 символов) для проверки свойства палиндрома: ");
int.TryParse(ReadLine(), out int n);

int d = (int)Math.Log10(n) + 1;  // d - digits (кол-во цифр в числе)
int i = 1;

if (d % 2 == 0)
{
    while (i < d / 2)
    {
        if ((
                Convert.ToInt32(n % (Math.Pow(10, (d - i))))
                /
                Convert.ToInt32(Math.Pow(10, (d - i - 1)))
            ) != (
                Convert.ToInt32(n % (Math.Pow(10, (i + 1))))
                /
                Convert.ToInt32(Math.Pow(10, (i)))
        ))
        {
            WriteLine($"Число {n} не является палиндромом.");
            return;
        }
        i++;
    }
}
else if (d % 2 != 0)
{
    while (i < d / 2)
    {
        if ((
                Convert.ToInt32(n % (Math.Pow(10, (d - i))))
                /
                Convert.ToInt32(Math.Pow(10, (d - i - 1)))
            ) != (
                Convert.ToInt32(n % (Math.Pow(10, (i + 1))))
                /
                Convert.ToInt32(Math.Pow(10, (i)))
        ))
        {
            WriteLine($"Число {n} не является палиндромом.");
            return;
        }
        i++;
    }
}

WriteLine($"Число {n} является палиндромом.");
