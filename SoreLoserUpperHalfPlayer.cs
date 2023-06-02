using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = new Random().Next(3, 7);
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            try
            {
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                else if (myRoll < otherRoll)
                {
                    throw new Exception($"{Name} can't handle losing!"); // Throw a custom exception
                }
                else
                {
                    Console.WriteLine("It's a tie");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Exception caught: {Name} shouldn't spoil it for everyone.");
            }
        }
    }
}