# Basics of programming test work description.

Перед Вами **интеллектуальный помощник** для решения задачи формирования нового массива из строк другого массива, длина которых не превышет 3.

Почти перед каждым выводом текста на экран, помощник делает паузу. Это сделано для достижения эфекта "живого общения".

Помощник не только предложит Вам несколько путей решения, но также постарается проследить, чтобы Вы не допустили никаких ошибок при работе с ним! Но не судите его строго, он еще только учится...
____

## Список методов помощника:

1. [`YesOrNo`](#yesorno)
1. [AiCreateArray](#aicreatearray)
1. [AiFeelArray](#aifeelarray)
1. [ManualyCreateArray](#manualycreatearray)
1. [CountShortWords](#countshortwords)
1. [FeelOutputArray](#feeloutputarray)

### YesOrNo

Метод позволяют помощнику спросить пользователя о чем-то, а затем считать значение нажатой пользователем кнопки.

```
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
```
### AiCreateArray

В данном методе помощник запрашивает у пользователья длинну массива и создает его.

```
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
```
### AiFeelArray

Метод позволяет помощнику с помощью массива символов, в котором хранится алфавит, случайным образом собрать необходимое количество слов случайной длины.

```
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
```
### ManualyCreateArray

В случае если пользователь предпочел ввести все слова вручную, данный метод позволяет распарсить вводимый пользователем текст на слова и сложить их в строковый массив.

```
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
```
### CountShortWords

В этом методе производится подсчёт количества слов длина которых не превышает 3. 

```
int CountShortWords(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4) { count++; }
    }
    return count;
}
```
### FeelOutputArray

Это основной метод, который позволяет заполнить результирующий массив необходимыми словами.
Работа этого метода подробно описана в [блок-схеме](/scheme.drawio.png).

```
void FeelOutputArray(string[] inArr, string[] outArr)
{
    int count = 0;
    for (int i = 0; i < inArr.Length; i++)
    {
        if (inArr[i].Length < 4) { outArr[count++] = inArr[i]; }
    }
}
```

## Спасибо что дочитали до конца!