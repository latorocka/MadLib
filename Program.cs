using System;
using System.Collections.Generic;

namespace MadLib
{
    class Program
    {

        static void Main(string[] args)
        {
            string noun;
            string place;
            string adverb;
            string verb;
            string adjective;
            string properNoun;

            string movieQuote;
            string answer = " ";


            Console.WriteLine("enter a Noun:\n");
            noun = Console.ReadLine();
            Console.WriteLine(" \n");
            Console.WriteLine("enter a Place:\n");
            place = Console.ReadLine();
            Console.WriteLine(" \n");
            Console.WriteLine("enter an Adverb:\n");
            adverb = Console.ReadLine();
            Console.WriteLine(" \n");
            Console.WriteLine("enter a Verb:\n");
            verb = Console.ReadLine();
            Console.WriteLine(" \n");
            Console.WriteLine("enter an Adjective:\n");
            adjective = Console.ReadLine();
            Console.WriteLine(" \n");
            Console.WriteLine("enter a Persons Name:\n");
            properNoun = Console.ReadLine();
            Console.WriteLine(" \n");

            var list = new List<string>
            { 
                $"May the {noun} be with you. -Star Wars, 1977", 
                $"There's no place like {place}. -The Wizard of Oz, 1939",
                $"It's {adverb}! It's {adverb}! -Frankenstein, 1931",
                $"My mama always said life was like a box of {noun}s. You never know what you're gonna get. -Forrest Gump, 1994",
                $"There's no {verb}ing in baseball! -A League of Their Own, 1992",
                $"A martini. Shaken, not {verb}ed. -Goldfinger, 1964",
                $"Magic Mirror on the wall, who is the {adjective}est one of all? -Snow White and the Seven Dwarfs, 1937",
                $"{noun}s? Where we're going we don't need {noun}. -Back to the Future, 1985",
                $"You're gonna need a bigger {noun}. -Jaws, 1975",
                $"Elementary, my dear {properNoun}. -The Adventures of Sherlock Holmes, 1939",
                $"Here's looking at you, {properNoun}. -Casablanca, 1942",
                $"If you {verb} it, he will come. -Field of Dreams, 1989",
                $"Hasta la vista, {noun}. -Terminator 2: Judgment Day, 1991",
            };

            Random rnd = new Random();
            movieQuote = list[rnd.Next(0, list.Count)];
            Console.WriteLine(movieQuote);

           
            
            Console.WriteLine("\n");
            Console.WriteLine("Would you like another quote?");
            Console.WriteLine("(yes or no?)");
            answer = Console.ReadLine();
            Console.WriteLine("\n");
            
            

            while (answer == "yes" || answer == "y")
            {
                movieQuote = list[rnd.Next(0, list.Count)];
                Console.WriteLine(movieQuote);
                Console.WriteLine("\n");
                Console.WriteLine("Would you like another quote?");
                Console.WriteLine("(yes or no?)");
                answer = Console.ReadLine();
                Console.WriteLine("\n");
            }
            
        }
    }
}
