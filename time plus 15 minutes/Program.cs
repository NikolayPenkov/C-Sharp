namespace time_plus_15_minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int hour = int.Parse(Console.ReadLine());
           int minutes = int.Parse(Console.ReadLine());

            if (hour >25 || minutes > 59)
            {
                throw new Exception("The time is not correct");
            }
           

            int minutesPlus15 = minutes + 15;
            if (minutesPlus15>= 60)
            {
                hour++;
                minutesPlus15 -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }

              Console.WriteLine($"{hour}:{minutesPlus15:d2}");
           
        }
    }
}