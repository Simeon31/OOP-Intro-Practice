using System;

namespace Royal_Gambit
{
    class Program
    {
        static void Main(string[] args)
        {
            King king = new();
            // Footman footman = new();
            //  RoyalGuard royalGuard = new();

            king.KingsEvent += new KingUnderAttack(King_KingsEvent);
            // king.KingsSecurity(king);

            //  footman.FootmansEvent +=  new FootmanUnderAttack(Footman_FootmansEvent);
            // footman.FootmansSecurity(footman);

            // royalGuard.RoyalGuardsEvent +=  new RoyalGuardUnderAttack(RoyalGuard_RoyalGuardsEvent);
            // royalGuard.RoyalGuardsSecurity(royalGuard);

            try
            {

                string input = String.Empty;
                Console.Write("Enter king's name: ");
                while (!"End".Equals(input = Console.ReadLine()))
                {
                    if ("Attack King".Equals(input))
                    {
                        Console.WriteLine("The king is being attacked!");
                        continue;
                    }
                    else if (input.StartsWith("Kill"))
                    {

                        Console.WriteLine(input.Substring(5) + " is ordered to be killed.");
                    }
                    else
                    {
                        king.Name = input;
                        king.KingsSecurity(king);

                        Console.Write("\nEnter guard's names: ");
                        string[] royalGuardNames = Console.ReadLine().Split();
                        foreach (string name in royalGuardNames)
                        {
                            RoyalGuard royalGuard = new() { Name = name };
                            royalGuard.RoyalGuardsEvent += new RoyalGuardAction(RoyalGuard_RoyalGuardsEvent);
                            royalGuard.RoyalGuardsAction(royalGuard);
                        }

                        Console.Write("\nEnter footman's names: ");
                        string[] footmanNames = Console.ReadLine().Split();
                        foreach (string name in footmanNames)
                        {
                            Footman footman = new() { Name = name };
                            footman.FootmansEvent += new FootmanReaction(Footman_FootmansEvent);
                            footman.FootmansReaction(footman);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void RoyalGuard_RoyalGuardsEvent(object sender, RoyalGuard e)
        {
            Console.WriteLine($"RoyalGuard {e.Name} is defending!");
        }

        private static void Footman_FootmansEvent(object sender, Footman e)
        {
            Console.WriteLine($"Footman {e.Name} is panicking!");
        }

        private static void King_KingsEvent(object sender, King e)
        {
            Console.WriteLine($"King {e.Name} is under attack!");
        }
    }
}
