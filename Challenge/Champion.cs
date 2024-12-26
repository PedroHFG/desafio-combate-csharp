using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    internal class Champion
    {
        public string Name { get; set; }
        public int Life { get; set; }
        public int Attack { get; set; }
        public int Armor { get; set; }

        public Champion(string name, int life, int attack, int armor)
        {
            Name = name;
            Life = life;
            Attack = attack;
            Armor = armor;
        }

        public void TakeDamage(Champion other)
        {
            int attackForce = other.Attack - Armor;

            if (attackForce <= 0)
            {
                Life -= 1;
            }
            else
            {
                Life -= attackForce;
            }

            if (Life < 0)
            {
                Life = 0;
            }
        }

        public string Status()     
        {
            if (Life > 0)
            {
                return Name + ": " + Life + " de vida";
            }
            else
            {
                return Name + ": " + Life + " de vida (morreu)";
            }
        }
    }
}
