Console.WriteLine("Welcome to the Mobile Top-Up Application!");
Console.WriteLine("Please enter your Name :");
string name = Console.ReadLine();
Console.WriteLine("Please enter your Mobile Network :");
string network = Console.ReadLine();
Console.WriteLine("Hello, " + name + "! You are on " + network + ".");
Console.WriteLine("Please enter the amount you want to top up :");
decimal amount = decimal.TryParse(Console.ReadLine(), out decimal result) ? result : 0m;
if (amount <= 0)
{
    
}