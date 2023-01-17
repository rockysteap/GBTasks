// Задача 37:  Найдите произведение пар чисел в одномерном массиве. 
//             Парой считаем первый и последний элемент, 
//             второй и предпоследний и т.д. Результат запишите в новом массиве.

using static System.Console;
Clear();

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] res = NumberPairs(array);

Write("Первоначальный массив: ");
PrintArray(array);
Write("Произведение пар: ");
PrintArray(res);


int[] NumberPairs(int[] inArray)
{
    int sizeArray = inArray.Length / 2;
    if (inArray.Length % 2 != 0) sizeArray += 1;

    int[] result = new int[sizeArray];
    
    for (int i = 0; i < sizeArray; i++)
    {
        result[i] = inArray[i] * inArray[inArray.Length - 1 - i];
    }
    return result;
}


void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    WriteLine($"{inArray[inArray.Length - 1]}]");
}
