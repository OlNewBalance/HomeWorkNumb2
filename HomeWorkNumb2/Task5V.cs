namespace HomeWorkNumb2;
internal class Task5V
{
    public void Execute()
    {
        const string CommandExit = "Exit";
        const int EuroDollarDiff = 14;
        const int EuroRubleDiff = 46;
        const int DollarRubleDiff = 83;
        //const int Command1;
        //const int Command2; Извини, но не увидел смысла, так как в switch рабоатет  система consoleKey, я не понял как её и const связать. Знаю что надо, по "правилам".
        //const int Command3;
        //const int Command4;
        //const int Command5;
        //const int Command6;
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
                Console.WriteLine("5. Евро в долары.");
                Console.WriteLine("6. Евро в рубли");
                Console.WriteLine("Просто нажмите цифру нужного действия.");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        break;
                }

                if (keyInfo.Key == ConsoleKey.D1)
                {
                    totalByCurrency = ruble / DollarRubleDiff;
                    Console.WriteLine(" ");
                    Console.WriteLine($"У вас {totalByCurrency} долларов...");
                }

                if (keyInfo.Key == ConsoleKey.D2)
                {
                    totalByCurrency = ruble / EuroRubleDiff;
                    Console.WriteLine(" ");
                    Console.WriteLine($"У вас {totalByCurrency} евро...");
                }

                if (keyInfo.Key == ConsoleKey.D3)
                {
                    totalByCurrency = dollar / DollarRubleDiff;
                    Console.WriteLine(" ");
                    Console.WriteLine($"У вас {totalByCurrency} рублей...");
                }

                if (keyInfo.Key == ConsoleKey.D4)
                {
                    totalByCurrency = dollar / EuroDollarDiff;
                    Console.WriteLine(" ");
                    Console.WriteLine($"У вас {totalByCurrency} евро...");
                }

                if (keyInfo.Key == ConsoleKey.D5)
                {
                    totalByCurrency = euro / EuroDollarDiff;
                    Console.WriteLine(" ");
                    Console.WriteLine($"У вас {totalByCurrency} долларов...");
                }

                if (keyInfo.Key == ConsoleKey.D6)
                {
                    totalByCurrency = euro / EuroRubleDiff;
                    Console.WriteLine(" ");
                    Console.WriteLine($"У вас {totalByCurrency} рублей...");
                }

                if (keyInfo.Key != ConsoleKey.D1 && keyInfo.Key != ConsoleKey.D2 && keyInfo.Key != ConsoleKey.D3 &&
                    keyInfo.Key != ConsoleKey.D4 && keyInfo.Key != ConsoleKey.D5 && keyInfo.Key != ConsoleKey.D6)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Ошибка");
                }
            }
        }
    }
}
