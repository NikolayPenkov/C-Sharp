namespace _01_sum_seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeFirstRunner = int.Parse(Console.ReadLine());
            int timeSecondRunner = int.Parse(Console.ReadLine());
            int timeThirdRunner = int.Parse(Console.ReadLine());

            int timeSum = timeFirstRunner + timeSecondRunner + timeThirdRunner;
            int minutes = timeSum / 60;
            int seconds = timeSum % 60;

            if (seconds< 9)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else 
            { 
                Console.WriteLine($"{minutes}:{seconds}");
            }


        }
    }
}