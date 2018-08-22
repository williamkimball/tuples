using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            (string product, double amount, int quantity) hammer = ("Hammer", 19.99, 25);
            (string product, double amount, int quantity) nailGun = ("NailGun", 140.56, 1);
            (string product, double amount, int quantity) nails = ("Nails", 10.99, 5);
            (string product, double amount, int quantity) staples = ("Staples", 4.00, 50);
            (string product, double amount, int quantity) bandaid = ("Bandaid", 4.99, 179);

            transactions.Add(hammer);
            transactions.Add(nailGun);
            transactions.Add(nails);
            transactions.Add(staples);
            transactions.Add(bandaid);

            int TotalProductsSold = 0;
            double TotalRevenue = 0;
            foreach ((string product, double amount, int quantity) t in transactions)
            {
                TotalProductsSold += t.quantity;
                TotalRevenue += t.quantity * t.amount;
            }

            Console.WriteLine($"We sold {TotalProductsSold} products for a total revenue of {TotalRevenue}");
        }
    }
}
