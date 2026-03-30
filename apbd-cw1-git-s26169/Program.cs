Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

try
{
    int number = int.Parse(input);
    int result = StatisticsHelper.Square(number);

    Console.WriteLine($"Square: {result}");
}
catch
{
    Console.WriteLine("Invalid input!");
}