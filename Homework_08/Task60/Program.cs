// Задача 60.  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//             Напишите программу, которая будет построчно выводить массив, 
//             добавляя индексы каждого элемента.
//             Например: Массив размером 2 x 2 x 2
//                         66(0,0,0) 25(0,1,0)
//                         34(1,0,0) 41(1,1,0)
//                         27(0,0,1) 90(0,1,1)
//                         26(1,0,1) 55(1,1,1)

using static System.Console;
Clear();

MyConsoleMessage("Запуск программы", 78);
int[,,] cube = CreateRandomCubeWithUniqeValues();
WriteLine($"Сформирован трёхмерный массив размерностью "
        + $"{cube.GetLength(0)} x {cube.GetLength(1)} x {cube.GetLength(2)} "
        + $"c уникальными значениями:\n");
PrintCubeWithIndex(cube);
MyConsoleMessage("Завершение", 78);


int[,,] CreateRandomCubeWithUniqeValues(){
    Random rand = new Random();
    // 3D array dimensions
    // Так как двузначных всего 90, а кубический корень из 90 примерно равен 4.5,
    // то массив с уникальными значениями не должен превышать 4 по одному из измерений 
    int sMin = 1, sMax = 5; // min/max size 
    int d1 = rand.Next(sMin, sMax), d2 = rand.Next(sMin, sMax), d3 = rand.Next(sMin, sMax);
    int minV = 10, maxV = 100; // min/max borders
 
    // Подготовка уникальных значений
    int[] cubeValues = new int[d1*d2*d3];
    int tmp = 0; bool isUnique = false;
    for (int i = 0; i < cubeValues.Length; i++){
        tmp = rand.Next(minV, maxV);
        isUnique = true;
            for (int j = 0; j < cubeValues.Length; j++){
                if (cubeValues[j] == tmp) {i--; isUnique = false; break;}
            }
        if (isUnique) {cubeValues[i] = tmp;}
    }

    // Формирование трёхмерного массива
    int[,,] resultCube = new int[d1, d2, d3]; int index = 0;
        for (int i = 0; i < d1; i++){
            for (int j = 0; j < d2; j++){
                for (int k = 0; k < d3; k++){
                    resultCube[i,j,k] = cubeValues[index];
                    index++;
                }
            }
        }
    return resultCube;
}


void PrintCubeWithIndex(int[,,] inCube){
    for (int i = 0; i < inCube.GetLength(0); i++){
        for (int j = 0; j < inCube.GetLength(1); j++){
            for (int k = 0; k < inCube.GetLength(2); k++){
                Console.Write($"{inCube[i, j, k],4}({i},{j},{k}) ");
            }    
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void MyConsoleMessage(string inMessage = "-", int inLength = 60, char inDividerChar = '-')
// Выводит в консоль входящее сообщение дополняя символами до заданной длины
{
    if (inMessage.Length > inLength){
        Console.WriteLine("Ошибка: длина передаваемой строки выходит за границы");
    }
    else{
        int mL = inMessage.Length; int iL = inLength; 
        int dividerTimes = (iL-mL)/2;
        int k = (iL-mL)%2!=0 ? 1 : 0; // доп.символ в случае нечётного количества
        Console.Write($"\n{new string(inDividerChar, dividerTimes)}"
            + $"{inMessage}{new string(inDividerChar, dividerTimes+k)}\n");
    }
}
