using System.Drawing;

Console.WriteLine("###################Welcome to the Mobile Top-Up Application!########################");
Console.WriteLine("Please enter your Name :");
string? name = Console.ReadLine();
Console.WriteLine("Please choose your Mobile Network :");
Console.WriteLine("1. Safaricom");
Console.WriteLine("2. Ethiotel");
string network = Console.ReadLine();
if (network != "1" && network != "2")
{
    Console.WriteLine("Invalid network selected. Please choose either 1 or 2.");
    return;
}
else
{
    network = network == "1" ? "Safaricom" : "Ethiotel";
}
//Console.WriteLine("Hello, " + name + "! You are on " + network + ".");
Console.WriteLine("Please enter the amount you want to top up :");

decimal amount = decimal.TryParse(Console.ReadLine(), out decimal result) ? result : 0m;
 switch (network.ToLower())
{
    case "safaricom":
        if (amount > 0 && amount <= 5000)
        {
            decimal bonus = amount <= 1000 ? amount * 0.03m : amount * 0.05m + 20;
            Console.WriteLine($"You have successfully topped up {amount:C} to your {network} account.");
            Console.WriteLine($"You have received a bonus of {bonus:C}. Your current balance is {(amount + bonus):C}.");
            Console.WriteLine("Thank you for using the Mobile Top-Up Application!");
        }
        else
        {
            Console.WriteLine("Invalid amount entered. Please enter an amount between 0 and 5000.");
        }
        break;

    case "ethiotel":
        if (amount > 0 && amount <= 5000)
        {
            decimal bonus = amount <= 1000 ? amount * 0.05m : amount * 0.07m + 20;
            Console.WriteLine($"You have successfully topped up {amount:C} to your {network} account.");
            Console.WriteLine($"You have received a bonus of {bonus:C}. Your current balance is {(amount + bonus):C}.");
            Console.WriteLine("Thank you for using the Mobile Top-Up Application!");
        }
        else
        {
            Console.WriteLine("Invalid amount entered. Please enter an amount between 0 and 5000.");
        }
        break;

    default:
        Console.WriteLine("Invalid network selected.");
        break;
}

// if (amount > 0 && amount <= 5000)
// {
//     if (amount <= 1000)
//     {

//         if (network.ToLower() == "safaricom")
//         {
//             decimal bonus = amount * 0.03m;
//             Console.WriteLine("You have successfully topped up " + amount.ToString("C") + " to your " + network + " account.");
//             Console.WriteLine("You have received a bonus of " + bonus.ToString("C") + ". Your current balance is " + (amount + bonus).ToString("C") + ".");
//             Console.WriteLine("Thank you for using the Mobile Top-Up Application!");
//         }
//         else if (network.ToLower() == "ethiotel")
//         {
//             decimal bonus = amount * 0.05m;
//             Console.WriteLine("You have successfully topped up " + amount.ToString("C") + " to your " + network + " account.");
//             Console.WriteLine("You have received a bonus of " + bonus.ToString("C") + ". Your current balance is " + (amount + bonus).ToString("C") + ".");
//             Console.WriteLine("Thank you for using the Mobile Top-Up Application!");
//         }
//     }
//     else if (amount > 1000 && amount <= 5000)
//     {
//         if (network.ToLower() == "safaricom")
//         {
//             decimal bonus = amount * 0.05m + 20; ;
//             Console.WriteLine("You have successfully topped up " + amount.ToString("C") + " to your " + network + " account. and you get additional 20 bonus");
//             Console.WriteLine("You have received a bonus of " + bonus.ToString("C") + ". Your current balance is " + (amount + bonus).ToString("C") + ".");
//             Console.WriteLine("Thank you for using the Mobile Top-Up Application!");
//         }
//         else if (network.ToLower() == "ethiotel")
//         {
//             decimal bonus = amount * 0.07m + 20;
//             Console.WriteLine("You have successfully topped up " + amount.ToString("C") + " to your " + network + " account. and you get additional 20 bonus");
//             Console.WriteLine("You have received a bonus of " + bonus.ToString("C") + ". Your current balance is " + (amount + bonus).ToString("C") + ".");
//             Console.WriteLine("Thank you for using the Mobile Top-Up Application!");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Invalid amount entered. Please enter an amount between 0 and 5000.");
//     }


