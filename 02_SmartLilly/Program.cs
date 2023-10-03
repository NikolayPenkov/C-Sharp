
int age = int.Parse(Console.ReadLine());
double priceWashingMashine = double.Parse(Console.ReadLine());
int priceDoll = int.Parse(Console.ReadLine());
int evenBirthdays = 0;
int oddBirthdays = 0;
int moneyFromBirthdays = 0;
int startMoneyBirthday = 10;
for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        evenBirthdays++;
        int newMoneyFromBirthday = startMoneyBirthday * evenBirthdays;
        moneyFromBirthdays += newMoneyFromBirthday;
    }
    else 
    {
        oddBirthdays++; 
    }
}
int moneyGiftedToTheLittleBrother = evenBirthdays;
int moneyFromSoldDolls = oddBirthdays * priceDoll;
int savedMoney = moneyFromBirthdays + moneyFromSoldDolls - moneyGiftedToTheLittleBrother;

if (savedMoney >= priceWashingMashine)
{
    double moneyLeft = (double)savedMoney - priceWashingMashine;
    Console.WriteLine($"Yes! {moneyLeft:f2}");
}
else
{
    double insuficientMoney = priceWashingMashine - savedMoney;
    Console.WriteLine($"No! {insuficientMoney:f2}");
}

