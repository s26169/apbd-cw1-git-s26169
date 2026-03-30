Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

try
{
    int number = int.Parse(input);
    Console.WriteLine($"You entered: {number}");
}
catch
{
    Console.WriteLine("Invalid input!");
}