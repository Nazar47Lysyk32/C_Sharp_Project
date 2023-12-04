using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Warrior : Hero
    {
        public Warrior() { }


        public Warrior(string Name, int Health,
            int AttackPower,
            int ResistanceToPhysical,
            int ResistanceToMagical,
            int CriticalHealth,
            int DodgeChance) 
        {

            this.Name = "Archer";
            this.Health = 150;
            this.AttackPower = 20;
            this.ResistanceToMagical = 10;
            this.CriticalHealth = 35;
            this.DodgeChance = 20;

        }

        public int attack_dg(int attack_power, int CriticalChance, Attack attack_change)
        {
            Random random = new Random();
            int r = random.Next(1, 100);

            if (r <= CriticalChance)
            {
                attack_power *= 2;
            }

            if (attack_change == Attack.Physical)
            {
                return attack_power / ResistanceToPhysical;
            }

            else
            {
                return attack_power / ResistanceToMagical;
            }



        }
    }
}


