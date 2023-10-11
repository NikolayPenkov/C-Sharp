
double moneyNeededForVacation = double.Parse(Console.ReadLine());
double initialMoney = double.Parse(Console.ReadLine());
double savedMoney = initialMoney;
int spendMoneyCounter = 0;
int dayCounter = 0;
while (spendMoneyCounter != 5 && savedMoney < moneyNeededForVacation)
{
    string command = Console.ReadLine();
    double incommingMoney = double.Parse(Console.ReadLine());
    dayCounter++;
    if (command == "spend")
    {
        savedMoney -= incommingMoney;
        if (savedMoney < 0)
        {
            savedMoney = 0;
        }    
        spendMoneyCounter++;
    }
    else if (command == "save")
    {
        savedMoney += incommingMoney;
        spendMoneyCounter = 0;
    }
}
if (spendMoneyCounter == 5)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine($"{spendMoneyCounter}");
}

else
{
    Console.WriteLine($"You saved the money for {dayCounter} days.");
}

