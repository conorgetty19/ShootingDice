using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }
        public override int Roll()
        {
            Dictionary<int, string> taunts = new Dictionary<int, string>()
            {
                {1, "I am dice"},
                {2, "You are not dice"},
                {3, "You will not beat me"}
            };
            int randomNumber = new Random().Next(1, 4);
            Taunt = taunts[randomNumber];
            //shout a taunt every roll
            Console.WriteLine($"{Name} says: {Taunt}");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }
}