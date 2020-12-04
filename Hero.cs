namespace TerminalRPG
{
    using System;
    abstract class Hero
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Lvl { get; set; }
        public int Strength { get; set; }
        public int Wisdom { get; set; }
        public string Weapon { get; set; }
        public Hero(string name)
        {
            Name = name;
            Hp = 50;
            Lvl = 1;
            Strength = 3;
            Wisdom = 3;
        }
        public static void Attack(Hero player, Villian target)
        {
            int amt = 0;
            if (player.GetType().Name == "Wizard")
            {
                amt = player.Lvl * player.Wisdom;

            }
            if (player.GetType().Name == "Warrior")
            {
                amt = player.Lvl * player.Strength;

            }
            target.Hp -= amt;
            Console.WriteLine($"{player.Name} uses {player.Weapon} on {target.Name} for {amt} damage.");
            if (target.Hp <= 0)
            { target.Kill(); }
        }
    }
}