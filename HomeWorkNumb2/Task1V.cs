namespace HomeWorkNumb2;

internal class Task1
{
    public void Execute()
    {
        int count = 0;
        Console.WriteLine("Введите текст для повтора:");
        string text = Console.ReadLine();
        Console.WriteLine("Введите количество повторов:");
        string repsInput = Console.ReadLine();
        int reps;
        while (!int.TryParse(repsInput, out reps))
        {
            Console.WriteLine("Некорректный ввод, введите целое число:");
            repsInput = Console.ReadLine();
        }
        while (count < reps)
        {
            Console.WriteLine($"{text}");
            count++;
        }
    }
}
