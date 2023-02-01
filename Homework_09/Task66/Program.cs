// Задача 66:  Напишите программу, которая реализует рекурсивный метод 
//             нахождения суммы натуральных элементов в промежутке от M до N.
//             M = 1; N = 15 -> 120        M = 4; N = 8. -> 30


int m = 8, n = -4; Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {GetIntSum(m,n)}.");
m = -4; n = 8; Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {GetIntSum(m,n)}.");


int GetIntSum(int a, int b){
    if (a == b) return b;
    else if (a > b) return a + GetIntSum(a - 1, b);
    else return a + GetIntSum(a + 1, b);
}