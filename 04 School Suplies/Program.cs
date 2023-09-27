

const double pen = 5.80;
const double markers = 7.20;
const double cleaningSupply = 1.20;

int numberOfPens = int.Parse(Console.ReadLine());
int numberOfMarkers = int.Parse(Console.ReadLine());
int numberOfCleaningSuplies = int.Parse(Console.ReadLine());
double discount = double.Parse(Console.ReadLine()) /100;

decimal sumOfPens = (decimal)(pen * numberOfPens);
decimal sumOfMarkers = (decimal)(markers * numberOfMarkers);
decimal sumOfCleaningSuplies = (decimal)(cleaningSupply * numberOfCleaningSuplies);

decimal sumBeforeDiscount = sumOfPens + sumOfMarkers + sumOfCleaningSuplies;

decimal finalSum = sumBeforeDiscount - (sumBeforeDiscount * (decimal)discount);

Console.WriteLine(finalSum);

