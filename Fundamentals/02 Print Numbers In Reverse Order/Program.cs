int n = int.Parse(Console.ReadLine());

int[] arrayOfNumbers = new int[n];
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    arrayOfNumbers[i] = number;
}
for (int j = arrayOfNumbers.Length - 1; j >= 0; j--)
{
    Console.Write($"{arrayOfNumbers[j]} ");
}