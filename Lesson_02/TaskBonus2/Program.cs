// Вывести разницу между большим и меньшим из трех чисел.

using static System.Console;
Clear();

int a = new Random().Next(100);
int b = new Random().Next(100);
int c = new Random().Next(100);

int max = a<b?(b<c?c:b):a<c?c:a;
int min = a>b?(b>c?c:b):a>c?c:a;

WriteLine($"Число a = {a}, число b = {b}, число c = {c}, разница между мин ({min}) и макс ({max}) = {max-min}.");
WriteLine();
