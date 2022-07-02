Console.Clear();
Console.WriteLine("Вас приветствует Мастер решения контрольной задачи!");
Console.WriteLine();


bool YesOrNo(string question)
{
    bool res = true; // Если 'Y' тогда true
    bool correctKey = false;
    while (correctKey != true)
    {
        Console.Write(question);
        ConsoleKeyInfo cki;
        cki = Console.ReadKey();
        if (cki.Key.ToString() == "Y" || cki.Key.ToString() == "N")
        {
            if (cki.Key.ToString() == "Y")
            {
                correctKey = true;
            }
            else if (cki.Key.ToString() == "N")
            {
                correctKey = true;
                res = false;
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Простите, я Вас не понял. Давайте попробуем ещё раз!");
        }
    }
    return res;
}

string[] AiCreateArray()
{
    Console.WriteLine();
    Console.WriteLine();
    Thread.Sleep(1000);
    Console.WriteLine("Отлично!");
    Console.WriteLine("Приступаю к созданию массива...");
    Thread.Sleep(1000);
    Console.WriteLine();
    Console.Write("Сколько слов будет в массиве? ");
    int len = int.Parse(Console.ReadLine());
    string[] stringArray = new string[len];
    return stringArray;
}

string[] AiFeelArray(string[] stringArray)
{
    if (stringArray.Length > 0)
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
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine($"Готово!");
        Console.Write($"Вот массив слов: ");
        Console.WriteLine($"[ {string.Join(", ", stringArray)} ]");
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine($"Никто не говорил, что это будут человеческие слова...");
    }
    return stringArray;
}

string[] ManualyCreateArray()
{
    Console.WriteLine();
    Console.WriteLine();
    Thread.Sleep(1000);
    Console.WriteLine("Отлично!");
    Thread.Sleep(1000);
    Console.Write("Введите массив слов через пробел: ");
    string[] stringArray = new string[0];
    stringArray = Console.ReadLine().Split().ToArray();
    return stringArray;
}

int CountShortWords(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4) { count++; }
    }
    return count;
}

void FeelOutputArray(string[] inArr, string[] outArr)
{
    int count = 0;
    for (int i = 0; i < inArr.Length; i++)
    {
        if (inArr[i].Length < 4) { outArr[count++] = inArr[i]; }
    }
}


// ________________________________________________________________________
bool endOfProgramm = false;
while (endOfProgramm != true)
{
    string[] inputArray = new string[0];
    bool feelWay = YesOrNo(question: "Задать массив слов автоматически? y/n ");
    if (feelWay == true)
    {
        inputArray = AiCreateArray();
        inputArray = AiFeelArray(inputArray);
    }
    else { inputArray = ManualyCreateArray(); }

    if (inputArray.Length > 0 && inputArray[0].Length > 0)
    {
        int amount = CountShortWords(inputArray);  // количество коротких cлов в исходном массиве
        if (amount > 0)
        {
            string[] outputArray = new string[amount];
            FeelOutputArray(inputArray, outputArray);
            Console.WriteLine();
            string result = $"[ {string.Join(", ", outputArray)} ]"; // на практикуме за сохранения ответа в строку обещали плюс в карму!)))ё
            Thread.Sleep(1000);
            Console.WriteLine($"Вот итоговый массив: {result} ");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Задача решена!");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("С Вами приятно было иметь дело!");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Всего хорошего!");
            endOfProgramm = true;
        }
        else
        {
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("К сожалению, в этом массиве нет слов, длина которых меньше либо равна 3 символам. :(");
            Console.WriteLine();
            Thread.Sleep(1000);
            bool tryAgain = YesOrNo(question: "Хотите попробовать еще раз? y/n ");
            if (tryAgain == false)
            {
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("Очень жаль!");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("С Вами приятно было иметь дело!");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("Всего хорошего!");
                endOfProgramm = true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("Отлично! Давайте попробуем ещё раз!");
                Thread.Sleep(2000);
                Console.Clear();
            }

        }

    }
    else
    {
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine("У меня нет слов! ;)");
        Console.WriteLine();
        Thread.Sleep(1000);
        bool tryAgain = YesOrNo(question: "Хотите попробовать еще раз? y/n ");
        if (tryAgain == false)
        {
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Очень жаль!");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("С Вами приятно было иметь дело!");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Всего хорошего!");
            endOfProgramm = true;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Отлично! Давайте попробуем ещё раз!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}