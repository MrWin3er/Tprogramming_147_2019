using System;

namespace RPG
{
    public abstract class Player
    {
        Random rnd = new Random();

        protected int maxHP;

        public string className = "";

        protected static string[] names = {"Welly", "Arthas", "Billy"};

        public Player()
        {
            Name = names[rnd.Next(0, 2)];
            maxHP = rnd.Next(100, 200);
            HP = maxHP;
            STR = rnd.Next(10, 20);
        }
        
        public string Name {get; protected set; }

        public int HP {get; protected set; }
        
        public int STR {get; protected set; }

        protected abstract void Skill();
    }
}