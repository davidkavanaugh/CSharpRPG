namespace TerminalRPG
{
    using System;
    using System.Collections.Generic;
    public class Villian
    {
        public string Name { get; }
        public int Hp { get; set; }
        public Villian Next;

        public Villian(string name)
        {
            Name = name;
            Hp = 15;
            Next = null;
        }
        public void Kill()
        {
            VillianList.Remove(this);
        }
    }
    public class VillianList
    {
        public static Villian Head;
        public static int Count;
        public VillianList()
        {
            Head = null;
        }
        public void Add(Villian villian)
        {
            if (Head == null)
            {
                Head = villian;
            }
            else
            {
                Villian current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = villian;
            }
            Count++;
        }
        public static void Remove(Villian target)
        {
            if (Head != null)
            {
                if (Head == target)
                {
                    if (Head.Next != null)
                    { Head = Head.Next; }
                    else
                    { Head = null; }
                    Console.WriteLine($"The {target.Name} has been defeated!");
                    Count--;
                }
                else
                {
                    Villian current = Head;
                    while (current.Next != null)
                    {
                        if (current.Next == target)
                        {
                            if (current.Next.Next != null)
                            { current.Next = current.Next.Next; }
                            else
                            { current.Next = null; }
                            Console.WriteLine($"The {target.Name} has been defeated!");
                            Count--;
                        }
                        else
                        { current = current.Next; }
                    }
                }
            }
        }
        public static List<Villian> GetAll()
        {
            List<Villian> villiansList = new List<Villian>();
            if (Head == null)
            { villiansList = null; }
            else
            {
                Villian current = Head;
                villiansList.Add(current);
                while (current.Next != null)
                {
                    current = current.Next;
                    villiansList.Add(current);
                }
            }
            return villiansList;
        }
        public Villian GetVillianBySelectionNumber(int num)
        {
            try
            {
                return VillianList.GetAll()[num];
            }
            catch (System.IndexOutOfRangeException ex)
            {
                System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "index", ex);
                throw argEx;
            }
        }
    }
}