// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом 
// 
// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо 
// равна 3 символа. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// 
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();
Console.WriteLine("Вас приветствует Мастер решения контрольной задачи!");
Console.WriteLine();

bool ChooseFeelWay()
{
    bool way = true;
    bool correctKey = false;
    while (correctKey != true)
    {
        Console.Write("Задать массив слов автоматически? y/n ");
        ConsoleKeyInfo cki;
        cki = Console.ReadKey();
        if (cki.Key.ToString() == "Y")
        {
            correctKey = true;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Отлично! Приступаю к созданию массива...");
        }
        else if (cki.Key.ToString() == "N")
        {
            correctKey = true;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Отлично! Введите массив слов через пробел: ");
            way = false;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Простите, я Вас не понял. Давайте попробуем ещё раз!");
        }
    }
    return way;
}

string[] AiCreateArray()
{
    Console.WriteLine();
    Console.Write("Сколько слов будет в массиве? ");
    int len = int.Parse(Console.ReadLine());
    string[] stringArray = new string[len];
    return stringArray;
}

string[] AiFeelArray(string[] stringArray)
{
    char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    Random rand = new Random();
    for (int i = 0; i < stringArray.Length; i++)
    {
        string tmpWord = "";
        for (int j = 0; j < rand.Next(1, 10); j++)
        {
            int lettersNum = rand.Next(0, letters.Length - 1);
            tmpWord += letters[lettersNum];
        }
        stringArray[i] = tmpWord;
    }
    return stringArray;
}

string[] ManualyCreateArray()
{
    string[] stringArray = Console.ReadLine().Split().ToArray();
    // исключение пустой массив
    return stringArray;
}




string[] inputArray = new string[0];

if (ChooseFeelWay() == true)
{
    inputArray = AiCreateArray();
    inputArray = AiFeelArray(inputArray);
    Console.WriteLine();
    Console.Write($"Готово! Вот массив слов: ");
    Console.WriteLine($"[ {string.Join(", ", inputArray)} ]");
    Console.WriteLine();
    Console.WriteLine($"Никто не говорил, что это будут человеческие слова...");
}
else { inputArray = ManualyCreateArray(); }

