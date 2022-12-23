// Завод смена 3 чел -> 2 младших токаря + 1 старший
// старший = 2*(младший+младший)
// результат = 2*(младший+младший) + (младший+младший) = 6*(младший)
// вход: кол-во деталей за смену

using static System.Console;
Clear();

int junior = 1;
int senior = 2 * (junior + junior);

Write("Введите количество деталей за смену: ");
int product = int.Parse(ReadLine()!);
Write("Введите количество младших токарей: ");
int number_of_junior = int.Parse(ReadLine()!);
Write("Введите количество старших токарей: ");
int number_of_senior = int.Parse(ReadLine()!);

int shift = junior * number_of_junior + senior * number_of_senior;

if (product % shift == 0) {
    WriteLine($"Младшие токари: работал(о) {number_of_junior} человек(а), сделали по {product/shift*junior} деталей.");
    WriteLine($"Старшие токари: работал(о) {number_of_senior} человек(а), сделали по {product/shift*senior} деталей.");
    WriteLine("Это удивительно!");
}
else WriteLine("Столько сделать не могли, они ошиблись в подсчетах!");

// Проверочные значения, например: 240, 4, 2