// Задача 43:  Напишите программу, которая найдёт точку пересечения двух прямых, 
//             заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//             значения b1, k1, b2 и k2 задаются пользователем.
//             Например: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

WriteLine("Введите коэффициенты уравнений прямых для проверки пересечения: ");
int b1 = AskUserForNumber("начальная ордината b1 ->: ");
int k1 = AskUserForNumber("угловой коэффициент k1 ->: ");
int b2 = AskUserForNumber("начальная ордината b2 ->: ");
int k2 = AskUserForNumber("угловой коэффициент k2 ->: ");


Write($"\nПроверим, имеет ли система уравнений"
     + $"\ny = {k1}x + {b1}"
     + $"\ny = {k2}x + {b2} решение?\n");

ProgressBarAnimation(6, 45);
TwoLinesIntersection(b1, k1, b2, k2);


void TwoLinesIntersection(int inB1, int inK1, int inB2, int inK2)
{
    double b1=inB1; double b2=inB2; double k1=inK1; double k2=inK2;
    
    if (k1 == k2 && b1 == b2) {
        WriteLine("Прямые совпадают и имеют бесконечное количество общих точек."); }

    if (k1 == k2 && b1 != b2) {
        WriteLine("Прямые параллельны и не имеют пересекающихся точек."); }
    
    if (k1 != k2) {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        WriteLine($"Прямые не параллельны и имеют точку пересечения в координатах ({x:f1}; {y:f1})."); }
    
    if (k1 * k2 == -1) {
        WriteLine("Также прямые перпендикулярны друг другу."); }
}


void ProgressBarAnimation(int inLength, int inSpeed) {
    Write("\n["); for (int i = 0; i < inLength; i++) { Write("."); } Write("]\r"); Write("[");
    for (int i = 0; i < inLength; i++) {
        for (int j = 0; j < inLength; j++) {
            int speed = new Random().Next(20,inSpeed);
            ComputingAnimation(1, speed); }
        Write("*"); }
    Write("\n");
}


void ComputingAnimation(int inTimer, int inSpeed) {
    // inTimer - количество итераций цикла while
    // inSpeed - время отображения каждого символа (примерно 50ms)
    string symbols = "\\|/-";
    while (inTimer > 0) {
        for (int i = 0; i < symbols.Length; i++) {
            Write(symbols[i]);
            Thread.Sleep(TimeSpan.FromMilliseconds(inSpeed));
            Write("\b"); } 
    inTimer--; }
}


int AskUserForNumber(string inPrompt) {
    int resultNum = 0;
    string userInput = "";
    while (!int.TryParse(userInput, out resultNum)) {
        Console.Write(inPrompt);
        userInput = Console.ReadLine()!; }
    return resultNum;
}

// ax + by + c = 0
// 5x - 1y + 2 = 0
// a1 = 5  b1 = -1  c1 = 2
// 9x - 1y + 4 = 0
// a2 = 9  b2 = -1  c2 = 4
