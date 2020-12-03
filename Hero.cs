namespace TerminalRPG
{
    abstract class Hero
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Lvl { get; set; }
        public Hero(string name)
        {
            Name = name;
            Hp = 50;
            Lvl = 1;
        }
    }
}