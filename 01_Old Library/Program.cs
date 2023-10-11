string command = string.Empty;
string wantedBook = Console.ReadLine();
int counter = 0;
while (command != "No More Books" && command != wantedBook)
{

    counter++;
    command = Console.ReadLine();
}
        if (command != wantedBook)
        {
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {counter} books.");
        }
        else
        {
            Console.WriteLine($"You checked {counter} books and found it.");
        }
