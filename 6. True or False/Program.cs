/*
True or False?

You’re taking an interactive quiz written in C#. Everything is going fine until you respond to this question:

> "Eggplants are berries... True or False?"
> yes
> "You got 0 out of 5 correct."

This application wasn’t checking your input. When you used an unexpected format, it couldn’t ask the question again and marked your answer as wrong. (By botanical definition, eggplants really are berries!).

In this project, you’ll build a C# program that presents a quiz the right way: using arrays and loops, it will check the format of user input and repeat the question if the format is incorrect. After the quiz is complete, it will check the user’s responses against the correct answers and present a score.
*/

using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      Console.Write("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      string[] questions = {"Sydney is the capital of Australia", "Prince Harry is taller than Prince William", "M&M stands for Mars and Moordale", "Gin is typically included in a Long Island Iced Tea", "'A' is the most common letter used in the English language"};

      bool[] answers = {false, false, false, true, false};

      bool[] responses = new bool[5];

      if (questions.Length != answers.Length){
        Console.WriteLine("Error! - The questions and answers array are not the same size!");
      }

      int askingIndex = 0;

      foreach (string question in questions){
        string input;
        bool isBool;
        bool inputBool;

        Console.WriteLine(question + " ... True or False?");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);

        while(!isBool){
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }

        responses[askingIndex] = inputBool;
        askingIndex += 1;
      }

      int scoringIndex = 0;
      int score = 0;

      foreach(bool answer in answers){
        bool response = responses[scoringIndex];
        Console.WriteLine($"{scoringIndex}, Input: {response} | Answer: {answer}");

        if(response == answer){
          score+=1;
        }

        scoringIndex+=1;
      }

      Console.WriteLine($"You got {score} out of 5 correct!");
      
    }
  }
}
