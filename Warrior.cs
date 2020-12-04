namespace TerminalRPG
{
    class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            Name = name;
            Strength = 6;
            Wisdom = 3;
            Weapon = "sword";
        }
    }
}