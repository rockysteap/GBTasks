// **Задача 69:**  Напишите программу, которая на вход принимает два числа A и B, 
//                 и возводит число А в целую степень N с помощью рекурсии.
//                 A = 3; N = 5 -> 243 (3⁵)
//                 A = 2; N = 3 -> 8

Console.Clear();

int result = GetPower(3,5);
Console.WriteLine(result);

PrintPower(2,10);


int GetPower(int a, int n)
{
    if (n == 0) return 1;
    else return GetPower(a, n - 1) * a;
}


void PrintPower(int a, int n, int tmp = 1, int i = 0)
// Print out results of raising number a to the power n
{
    tmp *= a; i++; // tmp - intermediate results storage; i - recursion calls counter
    if (n == 0) Console.WriteLine ($"{a}^0 = 1");
    else if (n == 1) Console.WriteLine ($"{a}^{i} = {tmp}");
    else PrintPower (a, n-1, tmp, i);
}
