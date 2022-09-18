/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int cntGreaterThanZero = 0;
List<int> numbers = new();

bool quit = false;
while (!quit)
{
    Console.WriteLine("Введите число. Для вывода результата нажмите Q:");

    ConsoleKeyInfo inputChar = Console.ReadKey();

    if (inputChar.Key == ConsoleKey.Q)
    {
        quit = true;
        int x,y;
        (x,y) = Console.GetCursorPosition();
        Console.SetCursorPosition(0, y);        
        continue;
    }

    string inputStr = inputChar.KeyChar + Console.ReadLine() ?? string.Empty;

    bool resInputCheck = int.TryParse(inputStr, out int number);

    if (!resInputCheck)
    {
        Console.WriteLine("Ошибка ввода.");
        continue;
    }

    numbers.Add(number);
    
    if (number > 0)
        cntGreaterThanZero++;
}

int totalCount = numbers.Count();

if (totalCount == 1)
    Console.WriteLine($"[{numbers[0]}] -> {cntGreaterThanZero}");
else    
    for(int i = 0; i < numbers.Count(); i++)
    {        
        Console.Write($"{(i == 0 ? "[" + numbers[i] : (i == totalCount-1 ? ", " + numbers[i] + "] -> " + cntGreaterThanZero : ", " + numbers[i]))}");
    }






