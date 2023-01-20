// Задача 41:  Пользователь вводит с клавиатуры M чисел. 
//             Посчитайте, сколько чисел больше 0 ввёл пользователь.
//             Например: 1) 0, 7, 8, -2, -2 -> 2  2) 1, -7, 567, 89, 223-> 4

using static System.Console;
Clear();

string userInput = string.Empty;
string savedUserNumbers = string.Empty;


MainMessageForUser();

while (true) {
    Write("->: ");
    userInput = Console.ReadLine()!;
    
    // Проверка если введенные данные можно представить в виде целого числа
    if (int.TryParse(userInput, out int num)) {
        userInput = num.ToString();
        savedUserNumbers = SaveUserNumbers(savedUserNumbers, userInput); } 
    
    // Вывод основного сообщения при пустом вводе
    if (userInput == "") MainMessageForUser();

    // Переход в меню результатов и возврат из меню
    if (userInput == "r" || userInput == "к") {
        ResultConsoleOutput(); MainMessageForUser(); }
    
    // Завершение программы
    if (userInput == "q" || userInput == "й") {
        WriteLine("Программа успешно завершена");
        break; }
}


// Метод для вывода меню результатов и результатов в консоль
void ResultConsoleOutput()
{
    char userCharInput = '0';
    while (true) {
        Write($"\nМеню вывода результатов:"
             + "\n-> (a)ll - подсчет всех введенных чисел"
             + "\n-> (p)ositive - подсчет всех положительных"
             + "\n-> (n)egative - подсчет всех отрицательных"
             + "\n-> (z)ero - подсчет нулевых"
             + "\n-> (q)uit для выхода из меню: "
             + "\n->: "
             );
        
        // Принимаем ввод с клавиатуры и проверяем на ввод пустого
        string userStringInput = ReadLine()!;
        if (!string.IsNullOrEmpty(userStringInput)) { userCharInput = userStringInput[0]; }
        
        // Вывод в консоль в соответствии с пунктом меню
        switch (userCharInput) {
            case 'q': case 'й': { WriteLine("Выбран выход из меню."); break; }
            case 'a': case 'ф': { 
                Write($"\nВведенные числа: {savedUserNumbers}"
                    + $"\nВсего чисел -> {StringValuesCount(savedUserNumbers, "all")}."); break; }
            case 'p': case 'з': { 
                Write($"\nВведенные числа: {savedUserNumbers}"
                    + $"\nПоложительных чисел -> {StringValuesCount(savedUserNumbers, "pos")}."); break; }
            case 'n': case 'т': { 
                Write($"\nВведенные числа: {savedUserNumbers}"
                    + $"\nОтрицательных чисел -> {StringValuesCount(savedUserNumbers, "neg")}."); break; }
            case 'z': case 'я': { 
                Write($"\nВведенные числа: {savedUserNumbers}"
                    + $"\nНулей -> {StringValuesCount(savedUserNumbers, "zer")}."); break; }
            // default: { WriteLine("Что-то пошло не так."); break; } 
        }
    // Выход из меню
    if (userCharInput == 'q' || userCharInput == 'й') break;
    }
}


// Универсальный подсчет чисел с входным условием:
// "all" - посчитать все, "pos" - посчитать положительные, "neg" - посчитать отрицательные, "zer" - посчитать нули
int StringValuesCount(string userNumbers, string inCondition) {
    int result = -1;
    string[] userNumbersArray = userNumbers.Replace(",","").Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] resultArray = new int[userNumbersArray.Length];

    for (int i = 0; i < resultArray.Length; i++) { resultArray[i] = Convert.ToInt32(userNumbersArray[i]); }

    if (inCondition == "all") result = resultArray.Length;
    if (inCondition == "pos") { result++;
        for (int i = 0; i < resultArray.Length; i++) {
            result += resultArray[i] > 0 ? 1 : 0; } }
    if (inCondition == "neg") { result++;
        for (int i = 0; i < resultArray.Length; i++) {
            result += resultArray[i] < 0 ? 1 : 0; } }
    if (inCondition == "zer") { result++;
        for (int i = 0; i < resultArray.Length; i++) {
            result += resultArray[i] == 0 ? 1 : 0; } }

    return result;
}


// Метод для добавления в строку нового элемента и разделителя
string SaveUserNumbers(string inString, string inNumber) {
    string resultString = string.Empty;
    if (string.IsNullOrEmpty(inString))  resultString = inString + inNumber;
    else resultString = inString + ", " + inNumber;
    return resultString;
}

// Метод для вывода основного сообщения
void MainMessageForUser() {
    Write($"\nПрограмма принимает целые числа, вы ввели {savedUserNumbers}" 
        + "\n-> (r)esults для вывода результатов"
        + "\n-> (q)uit для завершения\n"); }
