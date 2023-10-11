int inputNumber = int.Parse(Console.ReadLine());

string[] dayOfWeek =
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

if (inputNumber > 0 && inputNumber <= 7)
{
    Console.WriteLine(dayOfWeek[inputNumber - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}