namespace HomeWorkNumb2;
internal class Task5X
{
    public void Execute()
    {
        const string CommandExit = "Exit";
        const int EuroDollarDiff = 14;
        const int EuroRubleDiff = 46;
        const int DollarRubleDiff = 83;
        int totalByCurrency = 0;
        int ruble = 1000;
        int dollar = 1000;
        int euro = 1000;
        Console.WriteLine("Добро пожаловать в обменник валют, чтобы продолжить, нажмите \"Enter\". Для выхода из программы писать - \"Exit\" ");
        while (true)
        {
            string input = Console.ReadLine(); 
            if (input?.ToLower() == "exit") //Весь этот if - Подсказка Чата
            {
                Console.WriteLine("Завершение конвертера...");
                Environment.Exit(0);
            }
            if (input == "")
            {
                Console.WriteLine("Ваш выбор конвертации:");
                Console.WriteLine("1. Рубли в доллары.");
                Console.WriteLine("2. Рубли в евро.");
                Console.WriteLine("3. Доллары в рубли.");
                Console.WriteLine("4. Доллары в евро.");
                Console.WriteLine("5. Евро в доллары.");
                Console.WriteLine("6. Евро в рубли");
                Console.WriteLine("Просто нажмите цифру нужного действия.");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        totalByCurrency = ruble / DollarRubleDiff;
                        Console.WriteLine(" ");
                        Console.WriteLine($"У вас {totalByCurrency} долларов...");
                        Console.WriteLine("Для повтора, жать \"Enter\".");
                        break;
                    case ConsoleKey.D2:
                        totalByCurrency = ruble / EuroRubleDiff;
                        Console.WriteLine(" ");
                        Console.WriteLine($"У вас {totalByCurrency} евро...");
                        Console.WriteLine("Для повтора, жать \"Enter\".");
                        break;
                    case ConsoleKey.D3:
                        totalByCurrency = dollar / DollarRubleDiff;
                        Console.WriteLine(" ");
                        Console.WriteLine($"У вас {totalByCurrency} рублей...");
                        Console.WriteLine("Для повтора, жать \"Enter\".");
                        break;
                    case ConsoleKey.D4:
                        totalByCurrency = dollar / EuroDollarDiff;
                        Console.WriteLine(" ");
                        Console.WriteLine($"У вас {totalByCurrency} евро...");
                        Console.WriteLine("Для повтора, жать \"Enter\".");
                        break;
                    case ConsoleKey.D5:
                        totalByCurrency = euro / EuroDollarDiff;
                        Console.WriteLine(" ");
                        Console.WriteLine($"У вас {totalByCurrency} долларов...");
                        Console.WriteLine("Для повтора, жать \"Enter\".");
                        break;
                    case ConsoleKey.D6:
                        totalByCurrency = euro / EuroRubleDiff;
                        Console.WriteLine(" ");
                        Console.WriteLine($"У вас {totalByCurrency} рублей...");
                        Console.WriteLine("Для повтора, жать \"Enter\".");
                        break;
                }
            }
        }
    }
}
