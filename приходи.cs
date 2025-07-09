using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<decimal> amounts = new List<decimal>();
        string input;

        Console.WriteLine("Въвеждай суми (положителни за приходи, отрицателни за разходи).");
        Console.WriteLine("Напиши 'край' за отчет.");

        while (true)
        {
            Console.Write("Сума: ");
            input = Console.ReadLine();

            if (input.ToLower() == "край")
                break;

            if (decimal.TryParse(input, out decimal sum))
            {
                amounts.Add(sum);
            }
            else
            {
                Console.WriteLine("⚠️ Моля въведи валидна сума или 'край'.");
            }
        }

        decimal totalIncome = 0;
        decimal totalExpense = 0;

        foreach (var amount in amounts)
        {
            if (amount > 0) totalIncome += amount;
            else totalExpense += Math.Abs(amount);
        }

        Console.WriteLine("\n--- ОТЧЕТ ---");
        Console.WriteLine($"Общо приходи: {totalIncome} лв.");
        Console.WriteLine($"Общо разходи: {totalExpense} лв.");
        Console.WriteLine($"Баланс: {totalIncome - totalExpense} лв.");
    }
}
