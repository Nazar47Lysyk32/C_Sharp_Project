using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    enum Attack
    {
        Physical,
        Magical

    }

    delegate void AttackDelegate
        (int AttackPower, 
        Attack attack,
        int CriticalChance); 

    internal class Hero
    {

     public string Name { get; set; }

     public int Health { get; set; }

     public int AttackPower { get; set; }

     public int ResistanceToPhysical { get; set; }

     public int ResistanceToMagical { get; set; }

     public int CriticalHealth { get; set; }

     public int DodgeChance { get; set; }




    }
}
