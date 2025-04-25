namespace HomeWorkNumb2;

internal class Task2X // НЕДОДЕЛАННО ДОДЕЛАТЬ
{
    public void Execute()
    {
        int count = 0;
        while (true)
        {
            
            Console.WriteLine($"Счетчик:{count}, чтобы окончить отсчёт, введите \"Exit\".");
            count++;
            String Exit = Console.ReadLine();
            if (Exit == "Exit" || Exit == "exit")
            {
                break;
            }
        }
    }
}