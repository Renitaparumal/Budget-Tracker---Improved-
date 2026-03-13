using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Personal Budget Tracker!");

        // Ask user for monthly budget
        Console.Write("Enter your monthly budget: ");
        double budget = Convert.ToDouble(Console.ReadLine());

        // Variables to store total expenses
        double totalExpenses = 0;

        // Array of expense types
        string[] expenseTypes = { "Rent", "Food", "Transport", "Utilities" };

        // Loop to get multiple expenses from the user
        for (int i = 0; i < expenseTypes.Length; i++)
        {
            Console.Write($"Enter {expenseTypes[i]} expense: ");
            double expense = Convert.ToDouble(Console.ReadLine());
            totalExpenses += expense;
        }

        // Call function to calculate remaining budget
        double remaining = CalculateRemainingBudget(budget, totalExpenses);

        // Display results
        Console.WriteLine("\n--- Budget Summary ---");
        Console.WriteLine("Total Expenses: " + totalExpenses);
        Console.WriteLine("Remaining Budget: " + remaining);

        // Conditional messages
        if (remaining < 0)
        {
            Console.WriteLine("Warning: You are over budget!");
        }
        else if (remaining == 0)
        {
            Console.WriteLine("You have used up your budget exactly!");
        }
        else
        {
            Console.WriteLine("Good job! You are within your budget.");
        }

        // Keep console open
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }

    // Function to calculate remaining budget
    static double CalculateRemainingBudget(double budget, double totalExpenses)
    {
        return budget - totalExpenses;
    }
}
