namespace HomeWorkNumb2;

internal class Task2V
{
    public void Execute()
    {
        int count = 0;
        string userInput = "";
        
        while (userInput?.ToLower() != "exit")
        {
            Console.WriteLine($"Счетчик:{count}, чтобы окончить отсчёт, введите \"exit\".");
            count++;
            
            userInput = Console.ReadLine();
        }
    }
}
