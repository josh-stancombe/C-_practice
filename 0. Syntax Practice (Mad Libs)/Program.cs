using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /* 
      Title: Mad Libs project. 
      Description: Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech. The end result is a really hilarious and strange story. 
      */

      // Let the user know that the program is starting:
      Console.WriteLine("\nWelcome to the Mad Libs story generator!");

      string title = "An Average Tuesday.";
      Console.WriteLine("Story: " + title + "\n");

      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      Console.Write("Enter adjective #1: ");
      string adj1 = Console.ReadLine();

      Console.Write("Enter adjective #2: ");
      string adj2 = Console.ReadLine();

      Console.Write("Enter adjective #3: ");
      string adj3 = Console.ReadLine();

      Console.Write("Enter a verb: ");
      string verb = Console.ReadLine();

      Console.Write("Enter noun #1: ");
      string noun1 = Console.ReadLine();

      Console.Write("Enter noun #2: ");
      string noun2 = Console.ReadLine();

      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine();

      Console.Write("Enter a food: ");
      string food = Console.ReadLine();
      
      Console.Write("Enter a fruit: ");
      string fruit = Console.ReadLine();

      Console.Write("Enter a superhero: ");
      string superhero = Console.ReadLine();

      Console.Write("Enter a country: ");
      string country = Console.ReadLine();

      Console.Write("Enter a dessert: ");
      string dessert = Console.ReadLine();

      Console.Write("Enter a year: ");
      string year = Console.ReadLine();


      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine("\nYour MadLibs story is: \n" + story);
    }
  }
}
