//input
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
string action = Console.ReadLine();
int result = 0;
double division = 0;
string isEven = string.Empty;
switch (action)
{
	case "+":
        result = firstNumber + secondNumber;
        isEven = evenOrUneven(result);
       
		break;
    case "-":
        result = firstNumber - secondNumber;
        isEven = evenOrUneven(result);
        break;
    case "*":
        result = firstNumber * secondNumber;
        isEven = evenOrUneven(result);
        break;
    case "/":

        if (secondNumber == 0)
        {
            Console.WriteLine($"Cannot divide {firstNumber} by zero"); 
            break;
        }

        division = (double)firstNumber / (double)secondNumber;
        break;
    case "%":
        if (secondNumber == 0)
        {
            Console.WriteLine($"Cannot divide {firstNumber} by zero");
            break;
        }
      
        result = firstNumber % secondNumber;
        break;
  
        default:
        Console.WriteLine("error");
        break;
}

//output
if (action == "+")
{
    Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - {isEven}");
}
else if (action == "-")
{
    Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - {isEven}");
}
else if (action == "*")
{
    Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - {isEven}");
}
else if (action == "/")
{
    if (secondNumber != 0)
    {
        Console.WriteLine($"{firstNumber} / {secondNumber} = {division:f2}");
    }
}
else if (action == "%")
{
     if (secondNumber != 0)
    {
        Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
    }
}

//static string devinebyzero(int firstnumber, int secondnumber)
//{
//    bool devine = false;
//    if (secondnumber == 0)
//    {
//        devine = true;
//        return $"cannot divide {firstnumber} by zero";
//    }

//}
static string evenOrUneven(int result)
{
    string isItEven = "";
    if (result % 2 == 1)
    {
         isItEven = "odd";
    }
    else
    {
        isItEven = "even";
    }
    return isItEven;
}