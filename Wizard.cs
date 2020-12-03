namespace TerminalRPG
{
    using System;
    class Wizard : Hero, IHero
    {
        public int Strength { get; }
        public int Wisdom { get; }
        public Wizard(string name) : base(name)
        {
            Strength = 3;
            Wisdom = 6;
        }
        public void Attack(Villian target)
        {
            int amt = this.Lvl * this.Wisdom;
            target.Hp -= amt;
            Console.WriteLine($"{this.Name} uses wand on {target.Name} for {amt} damage.");
            if (target.Hp <= 0)
            { target.Kill(); }
        }
    }
}