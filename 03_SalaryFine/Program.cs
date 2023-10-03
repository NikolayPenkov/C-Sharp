const int facebookFine = 150;
const int instagramFine = 100;
const int redditFine = 50;

int openTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

for (int i = 1; i <= openTabs; i++)
{
    string tabName = Console.ReadLine().ToLower();
    if (tabName == "facebook")   
    {
        salary -= facebookFine;
    }
    else if (tabName == "instagram")
    {
        salary -= instagramFine;
    }
    else if (tabName == "reddit")
    {
        salary -= redditFine;
    }
    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }
}

      if (salary > 0)
      {
        Console.WriteLine(salary);
      }


