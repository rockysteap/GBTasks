// Задача 32:   Напишите программу замена элементов массива: 
//              положительные элементы замените на соответствующие отрицательные, 
//              и наоборот.
//              Например: [-4, -8, 8, 2] -> [4, 8, -8, -2]

using static System.Console;
Clear();

int[] array = { -1, -2, 0, 2, 1, 3, 4 };

ReverseArray(array);
PrintArray(array);


void ReverseArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i] *= -1;
    }
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
