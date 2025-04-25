namespace HomeWorkNumb2;

internal class Task1
{
    public void Execute()
    {
        int count = 0;
        Console.WriteLine("Введите текст для повтора:");
        string text = Console.ReadLine();
        Console.WriteLine("Введите количество повторов:");
        int reps = Convert.ToInt32(Console.ReadLine());
        while (count < reps)
        {
            Console.WriteLine($"{text}");
            count++;
        }
    }
}