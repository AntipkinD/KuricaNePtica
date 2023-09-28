internal class Program
{
    static void Chicken()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Курица");
        }
    }
    private static void Main(string[] args)
    {

        Thread chick = new(Chicken);
        chick.Priority = ThreadPriority.Highest;
        chick.Start();
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Яйцо");
        }
        Winner(chick);
        static void Winner (Thread chicken)
        {
            Console.WriteLine(chicken.IsAlive ? "Конец. Победа курицы" : "Конец. Победа яйца");
        }
    }
}