using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "PREPARE TO BE FOILED LIKE A HOT POTATO.";
        public override int Roll()
        {
            //shout a taunt every roll
            Console.WriteLine($"{Name} says: {Taunt}");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }

}