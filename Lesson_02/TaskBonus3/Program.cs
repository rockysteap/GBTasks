﻿// Два стрелка расстреливают какое то количество банок, но последняя всегда выходит спорной.
// Сколько банок изначально?

using static System.Console;
Clear();

int a = new Random().Next(100);
int b = new Random().Next(100);

WriteLine($"Первый стрелок расстрелял {a} банок, второй - {b}, одна была спорной, поэтому всего банок {a+b-1}.");
WriteLine();
