namespace TerminalRPG
{
    using System;
    abstract class Hero : IHero
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
        public void Attack(Villian target)
        {
            int amt = 0;
            if (this.GetType().Name == "Wizard")
            {
                amt = this.Lvl * this.Wisdom;

            }
            if (this.GetType().Name == "Warrior")
            {
                amt = this.Lvl * this.Strength;

            }
            target.Hp -= amt;
            Console.WriteLine($"{this.Name} uses {this.Weapon} on {this.Name} for {amt} damage.");
            if (target.Hp <= 0)
            { target.Kill(); }
        }
    }
}