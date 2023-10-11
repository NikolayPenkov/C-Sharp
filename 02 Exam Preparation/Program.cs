

int unwantedGrates = int.Parse(Console.ReadLine());
string examName = Console.ReadLine();
int counter = 0;
int counterBadGrades = 0;
int sum = 0;
string lastProblem = string.Empty;
while (examName !="Enough")
{
    int grade = int.Parse(Console.ReadLine());
    if (grade < 5)
    {
        counterBadGrades++;
        if (counterBadGrades == unwantedGrates)
        {
            break;
        }
    }
    counter++;
    sum += grade;
    lastProblem = examName;
    examName= Console.ReadLine();
}
double averageGrade = (double)sum / counter;

if (examName == "Enough")
{
    Console.WriteLine($"Average score: {averageGrade:f2}");
    Console.WriteLine($"Number of problems: {counter}");
    Console.WriteLine($"Last problem: {lastProblem}");
}
else
{
    Console.WriteLine($"You need a break, {counterBadGrades} poor grades.");
}