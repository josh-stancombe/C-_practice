/*

-- Money Maker --

You have three types of coins:

    > A bronze coin is worth 1 cent
    > A silver coin is worth 5 cents
    > A gold coin is worth 10 cents

In this project you’ll use C# to build a Money Maker: a program in which a user enters an amount and gets the minimum number of coins that equal that value.

For example, 16 cents could be:

    16 bronze coins,
    3 silver coins and 1 bronze coin, or
    1 gold coin, 1 silver coin, 1 bronze coin

We’d like the last option because it uses the fewest coins.

This project will get you comfortable with division (/), rounding down (Math.Floor()), and modulo (%): You can find how many coins “fit” into an amount by dividing the amount by the coin value, rounding down, and finding the remainder.

URL: https://www.codecademy.com/courses/learn-c-sharp/projects/csharp-money-maker-live 

*/

using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert... ");
      
      string rawAmount = Console.ReadLine();
      double amount = Convert.ToDouble(rawAmount);

      Console.WriteLine($"\n{amount} cents is equal to...");
      
      int goldVal = 10;
      int silverVal = 5;

      // Gold
      double goldCoins = Math.Floor(amount / goldVal);
      double remaining = amount % goldVal;

      // Silver
      double silverCoins = Math.Floor(remaining / silverVal);
      remaining = remaining % silverVal;

      Console.WriteLine("Gold coins: " + goldCoins);
      Console.WriteLine("Silver coins: " + silverCoins);
      Console.WriteLine("Bronze coins: " + remaining);

    }
  }
}
