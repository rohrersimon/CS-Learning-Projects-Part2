using System;

public class Course4
{
    public static void Module12()
    {
        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        // Your logic here
        Console.WriteLine($"Dear {customerName},");
        Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");

        Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
        Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C2}.\n");

        Console.WriteLine("Here's a quick comparison:\n");

        string comparisonMessage = "";

        // Your logic here
        comparisonMessage += $"{currentProduct}\t\t{currentReturn:P2}\t{currentProfit:C2}\n";
        comparisonMessage += $"{newProduct}\t\t{newReturn:P2}\t{newProfit:C2}\n";

        Console.WriteLine(comparisonMessage);
    }
    public static void Module11()
    {
        string input = "Pad this";
        Console.WriteLine(input.PadLeft(12));
        Console.WriteLine(input.PadLeft(12, '-'));
        Console.WriteLine(input.PadRight(12, '-'));
    }
    public static void Module10()
    {
        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine($"   Shares: {productShares:N3} Product");
        Console.WriteLine($"     Sub Total: {subtotal:C}");
        Console.WriteLine($"           Tax: {taxPercentage:P2}");
        Console.WriteLine($"     Total Billed: {total:C}");
    }
}