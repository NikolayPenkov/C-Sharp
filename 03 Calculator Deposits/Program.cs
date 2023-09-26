

decimal deposit = decimal.Parse(Console.ReadLine());
int timeDeposit = int.Parse(Console.ReadLine()); //the time for the deposit is calculated per months
decimal yearlyInterestRate = decimal.Parse(Console.ReadLine());


decimal interestRatePerMonth = deposit * yearlyInterestRate/100/12;
decimal interestForDeposit = interestRatePerMonth * timeDeposit;
//decimal sum = Math.Round(deposit + interestForDeposit, 2);
decimal sum = deposit + interestForDeposit;
Console.WriteLine($"{sum:F2} lv");


