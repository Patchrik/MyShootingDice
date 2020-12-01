using System;

namespace ShootingDice
{
  // TODO: Complete this class

  // A player the prompts the user to enter a number for a roll
  public class HumanPlayer : Player
  {
    public override int Roll()
    {
      while (true)
      {
        try
        {
          Console.WriteLine("Enter a number!");
          int humanRoll = int.Parse(Console.ReadLine());
          return humanRoll;
        }
        catch
        {
          Console.WriteLine("Please use a WHOLE NUMBER");
          continue;
        }
      }
    }

  }
}