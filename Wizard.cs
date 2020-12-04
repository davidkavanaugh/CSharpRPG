namespace TerminalRPG
{
    class Wizard : Hero
    {
        public Wizard(string name) : base(name)
        {
            Strength = 3;
            Wisdom = 6;
            Weapon = "wand";
        }
    }
}