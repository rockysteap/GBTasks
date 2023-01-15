// 30. Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.  // [1,0,1,1,0,1,0,0]
// Далее напишите метод, который изменяет готовый массив.

using static System.Console;
Clear();

int[] array = InitBinaryArray(8);
int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
int[] array2 = new int[6];

Write("array = InitBinaryArray() -> ");
PrintArray(array);WriteLine();

Write("array1 -> ");
PrintArray(array1);
ChangeArrayPermanently(array1);
Write("void ChangeArrayPermanently(array1) -> ");
PrintArray(array1);WriteLine();

Write("array2 -> ");
PrintArray(array2);
ChangeArrayPermanently(array2);
Write("void ChangeArrayPermanently(array2) -> ");
PrintArray(array2);WriteLine();

Write("array1 -> ");
PrintArray(ChangeArrayTemporary(array1));
Write("void ChangeArrayTemporary(array1) -> ");
PrintArray(array1);WriteLine();


Write("array2 -> ");
PrintArray(ChangeArrayTemporary(array2));
Write("void ChangeArrayTemporary(array2) -> ");
PrintArray(array2);WriteLine();


int[] InitBinaryArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(2);
    }
    return res;
}

int[] ChangeArrayTemporary(int[] arr)
{
    int[] res = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        res[i] = new Random().Next(2);
    }
    return res;
}

void ChangeArrayPermanently(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(2);
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Write($"{arr[i]} ");
    }
    WriteLine();
}