using System;

public class Course4
{
    public static void Module20()
    {
        
    }
    public static void Module19()
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        // Your work here
        const string openDiv = "<div>";
        const string closeDiv = "</div>";
        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int openSpanIndex = input.IndexOf(openSpan) + openSpan.Length;
        int closeSpanIndex = input.IndexOf(closeSpan);

        quantity = input.Substring(openSpanIndex, (closeSpanIndex - openSpanIndex));

        int openDivIndex = input.IndexOf(openDiv) + openDiv.Length;
        int closeDivIndex = input.IndexOf(closeDiv);

        output = input.Substring(openDivIndex, (closeDivIndex - openDivIndex));

        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Output: {output}");
    }
    public static void Module18()
    {
        string data = "12345John Smith          5000  3  ";
        string updatedData = data.Remove(5, 20);
        Console.WriteLine(updatedData);

        string message = "This--is--ex-amp-le--da-ta";
        message = message.Replace("--", " ");
        message = message.Replace("-", "");
        Console.WriteLine(message);
    }
    public static void Module17()
    {
        string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

        // The IndexOfAny() helper method requires a char array of characters. 
        // You want to look for:

        char[] openSymbols = { '[', '{', '(' };

        // You'll use a slightly different technique for iterating through 
        // the characters in the string. This time, use the closing 
        // position of the previous iteration as the starting index for the 
        //next open symbol. So, you need to initialize the closingPosition 
        // variable to zero:

        int closingPosition = 0;

        while (true)
        {
            int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

            if (openingPosition == -1) break;

            string currentSymbol = message.Substring(openingPosition, 1);

            // Now  find the matching closing symbol
            char matchingSymbol = ' ';

            switch (currentSymbol)
            {
                case "[":
                    matchingSymbol = ']';
                    break;
                case "{":
                    matchingSymbol = '}';
                    break;
                case "(":
                    matchingSymbol = ')';
                    break;
            }

            // To find the closingPosition, use an overload of the IndexOf method to specify 
            // that the search for the matchingSymbol should start at the openingPosition in the string. 

            openingPosition += 1;
            closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            // Finally, use the techniques you've already learned to display the sub-string:

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
    public static void Module16()
    {
        string message = "Help (find) the {opening symbols}";
        Console.WriteLine($"Searching THIS Message: {message}");
        char[] openSymbols = { '[', '{', '(' };
        int startPosition = 6;
        int openingPosition = message.IndexOfAny(openSymbols);
        Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

        openingPosition = message.IndexOfAny(openSymbols, startPosition);
        Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}");
    }
    public static void Module15()
    {
        string message = "(What if) there are (more than) one (set of parentheses)?";
        while (true)
        {
            int openingPosition = message.IndexOf('(');
            if (openingPosition == -1) break;

            openingPosition += 1;
            int closingPosition = message.IndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            // Note the overload of the Substring to return only the remaining 
            // unprocessed message:
            message = message.Substring(closingPosition + 1);
        }
    }

    public static void Module14()
    {
        string message = "(What if) I am (only interested) in the last (set of parentheses)?";
        int openingPosition = message.LastIndexOf('(');

        openingPosition += 1;
        int closingPosition = message.LastIndexOf(')');
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }
    public static void Module13()
    {
        string message = "Find what is (inside the parentheses)";

        int openingPosition = message.IndexOf('(');
        int closingPosition = message.IndexOf(')');

        openingPosition += 1;

        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));



        string message2 = "What is the value <span>between the tags</span>?";

        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int openingPosition2 = message2.IndexOf(openSpan);
        int closingPosition2 = message2.IndexOf(closeSpan);

        openingPosition2 += openSpan.Length;
        int length2 = closingPosition2 - openingPosition2;
        Console.WriteLine(message2.Substring(openingPosition2, length2));
    }
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