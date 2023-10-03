const int pointsForWinning = 2000;
const int pointsForFinal = 1200;
const int pointsSemiFinal = 720;
 
int numberOfTournaments = int.Parse(Console.ReadLine());
int startingPoints = int.Parse(Console.ReadLine());
int totalPoints = startingPoints;
double numberOfWonTournaments = 0;
for (int i = 0; i < numberOfTournaments; i++)
{
    string reachedTournamentStage = Console.ReadLine().ToLower();
    if (reachedTournamentStage == "w")
    {
        totalPoints += pointsForWinning;
        numberOfWonTournaments++;
    }
    else if (reachedTournamentStage == "sf")
    {
        totalPoints += pointsSemiFinal;
    }
    else if (reachedTournamentStage == "f")
    {
        totalPoints += pointsForFinal;
    }
}
int averagePointsFromTournament = (totalPoints - startingPoints) / numberOfTournaments;
double winTournamentsRate = (numberOfWonTournaments /numberOfTournaments)  * 100 ;


Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {averagePointsFromTournament}");
Console.WriteLine($"{winTournamentsRate:f2}%");
  
