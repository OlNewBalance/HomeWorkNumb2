namespace domashechka;

using System;

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
internal class Task2 // НЕДОДЕЛАННО ДОДЕЛАТЬ
{
    public void Execute()
    {

        int count = 0;
        while (count < 1555)
        {
            Console.WriteLine($"Счетчик:{count}");
            count++;
            //if(count <1555)
            //{
            //string ex = Console.ReadLine();
            //bool exit = (ex == "exit");
            //}
        }
    }
}
internal class Task3
{
    public void Execute()
    {
        static void Main()
        {
            int[] Numbers = {5, 12, 19, 26, 33, 40, 47, 54, 61, 68, 75, 82, 89, 96};
            foreach (int number in Numbers)
            {
                Console.WriteLine($"Числа: {number}");
            }
        }
    }
}
internal class Task4
{
    public void Execute()
    {

    }
}
internal class Task5
{
    public void Execute()
    {
        
    }
}