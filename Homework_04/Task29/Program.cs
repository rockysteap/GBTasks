// Задача 29:  Напишите программу, реализующую метод, 
//             который формирует массив случайных целых чисел 
//             из 8 элементов и выводит их на экран.
//             Например:  1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

using static System.Console;
Clear();

Write("Введите размер массива: ");
int.TryParse(ReadLine(), out int array_size);
Write("Введите начало диапазона значений массива: ");
int.TryParse(ReadLine(), out int min_number);
Write("Введите окончание диапазона значений массива: ");
int.TryParse(ReadLine(), out int max_number);


int[] array = InitAndShowArray(array_size, min_number, max_number);


// Длинный вариант (2 цикла)

int[] InitAndShowArray(int size, int min, int max)
{
    int[] result = new int[size];
    int ran_max, ran_min;

    if (min > max) { ran_max = min + 1; ran_min = max; }
    else { ran_max = max + 1; ran_min = min; }

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(ran_min, ran_max);
    }
    Write("[");
    for (int i = 0; i < result.Length; i++)
    {
        Write($"{result[i]}, ");
    }
    WriteLine("\b\b]");
    return result;
}


// // Короткий вариант (1 цикл)

// int[] InitAndShowArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     int ran_max, ran_min;
//     if (min > max) {ran_max = min + 1; ran_min = max;} 
//     else {ran_max = max + 1; ran_min = min;}
//     Write("[");
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(ran_min, ran_max);
//         Write($"{result[i]}, ");
//     }
//     WriteLine("\b\b]");
//     return result;
// }
