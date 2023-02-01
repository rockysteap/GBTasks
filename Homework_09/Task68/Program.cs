// Задача 68:  Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. 
//             Даны два неотрицательных числа m и n.
//             m = 2, n = 3 -> A(m,n) = 9    m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine(AckermanFunc(3,2));


int AckermanFunc(int m, int n){
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0 ) return AckermanFunc(m-1, 1);
    else return AckermanFunc(m - 1, AckermanFunc(m, n-1));
}
