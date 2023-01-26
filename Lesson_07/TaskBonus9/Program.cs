using System.Linq;
// Какого цвета клетка шахматной доски, если начинается с черной? Например: 1,1 -> черный?
// Какого цвета клетка по введенному адресу (например a5)? Например: A1 -> черный?

// таблица сумм индексов матрицы
// [,]	[j]  0	 1	 2	 3	 4	 5	 6	 7		
// 		     A	 B	 C	 D	 E	 F	 G	 H		
// [i]
// 7	8	 7	 8	 9  10  11  12  13  14		7
// 6	7	 6	 7	 8	 9  10  11  12  13		6
// 5	6	 5	 6	 7	 8   9  10  11  12		5
// 4	5	 4	 5	 6	 7   8	 9  10  11		4
// 3	4	 3	 4	 5	 6   7	 8   9  10		3
// 2	3	 2	 3	 4	 5   6	 7   8	 9		2
// 1	2	 1	 2	 3	 4   5	 6	 7	 8		1
// 0	1	 0	 1	 2	 3   4	 5	 6	 7		0
//											
// 		     0	 1	 2	 3	 4	 5	 6	 7		
//
// Левая нижняя клетка - чёрная, 
// тогда в любом случае чётное значение суммы двух индексов элемента будет давать черный квадрат, 
// а нечётное, соответственно, - белый

// // Часть 1 (ввод 1,1)
// Console.Write("Введите адрес клетки шахматного поля, указав два числа: ");
// var userInput = Console.ReadLine()!
//                             .Split(new char[]{' ', '.', '.', ',', ',', ';', ';', '-'}, 
//                                 StringSplitOptions.RemoveEmptyEntries)
//                             .Select(n => int.Parse(n)-1)
//                             .ToArray()
//                             ;

// string cell = IsBlack(userInput)? "чёрной" : "белой";
// Console.WriteLine($"\nВыбранный адрес {userInput[0]+1},{userInput[1]+1} является {cell} клеткой.\n");

// bool IsBlack(int[] inArray){return ((inArray[0]+inArray[1]) % 2 == 0);}

// Часть 2 (ввод A1)
Console.Write("Введите адрес клетки шахматного поля: ");
var userInput = Console.ReadLine()!
                            .Split(new char[]{' ', '.', '.', ',', ',', ';', ';', '-'}, 
                                StringSplitOptions.RemoveEmptyEntries)
                            ;
string s = string.Join("", userInput);

string cell = IsBlack(s)? "чёрной" : "белой";
Console.WriteLine($"\nВыбранный адрес {s[0]},{s[1]} является {cell} клеткой.\n");
// 
bool IsBlack(string inString){return ((inString[0]+inString[1]) % 2 == 0);}
