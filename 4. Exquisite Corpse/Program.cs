/*
Exquisite Corpse

In the game Exquisite Corpse, participants draw either a head, body, or feet of a creature. 

For this project, you’ll write a program that mimics the Exquisite Corpse game. Using methods, you’ll be able to randomly combine different parts of ASCII characters so they create a new creature.

*/

using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args){
      Console.WriteLine("You are about to build your own creature!");
      Console.WriteLine("Type 'ghost', 'monster' or bug' at the prompt to select your creatures build...");

      Console.Write("Head: ");
      string head = Console.ReadLine();
      Validator(head);

      Console.Write("Body: ");
      string body = Console.ReadLine();
      Validator(body);

      Console.Write("Feet: ");
      string feet = Console.ReadLine();
      Validator(feet);


      BuildACreature(head, body, feet);
    }

    static void Validator(string UI){
      if (UI != "bug" && UI != "monster" && UI != "ghost") {
        Console.WriteLine("Sorry, you have provided an incorrect input type. Goodbye.");
        Environment.Exit(0);
      }
    }

    static void BuildACreature(string head, string body, string feet){
      switch(head){
        case "monster":
          MonsterHead();
          break;
        case "ghost":
          GhostHead();
          break;
        case "bug":
          BugHead();
          break;
      }

      switch(body){
        case "monster":
          MonsterBody();
          break;
        case "ghost":
          GhostBody();
          break;
        case "bug":
          BugBody();
          break;
      }

      switch(feet){
        case "monster":
          MonsterFeet();
          break;
        case "ghost":
          GhostFeet();
          break;
        case "bug":
          BugFeet();
          break;
      }

    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
