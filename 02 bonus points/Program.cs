namespace _02_bonus_points
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int initialNumber = int.Parse(Console.ReadLine());


            double bonusPoints = 0;
           
            if (initialNumber<= 100)
            {
                bonusPoints += 5;
            }
            else if (initialNumber < 1000)
            {
                bonusPoints = initialNumber * 0.2;
            }
            else
            {
                bonusPoints = initialNumber * 0.1;
            }

            if (initialNumber % 2 == 0)
            {
                bonusPoints++;
            }
            if (initialNumber % 10 == 5)
            {
                bonusPoints += 2;
            }

            double finalNumber = initialNumber + bonusPoints;
            Console.WriteLine(bonusPoints);
            Console.WriteLine(finalNumber);

        }
    }
}