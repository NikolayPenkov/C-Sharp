double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

foreach (double number in numbers)
{
    double oldNumber = number;
    var newNumber = Math.Round(oldNumber, MidpointRounding.AwayFromZero);
    Console.WriteLine($"{oldNumber} => {newNumber}");
}