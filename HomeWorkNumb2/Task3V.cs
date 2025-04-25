namespace HomeWorkNumb2;

internal class Task3X
{
    public void Execute()
    {
            int[] Numbers = {5, 12, 19, 26, 33, 40, 47, 54, 61, 68, 75, 82, 89, 96};
            foreach (int number in Numbers) // Делает пересчет чисел из массива по порядку.
                /* "... пояснить выбор вашего цикла,
                 чтобы она выводила следующую 
                 последовательность - 5 12 19 
                 26 33 40 47 54 61 68 75 82 
                 89 96" */
            {
                Console.WriteLine($"Числа: {number}");
            }
    }
}