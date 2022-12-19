// **Задача 11:**
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

using static System.Console;
Clear();

int number = new Random().Next(100, 1000);
WriteLine(number);
int a = number / 100;
int b = number % 10;

Write(a);
Write(b);

