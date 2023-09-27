namespace _04_toy_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double puzzle = 2.6;
            const int talkingDoll = 3;
            const double teddyBear = 4.1;
            const double minion = 8.2;
            const int truck = 2;

            decimal vacationPrice = decimal.Parse(Console.ReadLine());
            int puzzleOrder = int.Parse(Console.ReadLine());
            int talkingDollOrder = int.Parse(Console.ReadLine());
            int teddyBearOrder = int.Parse(Console.ReadLine());
            int minionOrder = int.Parse(Console.ReadLine());
            int truckOrder = int.Parse(Console.ReadLine());

            decimal puzzles = (decimal)(puzzle * puzzleOrder);
            decimal dolls = (decimal)(talkingDoll * talkingDollOrder);
            decimal teddyBears = (decimal)(teddyBear * teddyBearOrder);
            decimal minions = (decimal)(minion * minionOrder);
            decimal trucks = (decimal)(truck * truckOrder);
            decimal sum = puzzles + dolls + teddyBears + minions + trucks;
            int toysOrded = puzzleOrder + talkingDollOrder+ teddyBearOrder + minionOrder + truckOrder;
            if (toysOrded >= 50)
            {
                sum *= 0.75m;
            }
            decimal rent = sum * 0.1m;
            sum -= rent;

            if (sum >= vacationPrice)
            {
                decimal moneyLeft = sum - vacationPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                decimal needeMoney = vacationPrice - sum;
                Console.WriteLine($"Not enough money! {needeMoney:f2} lv needed.");
            }
        }
    }
}