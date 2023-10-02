

const double premiereTicket = 12.00;
const double standardTicket = 7.50;
const double discountedTicket = 5.00;

string typeOfTicket = Console.ReadLine().ToLower();
decimal ticketPrice = 0;
switch (typeOfTicket)
{
	case "premiere":
		ticketPrice = (decimal)premiereTicket;
		break;
	case "normal":
		ticketPrice = (decimal)standardTicket;
		break;
	case "discount":
		ticketPrice = (decimal)discountedTicket;
		break;

    default:
        Console.WriteLine("error"); 
		break;
}
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());
int totalUsedSeats = rows * cols;
decimal income = ticketPrice * totalUsedSeats;

Console.WriteLine($"{income:f2} leva");
