﻿// **Задача 14:**

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

using static System.Console;
Clear();

WriteLine("Введите число: ");
int a = int.Parse(ReadLine());

WriteLine(a%7==0 && a% 23==0?"Кратно 7 и 23 одновременно":"Не кратно одновременно 7 и 23");