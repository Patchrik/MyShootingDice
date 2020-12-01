using System;
using System.Collections.Generic;
namespace ShootingDice
{
  // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
  public class CreativeSmackTalkingPlayer : Player
  {
    static List<string> Taunts = new List<string>
    {
    "Watch this scrub",
    "Are you going to cry when you lose?",
    "So does your dad know you're this bad?",
    "Hope you can count this high."
    };
    string randomTaunt = Taunts[new Random().Next(0, Taunts.Count)];

    public override int Roll()
    {
      Console.WriteLine($"{randomTaunt} - {this.Name}");
      return base.Roll();
    }



  }
}