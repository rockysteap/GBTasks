// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// Например:  1) 78 -> 8  2) 12-> 2  3) 85 -> 8

using static System.Console;
Clear();

int number = new Random().Next(10, 100);
WriteLine(number);
int a1 = number/10;
int a2 = number%10;
int max=a1>a2?a1:a2; // тернарный оператор
WriteLine(max);

WriteLine(number/10>number%10?number/10:number%10);

// if(a1>a2)
// {
//     WriteLine(a1);
// }
// else
// {
//     WriteLine(a2);
// }

// using static System.Console;
// Clear();

// int number=new Random().Next(10,100);
// WriteLine(number);
// WriteLine(number/10>number%10?number/10:number%10);

// if(number/10>number%10)
// {
//     WriteLine(number/10);
// }
// else
// {
//     WriteLine(number%10);
// }
