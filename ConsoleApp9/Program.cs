﻿do
{
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.LeftArrow)
    {
        strela_pravo_and_levo();
    }
    else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
    {
        strela_vverx_and_vniz();
    }
    else if (key.Key == ConsoleKey.Escape)
    {
        break;
    }
}
while (true);
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
static void strela_pravo_and_levo()
{
    int a = 1;
    int b = 10;
    int c = 2022;
    do
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.LeftArrow)
        {
            a = a - 1;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("->");
            if (a == 10)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                a_10();
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (a == 10 && key1.Key == ConsoleKey.Enter)
                {
                    a_102();
                    ConsoleKeyInfo key2 = Console.ReadKey();
                    if (a == 10 && key2.Key == ConsoleKey.Backspace)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("->");
                        Console.WriteLine("1.Сделать ежедневник");
                    }
                }
            }
            if (a == 9)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                a_9();
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (a == 9 && key1.Key == ConsoleKey.Enter)
                {
                    a_92();
                    ConsoleKeyInfo key2 = Console.ReadKey();
                    if (a == 9 && key2.Key == ConsoleKey.Backspace)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("->");
                        Console.WriteLine("Поиграть в доту");
                    }
                }
            }

            if (a == 17)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                a_17();
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (a == 17 && key1.Key == ConsoleKey.Enter)
                {
                    a_172();
                    ConsoleKeyInfo key2 = Console.ReadKey();
                    if (a == 17 && key2.Key == ConsoleKey.Backspace)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("->");
                        Console.WriteLine("Навестить 350 Z");
                    }
                }
            }
        }
        else if (key.Key == ConsoleKey.RightArrow)
        {
            a = a + 1;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("->");
            if (a == 10)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                a_10();
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (a == 10 && key1.Key == ConsoleKey.Enter)
                {
                    a_102();
                    ConsoleKeyInfo key2 = Console.ReadKey();
                    if (a == 10 && key2.Key == ConsoleKey.Backspace)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(2, 1);
                        Console.WriteLine("1.Сделать ежедневник");
                    }
                }
            }
            if (a == 9)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                a_9();
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (a == 9 && key1.Key == ConsoleKey.Enter)
                {
                    a_92();
                    ConsoleKeyInfo key2 = Console.ReadKey();
                    if (a == 9 && key2.Key == ConsoleKey.Backspace)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(2, 1);
                        Console.WriteLine("Поиграть в доту");
                    }
                }
            }
            if (a == 17)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                a_17();
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (a == 17 && key1.Key == ConsoleKey.Enter)
                {
                    a_172();
                    ConsoleKeyInfo key2 = Console.ReadKey();
                    if (a == 17 && key2.Key == ConsoleKey.Backspace)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(2, 1);
                        Console.WriteLine("Упустить все дедлайны");
                    }
                }
            }
        }
        else
        {
            break;
        }
    }
    while (true);
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
static void strela_vverx_and_vniz()
{
    int posit = 1;
    Console.SetCursorPosition(0, posit);
    Console.WriteLine("->");
    do
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.UpArrow)
        {
            posit--;
        }
        else if (key.Key == ConsoleKey.DownArrow)
        {
            posit++;
        }
        else
            break;
        Console.Clear();
        Console.SetCursorPosition(0, posit);
        Console.Write("->");
    }
    while (true);
}
///////////////////////////////////////////////////////////////////////////////////////////////////
static void a_10()
{
    Console.SetCursorPosition(0, 1);
    Console.WriteLine("->");
    Console.SetCursorPosition(2, 1);
    Console.WriteLine("1.Сделать ежедневник");
}
static void a_102()
{
    Console.Clear();
    Console.WriteLine("Сделать ежедневник");
    Console.WriteLine("Написать практическую");
    Console.WriteLine("Дата: 14.10.2022  0:00:00");
}
static void a_9()
{
    Console.SetCursorPosition(0, 1);
    Console.WriteLine("->");
    Console.SetCursorPosition(2, 1);
    Console.WriteLine("Поиграть в комп");
}
static void a_92()
{
    Console.Clear();
    Console.WriteLine("Открыть майнкрафт");
    Console.WriteLine("Узнать что задано");
    Console.WriteLine("Дата: 11.9.2001  12:30:00");
}
static void a_17()
{
    Console.SetCursorPosition(0, 1);
    Console.WriteLine("->");
    Console.SetCursorPosition(2, 1);
    Console.WriteLine("Пропустить матч");
}
static void a_172()
{
    Console.Clear();
    Console.WriteLine("Сесть за комп");
    Console.WriteLine("Умолять поставить пять за упущенный дедлайн.");
    Console.WriteLine("Дата: 31.12.2077  24:00:00");
}
