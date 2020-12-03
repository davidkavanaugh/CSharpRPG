namespace TerminalRPG
{
    using System;
    class Warrior : Hero, IHero
    {
        private int Strength { get; }
        private int Wisdom { get; }
        public Warrior(string name) : base(name)
        {
            Name = name;
            Strength = 6;
            Wisdom = 3;
        }
        public void Attack(Villian target)
        {
            int amt = this.Lvl * this.Strength;
            target.Hp -= amt;
            Console.WriteLine($"{this.Name} uses sword on {target.Name} for {amt} damage.");
            if (target.Hp <= 0)
            { target.Kill(); }
        }
    }
}