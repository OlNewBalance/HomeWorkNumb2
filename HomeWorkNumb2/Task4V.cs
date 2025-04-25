namespace HomeWorkNumb2;

internal class Task4X //В данном задании я многое не понял.
{
    public void Execute()
    {
        Random random = new Random();
        int number = random.Next(1, 101);
        Console.WriteLine($"Рандомное число {number}.");
        int sum = 0;
        for (int i = 0; i <= number; i++) //К сожалению, я не додумался до цикла for, вместо него используя while.
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }//Весь блок for сделан с помощью чата.
        Console.WriteLine($"Сумма: {sum}");
    }
}