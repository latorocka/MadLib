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

            string movieQuote;
            string answer;


            Console.WriteLine("enter a noun:\n");
            noun = Console.ReadLine();
            Console.WriteLine(" \n");
            Console.WriteLine("enter a place:\n");
            place = Console.ReadLine();
            Console.WriteLine(" \n");
            Console.WriteLine("enter an adverb:\n");
            adverb = Console.ReadLine();
            Console.WriteLine(" \n");
            Console.WriteLine("enter a verb in the past tense:\n");
            verb = Console.ReadLine();
            Console.WriteLine(" \n");
            Console.WriteLine("enter an adjective:\n");
            adjective = Console.ReadLine();
            Console.WriteLine(" \n");

            var list = new List<string>
            { 
                $"May the {noun} be with you. -Star Wars, 1977", 
                $"There's no place like {place}. -The Wizard of Oz, 1939",
                $"It's {adverb}! It's {adverb}! -Frankenstein, 1931",
                $"My mama always said life was like a box of {noun}s. You never know what you're gonna get. -Forrest Gump, 1994",
                $"There's no {adverb} in baseball! -A League of Their Own, 1992",
                $"A martini. Shaken, not {verb}. -Goldfinger, 1964",
                $"Magic Mirror on the wall, who is the {adjective}est one of all? -Snow White and the Seven Dwarfs, 1937",
                $"{noun}s? Where we're going we don't need {noun}. -Back to the Future, 1985",
            };

            Random rnd = new Random();
            movieQuote = list[rnd.Next(0, list.Count)];
            
            
            Console.WriteLine(movieQuote);
            Console.WriteLine("\n");
            Console.WriteLine("another quote?");
            answer = Console.ReadLine();
            Console.WriteLine("\n");

            if (answer == "yes")
            {
                movieQuote = list[rnd.Next(0, list.Count)];
                Console.WriteLine(movieQuote);
            }
            
        }
    }
}
