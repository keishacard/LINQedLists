﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQed_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
                                          where fruit.StartsWith("L")
                                          select fruit;

            foreach (string fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> Mults = numbers.Where(x => x % 4 == 0 || x % 6 == 0);

            foreach (int number in Mults)
            {
                Console.WriteLine(number);
            }

            //Ordering Operations
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> OrderNames = names.OrderByDescending(name => name).ToList();

            // foreach (string name in OrderNames)
            // {
            //     Console.WriteLine(name);
            // }

            // Build a collection of these numbers sorted in ascending order (uses number list on line 20)
            List<int> UpNums = numbers.OrderBy(name => name).ToList();

            //Aggregate Operations
            // Output how many numbers are in this list (uses number list on line 20)
            var HowMany = numbers.Count();
            Console.WriteLine($"{HowMany}");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            var AlltheDollars = purchases.Sum();
            Console.WriteLine($"{AlltheDollars}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            var MostExpens = prices.Max();
            Console.WriteLine($"{MostExpens}");

            //Partitioning Operations

            //Store each number in the following List until a perfect square is detected.
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            List<int> perfectSquare = wheresSquaredo.TakeWhile(number => Math.Sqrt(number) % 1 != 0).ToList();



        }
    }
}
