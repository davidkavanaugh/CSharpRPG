using System;
using System.Collections.Generic;
namespace TerminalRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // create villians list
            VillianList villians = new VillianList();
            Villian spider = new Villian("Spider");
            Villian snake = new Villian("Snake");
            Villian dragon = new Villian("Dragon");
            villians.Add(dragon);
            villians.Add(spider);
            villians.Add(snake);

            // create heros
            Console.WriteLine("TERMINAL RPG");
            Console.WriteLine("Player 1 (Warrior) please enter your name");
            string player1Name = Console.ReadLine();
            Warrior player1 = new Warrior(player1Name);
            Console.WriteLine("Player 2 (Wizard) please enter your name");
            string player2Name = Console.ReadLine();
            Wizard player2 = new Wizard(player2Name);

            // game loop
            int loops = 1;
            while (VillianList.Count > 0)
            {
                Console.WriteLine($"{VillianList.Count} enemies remaining");
                List<Villian> enemiesList = VillianList.GetAll();
                if (loops % 2 != 0)
                {
                    // player1 turn
                    Console.WriteLine($"{player1.Name}, select a target");
                    int count = 1;
                    foreach (Villian enemy in enemiesList)
                    {
                        Console.WriteLine($"{count}.) {enemy.Name} -- {enemy.Hp}HP");
                        count++;
                    }
                    string target = Console.ReadLine();
                    player1.Attack(enemiesList[Int32.Parse(target) - 1]);
                    loops++;
                }
                else
                {
                    // player2 turn
                    Console.WriteLine($"{player2.Name}, select a target");
                    int count = 1;
                    foreach (Villian enemy in enemiesList)
                    {
                        Console.WriteLine($"{count}.) {enemy.Name} -- {enemy.Hp}HP");
                        count++;
                    }
                    string target = Console.ReadLine();
                    player2.Attack(enemiesList[Int32.Parse(target) - 1]);
                    loops++;
                }
            }
            Console.WriteLine("Victory!");
        }
    }
}
